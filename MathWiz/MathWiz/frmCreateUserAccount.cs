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
        List<Parent> parentChoices;
        List<Klass> klassChoices;
        string firstName;
        string lastName;
        string username;
        string password;
        int parentID;
        int klassID;

        public frmCreateUserAccount()
        {
            InitializeComponent();
        }

        private void frmCreateUserAccount_Load(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "Admin":

                    lblParentRequired.Hide();
                    lblClassRequired.Hide();
                    lblParent.Enabled = false;
                    cmbParent.Enabled = false;
                    lblClass.Enabled = false;
                    cmbClass.Enabled = false;
                    lblID.Enabled = false;
                    txtID.Enabled = false;

                    btnCreateUser.Text = "Create Admin";

                    break;

                case "Teacher":

                    lblParentRequired.Hide();
                    lblClassRequired.Hide();
                    lblParent.Enabled = false;
                    cmbParent.Enabled = false;
                    lblClass.Enabled = false;
                    cmbClass.Enabled = false;
                    lblID.Enabled = false;
                    txtID.Enabled = false;

                    btnCreateUser.Text = "Create Teacher";

                    btnClassQuestion.Show();

                    break;

                case "Parent":

                    lblParentRequired.Hide();
                    lblClassRequired.Hide();
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

                    backgroundWorkerLoadData.RunWorkerAsync(); //load parent and klass data for dropdown menu, but in the background

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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsernameError.Hide();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            btnCreateUser.Enabled = false;
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("First Name is Required");
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Last Name is Required");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username is Required");
            }
            else if (txtPassword.Text == "")
            {
                lblPasswordError.Show();
            }
            else if (cmbParent.SelectedIndex == -1 && this.Tag.ToString() == "Student")
            {
                MessageBox.Show("A student must have a parent. If a the parent is not listed here, make their account first.");
            }
            else if (cmbClass.SelectedIndex == -1 && this.Tag.ToString() == "Student")
            {
                MessageBox.Show("A student must be added to class.");
            }
            else if (MathWizDA.FindUsername(username))
            {
                lblUsernameError.Text = "That username has already been taken";
                lblUsernameError.Show();
            }
            else //info is valid
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                username = txtUsername.Text;
                password = txtPassword.Text;
                if (this.Tag.ToString() == "Student")
                {
                    parentID = parentChoices[cmbParent.SelectedIndex].Id;
                    klassID = klassChoices[cmbClass.SelectedIndex].Id;
                }
                
                if (!backgroundWorkerInsertData.IsBusy)
                {
                    backgroundWorkerInsertData.RunWorkerAsync();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClassQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can add the teacher to a class in the 'Manage Classes' section");
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            parentChoices = MathWizDA.SelectAllParents();
            klassChoices = MathWizDA.SelectAllKlasses();
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Parent p in parentChoices)
            {
                cmbParent.Items.Add(p.ToString());
            }
            foreach (Klass k in klassChoices)
            {
                cmbClass.Items.Add(k.ToString());
            }
        }

        private void backgroundWorkerInsertData_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "Admin":

                    Admin newAdmin = new Admin(username, firstName, lastName, password);
                    MathWizDB.InsertAdmin(newAdmin);

                    break;

                case "Teacher":

                    Teacher newTeacher = new Teacher(username, firstName, lastName, password);
                    MathWizDB.InsertTeacher(newTeacher);

                    break;

                case "Parent":

                    Parent newParent = new Parent(username, firstName, lastName, password);
                    MathWizDB.InsertParent(newParent);

                    break;

                case "Student":

                    Student newStudent = new Student(username, firstName, lastName, password);
                    MathWizDB.InsertStudent(newStudent, parentID, klassID);

                    break;
            }
        }

        private void backgroundWorkerInsertData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblAdded.Text = firstName + " " + lastName + " was successfully added";
            lblAdded.Show();
            lblPasswordError.Hide();

            txtFirstName.Clear();
            txtLastName.Clear();
            txtID.Clear();
            txtUsername.Clear();
            cmbParent.SelectedItem = null;
            cmbClass.SelectedItem = null;
            txtPassword.Clear();
            btnCreateUser.Enabled = true;
        }
    }
}
