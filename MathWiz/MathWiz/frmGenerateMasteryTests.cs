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
    public partial class frmGenerateMasteryTests : Form
    {
        int klassID;

        public frmGenerateMasteryTests(int kID)
        {
            InitializeComponent();

            klassID = kID;
        }

        private void frmGenerateMasteryTests_Load(object sender, EventArgs e)
        {
            cboNumberOfQuestions.SelectedIndex = 0;
            cboQuestionSpeed.SelectedIndex = 0;
            cboPassThreshhold.SelectedIndex = 0;
        }

        private void btnGenerateTests_Click(object sender, EventArgs e)
        {
            for(int ml = 1; ml <= 12; ml++)
            {
                MasteryTest masteryTest = new MasteryTest();
                int numberOfQuestions;
                TimeSpan questionTimeLimit = new TimeSpan(0, 1, 0);
                TimeSpan testTimeLimit = new TimeSpan(1, 0, 0);
                decimal passThreshhold = 1;

                numberOfQuestions = Convert.ToInt32(cboNumberOfQuestions.SelectedItem);
                

                switch (cboQuestionSpeed.SelectedItem.ToString())
                {
                    case "Slow":

                        if(ml >= 1 && ml <= 3)
                        {
                            questionTimeLimit = new TimeSpan(0, 0, 45);
                        }
                        else if (ml >= 4 && ml <= 6)
                        {
                            questionTimeLimit = new TimeSpan(0, 1, 0);
                        }
                        else if (ml >= 7 && ml <= 9)
                        {
                            questionTimeLimit = new TimeSpan(0, 0, 45);
                        }
                        else if (ml >= 10 && ml <= 12)
                        {
                            questionTimeLimit = new TimeSpan(0, 3, 0);
                        }

                        break;

                    case "Medium":

                        if (ml >= 1 && ml <= 3)
                        {
                            questionTimeLimit = new TimeSpan(0, 0, 30);
                        }
                        else if (ml >= 4 && ml <= 6)
                        {
                            questionTimeLimit = new TimeSpan(0, 0, 45);
                        }
                        else if (ml >= 7 && ml <= 9)
                        {
                            questionTimeLimit = new TimeSpan(0, 0, 30);
                        }
                        else if (ml >= 10 && ml <= 12)
                        {
                            questionTimeLimit = new TimeSpan(0, 2, 0);
                        }

                        break;

                    case "Fast":

                        if (ml >= 1 && ml <= 3)
                        {
                            questionTimeLimit = new TimeSpan(0, 0, 15);
                        }
                        else if (ml >= 4 && ml <= 6)
                        {
                            questionTimeLimit = new TimeSpan(0, 0, 30);
                        }
                        else if (ml >= 7 && ml <= 9)
                        {
                            questionTimeLimit = new TimeSpan(0, 0, 15);
                        }
                        else if (ml >= 10 && ml <= 12)
                        {
                            questionTimeLimit = new TimeSpan(0, 1, 0);
                        }

                        break;
                }

                switch (cboPassThreshhold.SelectedItem.ToString())
                {
                    case "70%":

                        passThreshhold = .7m;

                        break;

                    case "80%":

                        passThreshhold = .8m;

                        break;

                    case "90%":

                        passThreshhold = .9m;

                        break;

                    case "95%":

                        passThreshhold = .95m;

                        break;

                    case "100%":

                        passThreshhold = 1m;

                        break;

                }
                
                masteryTest.MasteryLevel = ml;
                masteryTest.Questions = Question.GenerateRandomQuestions(ml, questionTimeLimit, numberOfQuestions);
                masteryTest.TimeLimit = TimeSpan.FromTicks(questionTimeLimit.Ticks * numberOfQuestions);
                masteryTest.PassThreshhold = passThreshhold;
                masteryTest.RandomlyGenerated = true;

                MathWizDB.InsertTest(klassID, masteryTest, "Mastery Test", masteryTest.PassThreshhold, masteryTest.MasteryLevel, masteryTest.MasteryLevel);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
