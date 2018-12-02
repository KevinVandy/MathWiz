using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public partial class frmTakeTest : Form
    {
        Test test;
        GradedTest gradedTest;
        Student student;
        int currentQuestionNum; //set to 0 when test starts
        bool testFinished;

        public frmTakeTest(Student s, Test t) 
        {
            InitializeComponent();
            student = s;
            test = t;
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

                default:
                    gradedTest = new GradedPracticeTest();
                    this.Text = "Practice Test";
                    gbxQuestion.Text = "Practice Test";
                    break;
            }

            this.Text += " - " + student.FirstName + " " + student.LastName;
            btnStartFinish.Text = "Start Test";
            gbxQuestion.Text = "";
            lblTimerTest.Text = test.TimeLimit.Minutes.ToString("00") + ":" + test.TimeLimit.Seconds.ToString("00");

            gbxQuestion.Hide();
        }

        //MARK Button Handlers
        private void btnStartFinish_Click(object sender, EventArgs e)
        {
            if (btnStartFinish.Text == "Start Test") //start test, show the first question
            {
                btnStartFinish.Text = "Finish Test";
                btnStartFinish.Hide();

                gbxQuestion.Show();

                currentQuestionNum = 0; //array starts at 0

                timerTest.Start();

                ShowQuestion(test.Questions[currentQuestionNum]);

                testFinished = false;

            }
            else if (btnStartFinish.Text == "Finish Test") //finish test, record score, write score to db
            {
                gradedTest.Score = (decimal)gradedTest.CorrectlyAnsweredQuestions.Count / (decimal)(gradedTest.CorrectlyAnsweredQuestions.Count + (decimal)gradedTest.WronglyAnsweredQuestions.Count) * 100;
                gradedTest.TimeTakenToComplete = test.TimeLimit - TimeSpan.ParseExact(lblTimerTest.Text, "mm\\:ss", CultureInfo.InvariantCulture);
                gradedTest.DateTaken = DateTime.Now;
                gradedTest.Feedback = gradedTest.Score.ToString();

                //write to database

                MessageBox.Show("Score: " + gradedTest.Score.ToString() + "%\n\n" + gradedTest.Feedback);

                testFinished = true;
                this.Close();
            }
        }

        private async void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (Validation.IsInteger(txtStudentAnswer))
            {
                string studentAnswer = txtStudentAnswer.Text;
                TimeSpan timeTakenToAnswer = test.Questions[currentQuestionNum].TimeLimit - TimeSpan.ParseExact(lblTimerQuestion.Text, "mm\\:ss", CultureInfo.InvariantCulture);

                if (Convert.ToInt32(txtStudentAnswer.Text.Trim()) == test.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], studentAnswer, true, timeTakenToAnswer);
                    gradedTest.CorrectlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                    txtStudentAnswer.ForeColor = Color.FromArgb(0, 255, 0);
                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], studentAnswer, false, timeTakenToAnswer);
                    gradedTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);

                    txtStudentAnswer.ForeColor = Color.FromArgb(255, 0, 0);
                }

                lblCorrectAnswer.Show();

                await Task.Delay(1500); //show the answer for a bit

                currentQuestionNum++;

                if (currentQuestionNum < test.Questions.Count)
                {
                    ShowQuestion(test.Questions[currentQuestionNum]);
                }
                else //the test if finished
                {
                    btnStartFinish.Show();
                    btnStartFinish.Focus();
                    txtStudentAnswer.Enabled = false;
                    btnSubmitAnswer.Enabled = false;

                    timerQuestion.Stop();
                    timerTest.Stop();
                }

                txtStudentAnswer.Text = "";
            }
        }
        //End Button Handlers

        //MARK Timer Tick Handlers
        private void timerTest_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = TimeSpan.ParseExact(lblTimerTest.Text, "mm\\:ss", CultureInfo.InvariantCulture);

            currentTime = currentTime.Subtract(new TimeSpan(0, 0, 1)); //subtract 1 second every tick

            lblTimerTest.Text = currentTime.Minutes.ToString("00") + ":" + currentTime.Seconds.ToString("00");

            if (lblTimerTest.Text == "00:00") //if time runs out for the entire test
            {
                EndTest();
            }
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = TimeSpan.ParseExact(lblTimerQuestion.Text, "mm\\:ss", CultureInfo.InvariantCulture);

            currentTime = currentTime.Subtract(new TimeSpan(0, 0, 1)); //subtract 1 second every tick

            lblTimerQuestion.Text = currentTime.Minutes.ToString("00") + ":" + currentTime.Seconds.ToString("00");

            if (lblTimerQuestion.Text == "00:00") //if time runs out for the current question
            {
                EndQuestion();
            }
        }
        //End Timer Tick Handlers

        //MARK Methods
        private void ShowQuestion(Question q)
        {
            //show timer stuff
            timerQuestion.Start();
            lblTimerQuestion.Text = test.Questions[currentQuestionNum].TimeLimit.Minutes.ToString("00") + ":" + test.Questions[currentQuestionNum].TimeLimit.Seconds.ToString("00");

            //show the question number
            gbxQuestion.Text = "Question " + (currentQuestionNum + 1).ToString() + " of " + test.Questions.Count;

            //show the question text
            lblQuestionText.Text = q.QuestionText;

            //hide the answers, but set its text
            lblCorrectAnswer.Hide();
            lblCorrectAnswer.Text = q.CorrectAnswer.ToString();

            //show the buttons and textbox
            txtStudentAnswer.Focus();
        }
        
        private void EndQuestion()
        {
            timerQuestion.Stop();
            string studentAnswer = "";
            int n;
            bool isNumeric = int.TryParse(txtStudentAnswer.Text, out n);

            if (currentQuestionNum < test.Questions.Count())
            {
                // We still want this code to grab the student's answer if they have anything on the current question
                if (txtStudentAnswer.Text == "" || txtStudentAnswer.Text == null || isNumeric == false)
                {
                    studentAnswer = "0";
                }
                else
                {
                    studentAnswer = txtStudentAnswer.Text.Trim();
                }

                if (Convert.ToInt32(studentAnswer) == test.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], studentAnswer, true, new TimeSpan(0, 1, 1));
                    gradedTest.CorrectlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], studentAnswer, false, new TimeSpan(0, 1, 1));
                    gradedTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
                }
            }

            lblCorrectAnswer.Show();

            currentQuestionNum++;

            if (currentQuestionNum <= test.Questions.Count)
            {
                ShowQuestion(test.Questions[currentQuestionNum]);
                // reset the timer if there is a next question
                lblTimerQuestion.Text = "01:00";
            }
            else //the test if finished
            {
                btnStartFinish.Show();
                btnSubmitAnswer.Enabled = false;
            }
        }

        private void EndTest()
        {
            // stop the times
            timerTest.Stop();
            timerQuestion.Stop();

            // variables
            string studentAnswer = "";
            int n;
            bool isNumeric = int.TryParse(txtStudentAnswer.Text, out n);

            // Because if the user clicks submit on the very last problem, and waits out the time
            // it'll throw an errow if we don't check for this.
            if(currentQuestionNum < test.Questions.Count())
            {
                // We still want this code to grab the student's answer if they have anything on the current question
                if (txtStudentAnswer.Text == "" || txtStudentAnswer.Text == null || isNumeric == false)
                {
                    studentAnswer = "0";
                }
                else
                {
                    studentAnswer = txtStudentAnswer.Text.Trim();
                }

                if (Convert.ToInt32(studentAnswer) == test.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], studentAnswer, true, new TimeSpan(0, 1, 1));
                    gradedTest.CorrectlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], studentAnswer, false, new TimeSpan(0, 1, 1));
                    gradedTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
                }
            }


            currentQuestionNum++;
            lblCorrectAnswer.Show();
            
            //If the timer ends and the student isn't on the last question then..
            if(currentQuestionNum < test.Questions.Count())
            {
                // Have the rest of the unanswered questions end up as automatic wrongly answered questions
                // and add them to the graded test
                // Don't know if having student answer be null would be bad, so I threw a 0 in there which will
                // result in the question being wrong 99% of the time.
                for (int x = currentQuestionNum; x < test.Questions.Count(); x++)
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(test.Questions[x], "0", false, new TimeSpan(0, 1, 1));
                    gradedTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
                }
            }

            btnStartFinish.Text = "Finish Test";
            btnStartFinish.Show();
            btnSubmitAnswer.Enabled = false;
            
        }
        
        private void txtStudentAnswer_TextChanged(object sender, EventArgs e)
        {
            txtStudentAnswer.ForeColor = Color.FromArgb(0, 0, 0); //makes the text normal when typing the next answer
        }

        //stop accidental closing of the test form
        private void frmTakeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!testFinished) //only ask if they have not finished the test yet
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit this test? This may result in a grade of 0", "Are you sure?", MessageBoxButtons.YesNoCancel);
                if (dialogResult != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
