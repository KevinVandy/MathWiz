using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public partial class frmNewTest : Form
    {
        public frmNewTest()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Int64 aNumber = 0;

            //if form validation is good then
            if(ValidateForm())
            {
                //set values to build the test object based on which test is selected
                int min = 0;
                int max = 0;
                decimal threshold = 0.0m;
                int masteryLevel = 0;
                if (cboMinimum.Enabled == true)
                {
                    min = cboMinimum.SelectedIndex + 1;
                    max = cboMaximum.SelectedIndex + 1;
                }
                else
                {
                    threshold = Convert.ToDecimal(mskThreshold.Text);
                    masteryLevel = cboMaximum.SelectedIndex + 1;
                }
                List<Question> qL = new List<Question>();
                TimeSpan time = TimeSpan.Parse(mskTime.Text);
                bool isTrue = Convert.ToBoolean(cboRandom.SelectedIndex);
                
                
                //insert the test in to the DB get a number back with the primary key ID so we can generate questions for the test
                int caseswitch = cboType.SelectedIndex;
                switch (caseswitch)
                {
                    case 0:
                        PracticeTest practiceTest = new PracticeTest(qL, time, isTrue, min, max);
                        MathWizDB.InsertPracticeTest(practiceTest);
                        aNumber = MathWizDA.GetLastInsertedRecord("test", "id");
                        //need to resovle how we want to generate questions
                        practiceTest.Questions = Question.GenerateRandomQuestions(practiceTest.MaxLevel, practiceTest.TimeLimit);
                        foreach(Question q in practiceTest.Questions)
                        {
                            MessageBox.Show(q.QuestionText + q.CorrectAnswer);
                        }
                        break;
                    case 1:
                        PlacementTest PlacementTest = new PlacementTest(qL, time, isTrue, min, max);
                        MathWizDB.InsertPlacementTest(PlacementTest);
                        aNumber = MathWizDA.GetLastInsertedRecord("test", "id");
                        //need to resolve the how to create questions
                        PlacementTest.Questions = Question.GenerateRandomQuestions(PlacementTest.MaxLevel, PlacementTest.TimeLimit);
                        foreach (Question q in PlacementTest.Questions)
                        {
                            MessageBox.Show(q.QuestionText + q.CorrectAnswer);
                        }
                        break;
                    case 2:
                        MasteryTest masteryTest = new MasteryTest(qL, time, isTrue, masteryLevel, threshold);
                        MathWizDB.InsertMasteryTest(masteryTest);
                        aNumber = MathWizDA.GetLastInsertedRecord("test", "id");
                        //need to resolve the how on creatign questions
                        masteryTest.Questions = Question.GenerateRandomQuestions(masteryTest.MasteryLevel, masteryTest.TimeLimit);
                        foreach (Question q in masteryTest.Questions)
                        {
                            MessageBox.Show(q.QuestionText + q.CorrectAnswer);
                        }
                        break;


                }


            }
        }
        //validation methods for the form based on which test is selected
        private bool ValidateForm()
        {
            if(cboMinimum.Enabled == true)
            {
                if(Validation.IsComboSelected(cboType) &&
               Validation.IsMaskPresent(mskTime) &&
               Validation.IsComboSelected(cboMinimum) &&
               Validation.IsComboSelected(cboMaximum) &&
               Validation.IsComboSelected(cboRandom) &&
               Validation.secondIndexNotLower(cboMinimum, cboMaximum) == true)
               {
                    return true;
                }

                return false;
            }
            else
            {
                if(Validation.IsComboSelected(cboType) &&
               Validation.IsMaskPresent(mskTime) &&
               Validation.IsMaskPresent(mskThreshold) &&
               Validation.IsComboSelected(cboMaximum) &&
               Validation.IsComboSelected(cboRandom) &&
               Validation.secondIndexNotLower(cboMinimum, cboMaximum) == true)
                {
                    return true;
                }

                return false;
            }

        }
        //dynamically updates the controls on the form based on which test is selected
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int caseswtich = cboType.SelectedIndex;
            switch(caseswtich)
            {
                case 0:
                    cboMinimum.Enabled = true;
                    lblMaxMaster.Text = "Maximum Level:";
                    mskThreshold.Enabled = false;
                    break;
                case 1:
                    cboMinimum.Enabled = true;
                    lblMaxMaster.Text = "Maximum Level:";
                    mskThreshold.Enabled = false;
                    break;
                case 2:
                    cboMinimum.Enabled = false;
                    lblMaxMaster.Text = "Mastery Level:";
                    mskThreshold.Enabled = true;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewTest_Load(object sender, EventArgs e)
        {

        }
    }
}
