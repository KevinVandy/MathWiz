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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //form load
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //menu item actions
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new frmAboutBox();
            aboutBox.ShowDialog();
        }

        //button actions
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //just for my testing purposes, rewrite when making logging in functional
            Form homeForm = new Form();
            string whichForm = "student";
            switch (whichForm)
            {
                case "admin":
                    homeForm = new frmAdminHome();
                    break;
                case "teacher":
                    homeForm = new frmTeacherHome();
                    break;
                case "student":
                    homeForm = new frmStudentHome();
                    break;
                case "parent":
                    homeForm = new frmParentHome();
                    break;
            }

            //keep this stuff
            this.Hide();            //hide login form
            homeForm.ShowDialog();  //only show the home form
            this.Show();            //after the home form closes, show the login form again
            txtPassword.Text = null;//get rid of password text for security
        }
    }
}
