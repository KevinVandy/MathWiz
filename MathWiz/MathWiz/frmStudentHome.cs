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
    public partial class frmStudentHome : Form
    {
        Student student;
        int klassID;

        PlacementTest availablePlacementTest;
        List<PracticeTest> availablePracticeTests;
        List<MasteryTest> availableMasteryTests;
        

        public frmStudentHome(string username)
        {
            InitializeComponent();
            student = MathWizDA.SelectStudent(username); //this has to go here
        }

        private void frmStudentHome_Load(object sender, EventArgs e)
        {
            if(student.MasteryLevel == 0)
            {
                btnTakePracticeTest.Enabled = false;
                btnTakeMasteryTest.Enabled = false;
                btnTakePlacementTest.Enabled = true;
            }
            else
            {
                btnTakePracticeTest.Enabled = true;
                btnTakeMasteryTest.Enabled = true;
                btnTakePlacementTest.Enabled = false;
            }
            backgroundWorkerLoadData.RunWorkerAsync();
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            if(student.MasteryLevel == 0) //if student has not taken placement test yet, only load that test
            {
                availablePlacementTest = MathWizDA.SelectKlassesPlacementTest(klassID);
            }
            else //load the tests that the student can take, but not the placement test since they already took it
            {
                klassID = MathWizDA.SelectStudentsKlassID(student.Id);
                availablePracticeTests = MathWizDA.SelectKlassesPracticeTests(klassID);
                availableMasteryTests = MathWizDA.SelectKlassesMasteryTests(klassID);
            }
            
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStudentName.Text = "Student: " + student.FirstName + " " + student.LastName;
            lblMasteryLevel.Text = "Mastery Level: " + student.MasteryLevel.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new frmAboutBox();
            aboutForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTakePlacementTest_Click(object sender, EventArgs e)
        {
            Form placementForm = new frmTakeTest(student, availablePlacementTest); //TODO Pass Correct Test object
            placementForm.Tag = "placement";
            placementForm.ShowDialog();
        }

        private void btnTakePracticeTest_Click(object sender, EventArgs e)
        {
            Form practiceForm = new frmTakeTest(student, null);
            practiceForm.Tag = "practice";
            practiceForm.ShowDialog();
        }

        private void btnTakeRandomPracticeTest_Click(object sender, EventArgs e)
        {
            //TODO: Hook up Number Of Questions, so that the variable number of questions reflects the test
            //When a user quits out of a test, and starts up another one, they start with 10+ more questions than prior
            int masteryLevel = Convert.ToInt16(cmbMasteryLevel.SelectedItem);
            int numberOfQuestions = Convert.ToInt16(cmbNumberOfQuestions.SelectedItem);
            PracticeTest practiceTest = new PracticeTest(Question.GenerateRandomQuestions(masteryLevel, new TimeSpan(0, 0, 30), numberOfQuestions), new TimeSpan(0, 10, 0), true, masteryLevel, masteryLevel);
            

            Form practiceForm = new frmTakeTest(student, practiceTest);
            practiceForm.Tag = "practice";
            practiceForm.ShowDialog();
        }

        private void btnTakeMasteryTest_Click(object sender, EventArgs e)
        {
            Form masteryForm = new frmTakeTest(student, null); //Passes the students mastery level
            masteryForm.Tag = "mastery";
            masteryForm.ShowDialog();
        }
    }
}
