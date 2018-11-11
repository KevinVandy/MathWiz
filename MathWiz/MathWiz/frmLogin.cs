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
            string username = txtUsername.Text;
            string password = txtPassword.Text; //testing password is "helloThere"

            //TODO find out what type of user is logging in so it can create the right object AND the right form
            User user;
            Form homeForm;
            if (true)
            {
                user = new Admin();
                homeForm = new frmAdminHome(); //instantiate home form
            }
            else if (true)
            {
                user = new Teacher();
                homeForm = new frmTeacherHome(); //instantiate home form
            }
            else if (true)
            {
                user = new Parent();
                homeForm = new frmParentHome(); //instantiate home form
            }
            else if (true)
            {
                user = new Student();
                homeForm = new frmStudentHome(); //instantiate home form
            }

            if (user.VerifyPassword(username, password))
            {
                this.Hide();            //hide login form
                homeForm.ShowDialog();  //only show the home form
                this.Show();            //after the home form closes, show the login form again
                txtPassword.Text = null;//get rid of password text for security
            }
            else //login fail
            {
                MessageBox.Show("Your Password was incorrect", ""); //replace this with red label
            }
        }
    }
}
