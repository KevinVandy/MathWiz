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
        //Teacher teacher;
        public frmTeacherHome(string username)
        {
            InitializeComponent();
            //teacher = MathWizDA.SelectTeacher(username);
        }

        private void frmTeacherHome_Load(object sender, EventArgs e)
        {
            string fileName = "teacher.jpg";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Images\", fileName);
            Image image = Image.FromFile(filePath);
            picBoxTeacher.Image = (Image)image;
            picBoxTeacher.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void frmTeacherHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
    }
}
