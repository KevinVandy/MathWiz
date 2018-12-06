using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MathWiz
{
    public partial class frmTeacherHome : Form
    {
        Teacher teacher;

        public frmTeacherHome(string username)
        {
            InitializeComponent();
            teacher = MathWizDA.SelectTeacher(username);
            teacher.Klasses = MathWizDA.SelectAllKlassesByTeacher(teacher.Id);
            
        }

        private void frmTeacherHome_Load(object sender, EventArgs e)
        {
            //put Images folder in debug folder 
            //images folder should be moved to directory the final exe is located
            //takes pic from folder to set as profile pic
            //string fileName = "teacher.jpg";
            //string filePath = Path.Combine(Environment.CurrentDirectory, @"Images\", fileName);
            //Image image = Image.FromFile(filePath);
            //picBoxTeacher.Image = (Image)image;
            //picBoxTeacher.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTeacherName.Text = teacher.FirstName;
            cmbKlasses.DataSource = teacher.Klasses;
            cmbKlasses.DisplayMember = "KlassName";


        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet.students);
            this.testsTableAdapter.Fill(this.mathWizGroup3DataSet.tests);
            this.gradedTestsTableAdapter.Fill(this.mathWizGroup3DataSet.graded_tests);
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvStudents.Update();
            dgvStudents.Refresh();

            dgvTests.Update();
            dgvTests.Refresh();
        }
        
        private void cmbKlasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Klass selectedItem = cmbKlasses.SelectedItem as Klass;
            this.studentsTableAdapter.FillByKlass(this.mathWizGroup3DataSet.students, selectedItem.Id);
            this.testsTableAdapter.FillByKlassID(this.mathWizGroup3DataSet.tests, selectedItem.Id);
                       

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            frmCreateTest createTest = new frmCreateTest(teacher.Klasses[cmbKlasses.SelectedIndex].Id); //passes the selected classID
            createTest.Show();
            //List<Question> qL = new List<Question>();
            //TimeSpan aTime = new TimeSpan(0, 1, 0);
            //qL = Question.GenerateRandomQuestions(1, aTime);
            //foreach(Question q in qL)
            //{
            //    MessageBox.Show(q.QuestionText + q.CorrectAnswer.ToString());
            //}
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStudents.SelectedRows[0];
            string studentName = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();
            int studentId = Int32.Parse(row.Cells["Id"].Value.ToString());
            //this.studentsTableAdapter.FillByKlass(this.mathWizGroup3DataSet.students, selectedItem.Id);

            
            this.gradedTestsTableAdapter.FillByGradedTests(this.mathWizGroup3DataSet.graded_tests, studentId);

        }

        private void dgvTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new frmAboutBox();
            aboutForm.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gradedTestsTableAdapter.FillBy(this.mathWizGroup3DataSet.graded_tests);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        
    }
}
