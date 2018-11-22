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
                    gbxQuestion.Text = "Placement Test";
                    this.Text = "Placement Test";
                    break;
                case "practice":
                    this.Text = "Practice Test";
                    gbxQuestion.Text = "Practice Test";
                    lblTimerQuestion.Visible = false;
                    lblTimerTest.Visible = false;
                    break;
                case "mastery":
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
                    test = MathWizDA.SelectPlaceTest(testID);
                    break;
                case "practice":
                    //TODO call a method to generate a test -- OR I guess load one from the database
                    break;
                case "mastery":
                    test = MathWizDA.SelectMastTest(testID);
                    break;
            }
        }

        private void backgroundWorkerLoadTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void ShowQuestion(Question q)
        {

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
                btnStartFinish.Text = "Finish Test";
                btnStartFinish.Visible = false;
                currentQuestionNum++;
                gbxQuestion.Text = "Question " + currentQuestionNum.ToString() + " of " + test.Questions.Count;
            }
            else if(btnStartFinish.Text == "Finish Test")
            {
                //TODO record score
            }
        }
    }
}
