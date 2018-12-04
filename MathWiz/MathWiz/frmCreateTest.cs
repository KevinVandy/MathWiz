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
    public partial class frmCreateTest : Form
    {
        int klassID;

        public frmCreateTest(int kID)
        {
            InitializeComponent();
            klassID = kID;
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
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
                    //Case Practice test
                    case 0:
                        PracticeTest practiceTest = new PracticeTest(qL, time, isTrue, min, max);
                        MathWizDB.InsertPracticeTest(practiceTest, klassID);
                        aNumber = MathWizDA.GetLastInsertedRecord("test", "id");
                        //need to resovle how we want to generate questions
                        this.Close();
                        practiceTest.Questions = Question.GenerateRandomQuestions(practiceTest.MaxLevel, practiceTest.TimeLimit,10);
                        foreach(Question q in practiceTest.Questions)
                        {
                            MathWizDB.InsertTestQuestionsPractice(practiceTest, q, aNumber);
                        }
                        MessageBox.Show("Your new randomly generated Practice test has been created");
                        break;



                    //case Placement Test
                    case 1:
                        PlacementTest PlacementTest = new PlacementTest(qL, time, isTrue, min, max);
                        MathWizDB.InsertPlacementTest(PlacementTest, klassID);
                        aNumber = MathWizDA.GetLastInsertedRecord("test", "id");
                        //need to resolve the how to create questions
                        this.Close();
                        PlacementTest.Questions = Question.GenerateRandomQuestions(PlacementTest.MaxLevel, PlacementTest.TimeLimit, 10);
                        foreach (Question q in PlacementTest.Questions)
                        {
                            MathWizDB.InsertTestQuestionPlacement(PlacementTest, q, aNumber);
                        }
                        MessageBox.Show("Your new randomly generated Placement test has been created");
                        break;



                    //case Mastery Test
                    case 2:
                        MasteryTest masteryTest = new MasteryTest(qL, time, isTrue, masteryLevel, threshold);
                        MathWizDB.InsertMasteryTest(masteryTest, klassID);
                        aNumber = MathWizDA.GetLastInsertedRecord("test", "id");
                        //need to resolve the how on creating questions
                        this.Close();
                        masteryTest.Questions = Question.GenerateRandomQuestions(masteryTest.MasteryLevel, masteryTest.TimeLimit,10);
                        foreach (Question q in masteryTest.Questions)
                        {
                            MathWizDB.InsertTestQuestionMastery(masteryTest, q, aNumber);
                        }
                        MessageBox.Show("Your new randomly generated mastery test has been created");
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

        
    }
}
