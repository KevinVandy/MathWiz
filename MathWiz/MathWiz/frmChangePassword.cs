using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public partial class frmChangePassword : Form
    {
        User user;
        string userType;
        string username_G;

        public frmChangePassword(string username)
        {
            InitializeComponent();
            username_G = username;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text == txtConfirmPassword.Text)
            {
                btnChangePassword.Enabled = false;
                backgroundWorkerUpdatePassword.RunWorkerAsync();
            }
            else
            {
                lblError.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorkerUpdatePassword_DoWork(object sender, DoWorkEventArgs e)
        {
            string userType = MathWizDA.FindUserType(username_G);
            switch (userType)
            {
                case "admin": user = new Admin(); break;
                case "teacher": user = new Teacher(); break;
                case "parent": user = new Parent(); break;
                case "student": user = new Student(); break;
            }
            string passwordHash = user.HashPassword(txtNewPassword.Text);
            MathWizDB.UpdatePassword(userType, username_G, passwordHash);
        }

        private void backgroundWorkerUpdatePassword_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblChanged.Show();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar)
            {
                btnShowHide.BackgroundImage = Properties.Resources.hide_password;
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnShowHide.BackgroundImage = Properties.Resources.show_password;
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
