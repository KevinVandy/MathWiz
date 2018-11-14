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
    public partial class frmCreateUserAccount : Form
    {
        public frmCreateUserAccount()
        {
            InitializeComponent();
        }

        private void frmCreateUserAccount_Load(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "Admin":

                    lblParent.Enabled = false;
                    cmbParent.Enabled = false;
                    lblClass.Enabled = false;
                    cmbClass.Enabled = false;
                    lblID.Enabled = false;
                    txtID.Enabled = false;

                    btnCreateUser.Text = "Create Admin";

                    break;

                case "Teacher":

                    lblParent.Enabled = false;
                    cmbParent.Enabled = false;
                    lblClass.Enabled = false;
                    cmbClass.Enabled = false;
                    lblID.Enabled = false;
                    txtID.Enabled = false;

                    btnCreateUser.Text = "Create Teacher";

                    break;

                case "Parent":

                    lblParent.Enabled = false;
                    cmbParent.Enabled = false;
                    lblClass.Enabled = false;
                    cmbClass.Enabled = false;
                    lblID.Enabled = false;
                    txtID.Enabled = false;

                    btnCreateUser.Text = "Create Parent";

                    break;

                case "Student":

                    btnCreateUser.Text = "Create Student";

                    break;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstName.Text + txtLastName.Text + txtID.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstName.Text + txtLastName.Text + txtID.Text;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstName.Text + txtLastName.Text + txtID.Text;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "Admin":

                    
                    string firstName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    Admin newAdmin = new Admin(firstName, lastName, username, password);

                    MathWizDB.InsertAdmin(newAdmin);

                    break;

                case "Teacher":

                    

                    break;

                case "Parent":

                    

                    break;

                case "Student":



                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
