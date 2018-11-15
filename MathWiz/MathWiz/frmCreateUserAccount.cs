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

        public frmCreateUserAccount()
        {
            InitializeComponent();
        }

        private void frmCreateUserAccount_Load(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
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

                    parentChoices = MathWizDA.SelectAllParents();
                    klassChoices = MathWizDA.SelectAllKlasses();

                    foreach(Parent p in parentChoices)
                    {
                        cmbParent.Items.Add(p.ToString());
                    }
                    foreach(Klass k in klassChoices)
                    {
                        cmbClass.Items.Add(k.ToString());
                    }

                    break;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstName.Text + txtLastName.Text + txtID.Text;
            lblAdded.Hide();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstName.Text + txtLastName.Text + txtID.Text;
            lblAdded.Hide();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstName.Text + txtLastName.Text + txtID.Text;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

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
                    int parentID = Convert.ToInt16(cmbParent.SelectedItem.ToString().Substring(0, 6));
                    int klassID = Convert.ToInt16(cmbClass.SelectedItem.ToString().Substring(0, 4));
                    MathWizDB.InsertStudent(newStudent, parentID, klassID);
                    
                    break;
            }
            lblAdded.Text = firstName + " " + lastName + " was successfully added";
            lblAdded.Show();

            txtFirstName.Clear();
            txtLastName.Clear();
            txtID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbParent.SelectedItem = null;
            cmbClass.SelectedItem = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
