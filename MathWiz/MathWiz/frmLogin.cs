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
            string whichForm = "parent";
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

            homeForm.Show();
            this.Hide();
        }

        //makes sure that the entire application shuts down when the login box is closed
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
