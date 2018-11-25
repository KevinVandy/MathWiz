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
    public partial class frmTakeTest : Form
    {
        Test test;
        GradedTest gradedTest;
        Student student;
        int testID;
        int currentQuestionNum = 0;

        public frmTakeTest(Student s, int tID) //default test ID of 0 if there is no ID passed
        {
            InitializeComponent();
            student = s;
            testID = tID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "placement":

                    gradedTest = new GradedPlacementTest();
                    gbxQuestion.Text = "Placement Test";
                    this.Text = "Placement Test";
                    break;

                case "practice":

                    gradedTest = new GradedPracticeTest();
                    this.Text = "Practice Test";
                    gbxQuestion.Text = "Practice Test";
                    break;

                case "mastery":

                    gradedTest = new GradedMasteryTest();
                    this.Text = "Mastery Test";
                    gbxQuestion.Text = "Mastery Test";
                    break;
            }

            this.Text += " - " + student.FirstName + " " + student.LastName;
            btnStartFinish.Text = "Start Test";
            gbxQuestion.Text = "";
            backgroundWorkerLoadTest.RunWorkerAsync();
        }

        private void backgroundWorkerLoadTest_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "placement":

                    test = MathWizDA.SelectPlacementTest(testID);
                    break;

                case "practice":

                    //TODO call a method to generate a test -- OR I guess load one from the database
                    break;

                case "mastery":

                    test = MathWizDA.SelectMasteryTest(testID);
                    break;
            }
        }

        private void backgroundWorkerLoadTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void ShowQuestion(Question q)
        {
            lblTimerQuestion.Text = q.TimeLimit.ToString();
            timerQuestion.Start();

            lblQuestionText.Text = q.QuestionText;

            lblCorrectAnswer.Hide();
            lblCorrectAnswer.Text = q.CorrectAnswer.ToString();
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (Validation.IsInteger(txtStudentAnswer))
            {
                if (Convert.ToInt16(txtStudentAnswer.Text.Trim()) == test.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], txtStudentAnswer.Text, true, new TimeSpan(0,1,1));
                    gradedTest.RightlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                    
                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], txtStudentAnswer.Text, true, new TimeSpan(0, 1, 1));
                    gradedTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
                }

                lblCorrectAnswer.Show();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(currentQuestionNum > 1)
            {
                currentQuestionNum--;
            }

            if (btnStartFinish.Visible)
            {
                btnStartFinish.Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentQuestionNum < test.Questions.Count)
            {
                currentQuestionNum++;
            }

            if(currentQuestionNum == test.Questions.Count)
            {
                btnStartFinish.Show();
            }
        }

        private void btnStartFinish_Click(object sender, EventArgs e)
        {
            if(btnStartFinish.Text == "Start Test")
            {
                currentQuestionNum = 1;
                btnStartFinish.Text = "Finish Test";
                gbxQuestion.Text = "Question " + currentQuestionNum.ToString() + " of " + test.Questions.Count;
                btnStartFinish.Hide();
                btnSubmitAnswer.Show();
                txtStudentAnswer.Show();

                if (true) //TODO is multiple choice
                {
                    pnlChoices.Show();
                }
                
            }
            else if(btnStartFinish.Text == "Finish Test")
            {
                //TODO record score
                gradedTest.Score = gradedTest.RightlyAnsweredQuestions.Count / gradedTest.RightlyAnsweredQuestions.Count + gradedTest.WronglyAnsweredQuestions.Count;
                gradedTest.TimeTakenToComplete = test.TimeLimit - TimeSpan.Parse(lblTimerTest.Text);
                gradedTest.DateTaken = DateTime.Now;
                gradedTest.Feedback = "";//TODO calculate feedback
            }
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            lblTimerTest.Text = timerTest.ToString();

            
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            lblTimerQuestion.Text = timerQuestion.ToString();

            if (TimeSpan.Parse(lblTimerQuestion.Text) <= new TimeSpan(0,0,0)) //if time runs out
            {
                timerQuestion.Stop();
                btnSubmitAnswer.Enabled = false;
                lblCorrectAnswer.Show();
            }
        }

        private void frmTakeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit this test? This may result in a grade of 0", "Are you sure?", MessageBoxButtons.YesNoCancel);
            if(dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
