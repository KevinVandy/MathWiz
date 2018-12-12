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
        GradedPlacementTest gradedPlacementTest;
        GradedPracticeTest gradedPracticeTest;
        GradedMasteryTest gradedMasteryTest;
        Student student;
        Klass klass;
        int currentQuestionNum; //set to 0 when test starts
        bool testFinished;

        public frmTakeTest(Student s, Klass k , Test t ) 
        {
            InitializeComponent();
            student = s;
            klass = k;
            test = t;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            lblStudentName.Text = student.FirstName + " " + student.LastName;
            lblClassName.Text = klass.KlassName;

            switch (this.Tag.ToString())
            {
                case "placement":

                    gradedPlacementTest = new GradedPlacementTest();
                    gradedPlacementTest.PlacementTest = (PlacementTest)test;
                    gbxQuestion.Text = "Placement Test";
                    this.Text = "Placement Test";
                    lblTimerTest.Text = gradedPlacementTest.PlacementTest.TimeLimit.Minutes.ToString("00") + ":" + gradedPlacementTest.PlacementTest.TimeLimit.Seconds.ToString("00");
                    break;

                case "practice":

                    gradedPracticeTest = new GradedPracticeTest();
                    gradedPracticeTest.PracticeTest = (PracticeTest)test;
                    this.Text = "Practice Test";
                    gbxQuestion.Text = "Practice Test";
                    lblTimerTest.Text = gradedPracticeTest.PracticeTest.TimeLimit.Minutes.ToString("00") + ":" + gradedPracticeTest.PracticeTest.TimeLimit.Seconds.ToString("00");
                    break;

                case "mastery":

                    gradedMasteryTest = new GradedMasteryTest();
                    gradedMasteryTest.MasteryTest = (MasteryTest)test;
                    this.Text = "Mastery Test";
                    gbxQuestion.Text = "Mastery Test";
                    lblTimerTest.Text = gradedMasteryTest.MasteryTest.TimeLimit.Minutes.ToString("00") + ":" + gradedMasteryTest.MasteryTest.TimeLimit.Seconds.ToString("00");
                    break;
            }

            this.Text += " - " + student.FirstName + " " + student.LastName;
            btnStartFinish.Text = "Start Test";
            gbxQuestion.Text = "";
            
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

                ShowQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum]);

                testFinished = false;

            }
            else if (btnStartFinish.Text == "Finish Test") //finish test, record score, write score to db
            {
                switch (this.Tag.ToString())
                {
                    case "placement":



                        break;

                    case "practice":

                        //record information for the completed test
                        gradedPracticeTest.Score = (decimal)gradedPracticeTest.CorrectlyAnsweredQuestions.Count / (decimal)(gradedPracticeTest.CorrectlyAnsweredQuestions.Count + (decimal)gradedPracticeTest.WronglyAnsweredQuestions.Count) * 100;
                        gradedPracticeTest.TimeTakenToComplete = gradedPracticeTest.PracticeTest.TimeLimit - TimeSpan.ParseExact(lblTimerTest.Text, "mm\\:ss", CultureInfo.InvariantCulture);
                        gradedPracticeTest.DateTaken = DateTime.Now;
                        gradedPracticeTest.Feedback = gradedPracticeTest.Score.ToString();

                        break;
                        
                    case "mastery":



                        break;
                }
                
                //write test to database in another thread
                backgroundWorkerSaveTest.RunWorkerAsync();
            }
            
        }

        //Thread for saving the graded test (and sometimes the practice test
        void backgroundWorkerSaveTest_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "placement":

                    int recommendedLevel = 1; //TODO calculate recommended level

                    MathWizDB.InsertGradedTest(gradedPlacementTest, student.Id, gradedPlacementTest.PlacementTest.Id, "Placement Test", recommendedLevel);

                    break;

                case "practice":

                    //first insert the test since the teacher did not make it, but the student just generated it
                    gradedPracticeTest.PracticeTest.Id = MathWizDB.InsertTest(klass.Id, gradedPracticeTest.PracticeTest, "Practice Test", 0, gradedPracticeTest.PracticeTest.MinLevel, gradedPracticeTest.PracticeTest.MaxLevel);

                    //then insert the graded test. The insertGradedTest method also inserts the graded Questions
                    gradedPracticeTest.Id = MathWizDB.InsertGradedTest(gradedPracticeTest, student.Id, gradedPracticeTest.PracticeTest.Id, "Practice Test");

                    break;

                case "mastery":

                    bool passed = true; //TODO calculate weather the student passed the test
                                        //TODO keep track of the number of attempts that it has taken the student to pass

                    MathWizDB.InsertGradedTest(gradedMasteryTest, student.Id, gradedMasteryTest.MasteryTest.Id, "Mastery Test", null, 1, passed);

                    break;
            }
        }

        void backgroundWorkerSaveTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            testFinished = true; //now it this should close with no warning message
            this.Close();
        }

        private async void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (Validation.IsInteger(txtStudentAnswer))
            {
                string studentAnswer = txtStudentAnswer.Text;
                TimeSpan timeTakenToAnswer = gradedPracticeTest.PracticeTest.Questions[currentQuestionNum].TimeLimit - TimeSpan.ParseExact(lblTimerQuestion.Text, "mm\\:ss", CultureInfo.InvariantCulture);

                if (Convert.ToInt32(txtStudentAnswer.Text.Trim()) == gradedPracticeTest.PracticeTest.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum], studentAnswer, true, timeTakenToAnswer);
                    gradedPracticeTest.CorrectlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                    txtStudentAnswer.ForeColor = Color.FromArgb(0, 255, 0);
                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum], studentAnswer, false, timeTakenToAnswer);
                    gradedPracticeTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);

                    txtStudentAnswer.ForeColor = Color.FromArgb(255, 0, 0);
                }

                lblCorrectAnswer.Show();
                await Task.Delay(1000); //show the answer for a bit

                currentQuestionNum++;

                if (currentQuestionNum < gradedPracticeTest.PracticeTest.Questions.Count)
                {
                    ShowQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum]);
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
            lblTimerQuestion.Text = gradedPracticeTest.PracticeTest.Questions[currentQuestionNum].TimeLimit.Minutes.ToString("00") + ":" + gradedPracticeTest.PracticeTest.Questions[currentQuestionNum].TimeLimit.Seconds.ToString("00");

            //show the question number
            gbxQuestion.Text = "Question " + (currentQuestionNum + 1).ToString() + " of " + gradedPracticeTest.PracticeTest.Questions.Count;

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

            if (currentQuestionNum < gradedPracticeTest.PracticeTest.Questions.Count())
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

                if (Convert.ToInt32(studentAnswer) == gradedPracticeTest.PracticeTest.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum], studentAnswer, true, new TimeSpan(0, 1, 1));
                    gradedPracticeTest.CorrectlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum], studentAnswer, false, new TimeSpan(0, 1, 1));
                    gradedPracticeTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
                }
            }

            lblCorrectAnswer.Show();

            currentQuestionNum++;

            if (currentQuestionNum <= gradedPracticeTest.PracticeTest.Questions.Count)
            {
                ShowQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum]);
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
            if(currentQuestionNum < gradedPracticeTest.PracticeTest.Questions.Count())
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

                if (Convert.ToInt32(studentAnswer) == gradedPracticeTest.PracticeTest.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum], studentAnswer, true, new TimeSpan(0, 1, 1));
                    gradedPracticeTest.CorrectlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(gradedPracticeTest.PracticeTest.Questions[currentQuestionNum], studentAnswer, false, new TimeSpan(0, 1, 1));
                    gradedPracticeTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
                }
            }


            currentQuestionNum++;
            lblCorrectAnswer.Show();
            
            //If the timer ends and the student isn't on the last question then..
            if(currentQuestionNum < gradedPracticeTest.PracticeTest.Questions.Count())
            {
                // Have the rest of the unanswered questions end up as automatic wrongly answered questions
                // and add them to the graded test
                // Don't know if having student answer be null would be bad, so I threw a 0 in there which will
                // result in the question being wrong 99% of the time.
                for (int x = currentQuestionNum; x < gradedPracticeTest.PracticeTest.Questions.Count(); x++)
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(gradedPracticeTest.PracticeTest.Questions[x], "0", false, new TimeSpan(0, 1, 1));
                    gradedPracticeTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
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
