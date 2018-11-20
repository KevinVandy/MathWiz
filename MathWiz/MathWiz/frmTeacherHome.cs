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
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet.students);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet.students);
           
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


        private void cmbKlasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                Klass selectedItem = cmbKlasses.SelectedItem as Klass;

            this.studentsTableAdapter.FillByKlass(this.mathWizGroup3DataSet.students, selectedItem.Id);

            

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            frmCreateTest createTest = new frmCreateTest();
            createTest.Show();
            //List<Question> qL = new List<Question>();
            //TimeSpan aTime = new TimeSpan(0, 1, 0);
            //qL = Question.GenerateRandomQuestions(1, aTime);
            //foreach(Question q in qL)
            //{
            //    MessageBox.Show(q.QuestionText + q.CorrectAnswer.ToString());
            //}
        }

        private void studentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = studentTable.SelectedRows[0];
            string studentName = row.Cells["FirstName"] .Value.ToString() + " " + row.Cells[5].Value.ToString();
            grpBxStudentInfo.Text = studentName;
            
            grpBxStudentInfo.Visible = true;

        }
    }
}
