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
    public partial class frmCreatePlacementTest : Form
    {
        int klassID;

        public frmCreatePlacementTest(int kID)
        {
            InitializeComponent();
            klassID = kID;
        }

        private void frmCreatePlacementTest_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            //if form validation is good then
            if (ValidateForm())
            {
                int numberOfQuestions = Convert.ToInt32(cboNumberOfQuestions.SelectedItem);
                int numberOfQuestionsPerML = numberOfQuestions / 12; //take a few questions from each mastery level
                TimeSpan questionTimeLimit = new TimeSpan(0,1,0);

                PlacementTest placementTest = new PlacementTest();
                
                for (int ml = 1; ml <= 12; ml++) //get questions from each mastery level
                {
                    //make custom timelimits for each question depending on complexity
                    questionTimeLimit = CalculateQuestionTimeLimit(cboQuestionSpeed.SelectedItem.ToString(), ml);

                    //get the questions for just the current mastery level in this for loop
                    List<Question> tempQuestionList = Question.GenerateRandomQuestions(ml, questionTimeLimit, numberOfQuestionsPerML);

                    foreach (Question q in tempQuestionList) //add current mastery level questions to the actual placement test
                    {
                        placementTest.Questions.Add(q);
                    }
                }
                MessageBox.Show(placementTest.Questions.Count().ToString());
                //set other attributes of the test
                placementTest.MinLevel = 1;
                placementTest.MaxLevel = 12;
                placementTest.TimeLimit = TimeSpan.FromTicks(questionTimeLimit.Ticks * numberOfQuestions);

                //insert it
                placementTest.Id = MathWizDB.InsertTest(klassID, placementTest, "Placement Test", 0, placementTest.MinLevel, placementTest.MaxLevel);

                this.Close();
                
                if(placementTest.Id > 0)
                {
                    MessageBox.Show("Your new randomly generated Placement test has been created");
                }
                else
                {
                    MessageBox.Show("Failed to create placement test", "error");
                }
            }
            else
            {
                MessageBox.Show("A placement test has already been created for this class.","error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TimeSpan CalculateQuestionTimeLimit(string speed, int ml)
        {
            switch (speed) //figure out the time limit for each question
            {
                case "Slow":

                    if (ml >= 1 && ml <= 3)
                    {
                        return new TimeSpan(0, 0, 45);
                    }
                    else if (ml >= 4 && ml <= 6)
                    {
                        return new TimeSpan(0, 1, 0);
                    }
                    else if (ml >= 7 && ml <= 9)
                    {
                        return new TimeSpan(0, 0, 45);
                    }
                    else if (ml >= 10 && ml <= 12)
                    {
                        return new TimeSpan(0, 3, 0);
                    }

                    break;

                case "Medium":

                    if (ml >= 1 && ml <= 3)
                    {
                        return new TimeSpan(0, 0, 30);
                    }
                    else if (ml >= 4 && ml <= 6)
                    {
                        return new TimeSpan(0, 0, 45);
                    }
                    else if (ml >= 7 && ml <= 9)
                    {
                        return new TimeSpan(0, 0, 30);
                    }
                    else if (ml >= 10 && ml <= 12)
                    {
                        return new TimeSpan(0, 2, 0);
                    }

                    break;

                case "Fast":

                    if (ml >= 1 && ml <= 3)
                    {
                        return new TimeSpan(0, 0, 15);
                    }
                    else if (ml >= 4 && ml <= 6)
                    {
                        return new TimeSpan(0, 0, 30);
                    }
                    else if (ml >= 7 && ml <= 9)
                    {
                        return new TimeSpan(0, 0, 15);
                    }
                    else if (ml >= 10 && ml <= 12)
                    {
                        return new TimeSpan(0, 1, 0);
                    }

                    break;
            }
            return new TimeSpan(0, 1, 0); //default
        }

        //validation methods for the form based on which test is selected
        private bool ValidateForm()
        {
            if(Validation.IsComboSelected(cboNumberOfQuestions) && Validation.IsComboSelected(cboQuestionSpeed))
            {
                return true;
            }
            return false;
        }
    } 
}
