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
        private int currentQuestionNum; //set to 0 when test starts

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
            backgroundWorkerLoadTest.RunWorkerAsync();
        }

        private void backgroundWorkerLoadTest_DoWork(object sender, DoWorkEventArgs e)
        {
            //switch (this.Tag.ToString())
            //{
            //    case "placement":

            //        test = MathWizDA.SelectPlacementTest(testID);
            //        break;

            //    case "practice":

            //        //TODO call a method to generate a test -- OR I guess load one from the database
            //        break;

            //    case "mastery":

            //        test = MathWizDA.SelectMasteryTest(testID);
            //        break;
            //}
        }

        private void backgroundWorkerLoadTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void ShowQuestion(Question q)
        {
            //show timer stuff
            timerQuestion.Start();
            lblTimerQuestion.Show();

            //show the question number
            gbxQuestion.Text = "Question " + (currentQuestionNum + 1).ToString() + " of " + test.Questions.Count;

            //show the question text
            lblQuestionText.Text = q.QuestionText;
            lblQuestionText.Show();

            //hide the answers, but set its text
            lblCorrectAnswer.Hide();
            lblCorrectAnswer.Text = q.CorrectAnswer.ToString();

            //show the buttons
            btnSubmitAnswer.Show();
            txtStudentAnswer.Show();


            // Multiple choice determined to be a stretch goal
            //if (false) //TODO is multiple choice
            //{
            //    pnlChoices.Show();
            //}

        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (Validation.IsInteger(txtStudentAnswer))
            {
                if (Convert.ToInt32(txtStudentAnswer.Text.Trim()) == test.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], txtStudentAnswer.Text, true, new TimeSpan(0,1,1));
                    gradedTest.CorrectlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                    
                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], txtStudentAnswer.Text, false, new TimeSpan(0, 1, 1));
                    gradedTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
                }
                //TODO: Correct answer doesn't show up
                //We can use Thread.Sleep(amountofTimeHere) to delay the program from moving on for a period of time
                lblCorrectAnswer.Show();

                currentQuestionNum++;

                if (currentQuestionNum < test.Questions.Count)
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
            if(btnStartFinish.Text == "Start Test") //start test, show the first question
            {
                btnStartFinish.Text = "Finish Test";
                btnStartFinish.Hide();

                currentQuestionNum = 0; //array starts at 0

                timerTest.Start();
                lblTimerTest.Show();
                
                ShowQuestion(test.Questions[currentQuestionNum]);
                
            }
            else if(btnStartFinish.Text == "Finish Test") //finish test, record score, write score to db
            {
                //TODO record score
                gradedTest.Score = gradedTest.CorrectlyAnsweredQuestions.Count / gradedTest.CorrectlyAnsweredQuestions.Count + gradedTest.WronglyAnsweredQuestions.Count;
                gradedTest.TimeTakenToComplete = test.TimeLimit - TimeSpan.Parse(lblTimerTest.Text);
                gradedTest.DateTaken = DateTime.Now;
                gradedTest.Feedback = gradedTest.Score.ToString();
            }
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = TimeSpan.ParseExact(lblTimerTest.Text, "mm\\:ss", CultureInfo.InvariantCulture);

            currentTime = currentTime.Subtract(new TimeSpan(0, 0, 1)); //subtract 1 second every tick

            lblTimerTest.Text = currentTime.Minutes.ToString("00") + ":" + currentTime.Seconds.ToString("00");

            if (lblTimerTest.Text == "00:00") //if time runs out for the entire test
            {
                TestTimeEnded();
            }
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = TimeSpan.ParseExact(lblTimerQuestion.Text, "mm\\:ss", CultureInfo.InvariantCulture);

            currentTime = currentTime.Subtract(new TimeSpan(0, 0, 1)); //subtract 1 second every tick

            lblTimerQuestion.Text = currentTime.Minutes.ToString("00") + ":" + currentTime.Seconds.ToString("00");

            if (lblTimerQuestion.Text == "00:00") //if time runs out for the current question
            {
                QuestionTimeEnded();
            }
            
        }

        // Could probably centralize code that's used both in QuestionTimeEnded + TestTimeEnded, but eh
        private void QuestionTimeEnded()
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

        private void TestTimeEnded()
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

        //stop accidental closing of the test form
        private void frmTakeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit this test? This may result in a grade of 0", "Are you sure?", MessageBoxButtons.YesNoCancel);
            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
