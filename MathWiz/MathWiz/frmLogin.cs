using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public partial class frmLogin : Form
    {
        User user;
        Form homeForm;
        string errorFlag = "";
        int loginAttempts = 0;

        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        //button actions
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //hide the errors if they were previously shown so that they only show when triggered again
            lblUsernameError.Hide();
            lblPasswordError.Hide();
            
            if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                lblUsernameError.Show();
                lblPasswordError.Show();
            }
            if(txtUsername.Text == "")
            {
                lblUsernameError.Show();
            }
            else if(txtPassword.Text == "")
            {
                lblPasswordError.Show();
            }
            else
            {
                btnLogin.Enabled = false;
                backgroundWorkerLogin.RunWorkerAsync();
            }
        }

        private void backgroundWorkerLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (MathWizDA.FindAdmin(username))
            {
                user = new Admin();
                if (user.VerifyPassword(username, password))
                {
                    homeForm = new frmAdminHome(username);
                }
                else
                {
                    errorFlag = "password";
                }
            }
            else if (MathWizDA.FindTeacher(username))
            {
                user = new Teacher();
                if (user.VerifyPassword(username, password))
                {
                    homeForm = new frmTeacherHome(username);
                }
                else
                {
                    errorFlag = "password";
                }
            }
            else if (MathWizDA.FindParent(username))
            {
                user = new Parent();
                if (user.VerifyPassword(username, password))
                {
                    homeForm = new frmParentHome(username);
                }
                else
                {
                    errorFlag = "password";
                }
            }
            else if (MathWizDA.FindStudent(username))
            {
                user = new Student();
                if (user.VerifyPassword(username, password))
                {
                    homeForm = new frmStudentHome(username);
                }
                else
                {
                    errorFlag = "password";
                }
            }
            else //could not find username
            {
                errorFlag = "username";
            }
        }

        private void backgroundWorkerLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null && errorFlag == "")
            {
                txtPassword.Text = null;//get rid of password text for security so that the next user who uses the computer doesn't have it
                this.Hide();            //hide login form
                homeForm.ShowDialog();  //only show the home form (of the type that was passed)
                if (!this.IsDisposed)   //only reshow this login form again if the user is logging out or clicking the red X, not if they are exiting the application
                {
                    this.Show();        //after the home form closes, show the login form again
                }
            }
            else if (errorFlag == "username")
            {
                lblUsernameError.Show();
            }
            else if (errorFlag == "password")
            {
                lblPasswordError.Show();
            }
            else if(loginAttempts < 3)
            {
                loginAttempts++;
                backgroundWorkerLogin.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Could Not log in. This could be due to a slow internet connection. Try again.");
            }
            btnLogin.Enabled = true; //re-enable login button for the next user
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

        private void iCantLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ask your teacher to reset your password", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorkerLogin.CancelAsync();
            this.Close();
        }

        
    }
}