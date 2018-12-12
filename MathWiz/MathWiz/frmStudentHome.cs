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
        Klass klass = new Klass();

        PlacementTest availablePlacementTest = new PlacementTest();
        List<MasteryTest> availableMasteryTests = new List<MasteryTest>();
        

        public frmStudentHome(string username)
        {
            InitializeComponent();
            student = MathWizDA.SelectStudent(username); //this has to go here
        }

        private void frmStudentHome_Load(object sender, EventArgs e)
        {
            cmbMasteryLevel.SelectedIndex = student.MasteryLevel;
            cmbNumberOfQuestions.SelectedIndex = 1;
            
            backgroundWorkerLoadData.RunWorkerAsync();
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            klass = MathWizDA.SelectStudentsKlass(student.Id);

            if (student.MasteryLevel == 0) //if student has not taken placement test yet, only load that test
            {
                availablePlacementTest = MathWizDA.SelectKlassesPlacementTest(klass.Id);
            }
            else //load the tests that the student can take, but not the placement test since they already took it
            {
                availableMasteryTests = MathWizDA.SelectKlassesMasteryTests(klass.Id);
            }
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStudentName.Text = "Logged in as: " + student.FirstName + " " + student.LastName;
            lblKlassName.Text = "Class Name: " + klass.KlassName;
            lblMasteryLevel.Text = "Mastery Level: " + student.MasteryLevel.ToString();

            if (student.MasteryLevel == 0)
            {
                if(availablePlacementTest != null)
                {
                    btnTakePlacementTest.Enabled = true;
                }

                btnTakeMasteryTest.Enabled = false; //students at mastery level 0 need to take placement test before mastery tests
                
            }
            else if(student.MasteryLevel > 0)
            {
                if(availableMasteryTests.Count > 0)
                {
                    btnTakeMasteryTest.Enabled = true;
                }

                btnTakePlacementTest.Enabled = false; //students who have already taken the placement test do not need to take it again
            }
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
            if(availablePlacementTest != null)
            {
                Form placementForm = new frmTakeTest(student, klass, availablePlacementTest); //TODO Pass Correct Test object
                placementForm.Tag = "placement";
                placementForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your teacher has not made your Placement Test yet");
            }
        }

        private void btnTakeRandomPracticeTest_Click(object sender, EventArgs e)
        {
            if(Validation.IsComboSelected(cmbMasteryLevel) && Validation.IsComboSelected(cmbNumberOfQuestions))
            {
                int masteryLevel = Convert.ToInt16(cmbMasteryLevel.SelectedItem);
                int numberOfQuestions = Convert.ToInt16(cmbNumberOfQuestions.SelectedItem);
                PracticeTest practiceTest = new PracticeTest(Question.GenerateRandomQuestions(masteryLevel, new TimeSpan(0, 0, 30), numberOfQuestions), new TimeSpan(0, 10, 0), true, masteryLevel, masteryLevel);


                Form practiceForm = new frmTakeTest(student, klass, practiceTest);
                practiceForm.Tag = "practice";
                practiceForm.ShowDialog();
            }
        }

        private void btnTakeMasteryTest_Click(object sender, EventArgs e)
        {
            Form masteryForm = new frmTakeTest(student, klass, availableMasteryTests[student.MasteryLevel]); //Passes the students mastery level
            masteryForm.Tag = "mastery";
            masteryForm.ShowDialog();
        }
    }
}
