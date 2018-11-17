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
            //currently local folder in debug folder containing images
            //images folder should be moved to directory the final exe is located
            //takes pic from folder to set as profile pic
            string fileName = "teacher.jpg";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Images\", fileName);
            Image image = Image.FromFile(filePath);
            picBoxTeacher.Image = (Image)image;
            picBoxTeacher.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTeacherName.Text = teacher.FirstName;

            lstBoxKlass.DataSource = teacher.Klasses;
            lstBoxKlass.DisplayMember = "KlassName";


        }

        private void frmTeacherHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void lstBoxKlass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                Klass selectedItem = lstBoxKlass.SelectedItem as Klass;
                lstBoxStudents.DataSource = MathWizDA.SelectAllStudentsInKlass(selectedItem.Id);
            
            
        }
    }
}
