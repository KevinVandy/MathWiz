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
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = MathWizConn.GetMathWizConnection();
        }
        
        //button actions
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //hide the errors if they were previously shown so that they only show when triggered again
            lblUsernameError.Hide();
            lblPasswordError.Hide();

            string username = txtUsername.Text;
            string password = txtPassword.Text; //testing password is "helloThere"

            //TODO find out what type of user is logging in so it can create the right object AND the right form
            User user;
            Form homeForm;
            if (false) //if(MathWizDA.FindAdminUsername(username))
            {
                user = new Admin();
                if (user.VerifyPassword(username, password))
                {
                    //user = MathWizDA.SelectAdmin(username);
                    homeForm = new frmAdminHome((Admin)user); //instantiate home form, pass user object, maybe we should just pass the username instead
                    Login(homeForm);
                }
                else
                {
                    lblPasswordError.Show();
                }
            }
            else if (false) //else if(MathWizDA.FindTeacherUsername(username))
            {
                user = new Teacher();
                if (user.VerifyPassword(username, password))
                {
                    //user = MathWizDA.SelectTeacher(username);
                    homeForm = new frmTeacherHome((Teacher)user); //instantiate home form
                    Login(homeForm);
                }
                else
                {
                    lblPasswordError.Show();
                }
            }
            else if (false) //else if(MathWizDA.FindParentUsername(username))
            {
                user = new Parent();
                if (user.VerifyPassword(username, password))
                {
                    //user = MathWizDA.SelectParent(username);
                    homeForm = new frmParentHome((Parent)user); //instantiate home form
                    Login(homeForm);
                }
                else
                {
                    lblPasswordError.Show();
                }
            }
            else if (true) //else if(MathWizDA.FindStudentUsername(username))
            {
                user = new Student();
                if (user.VerifyPassword(username, password))
                {
                    //user = MathWizDA.SelectStudent(username);
                    homeForm = new frmStudentHome((Student)user); //instantiate home form
                    Login(homeForm);
                }
                else
                {
                    lblPasswordError.Show();
                }
            }
            else //could not find username
            {
                lblUsernameError.Show();
            }
        }

        private void Login(Form homeForm)
        {
            txtPassword.Text = null;//get rid of password text for security so that the next user who uses the computer doesn't have it
            this.Hide();            //hide login form
            homeForm.ShowDialog();  //only show the home form (of the type that was passed)
            this.Show();            //after the home form closes, show the login form again
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
            //TODO Reset Password - maybe iteration 3
            MessageBox.Show("Well that sucks\n\ntesting password: helloThere", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}