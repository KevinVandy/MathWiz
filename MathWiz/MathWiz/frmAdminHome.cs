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
    public partial class frmAdminHome : Form
    {
        Admin admin;

        List<Admin> allAdmins = new List<Admin>();
        List<Teacher> allTeachers = new List<Teacher>();
        List<Parent> allParents = new List<Parent>();
        List<Student> allStudents = new List<Student>();

        public frmAdminHome(string username)
        {
            InitializeComponent();
            admin = MathWizDA.SelectAdmin(username);
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet1.students);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet1.parents' table. You can move, or remove it, as needed.
            this.parentsTableAdapter.Fill(this.mathWizGroup3DataSet1.parents);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet1.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.mathWizGroup3DataSet1.teachers);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet.admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.mathWizGroup3DataSet.admins);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet.admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.mathWizGroup3DataSet.admins);
            allAdmins = MathWizDA.SelectAllAdmins();
            allTeachers = MathWizDA.SelectAllTeachers();
            allParents = MathWizDA.SelectAllParents();
            allStudents = MathWizDA.SelectAllStudents();

            rdoStudents.Checked = true;
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUserAccount();
            createUserForm.Tag = "Admin";
            createUserForm.ShowDialog();
        }

        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUserAccount();
            createUserForm.Tag = "Teacher";
            createUserForm.ShowDialog();
        }

        private void btnCreateParent_Click(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUserAccount();
            createUserForm.Tag = "Parent";
            createUserForm.ShowDialog();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUserAccount();
            createUserForm.Tag = "Student";
            createUserForm.ShowDialog();
        }

        private void btnDeleteSelectedUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //TODO Delete a user
        }

        private void rdoUserTypes_CheckChanged(object sender, EventArgs e)
        {
            lstUsers.Enabled = true;
            lstUsers.Items.Clear();

            //check which radio button is selected and display the correct users in the users listbox AND datagridview
            if (rdoAdmins.Checked)
            {
                foreach (Admin a in allAdmins)
                {
                    lstUsers.Items.Add(a.ToString());
                }
                dgvUsers.DataSource = adminsBindingSource;
            }
            else if (rdoTeachers.Checked)
            {
                foreach (Teacher t in allTeachers)
                {
                    lstUsers.Items.Add(t.ToString());
                }
                dgvUsers.DataSource = teachersBindingSource;
            }
            else if (rdoParents.Checked)
            {
                foreach (Parent p in allParents)
                {
                    lstUsers.Items.Add(p.ToString());
                }
                dgvUsers.DataSource = Parent;
            }
            else if (rdoStudents.Checked)
            {
                foreach (Student s in allStudents)
                {
                    lstUsers.Items.Add(s.ToString());
                }
                dgvUsers.DataSource = studentsBindingSource;
            }

            //only enable the delete user button if someone is selected
            if (lstUsers.SelectedItem != null)
            {
                btnDeleteSelectedUser.Enabled = true;
            }
            else
            {
                btnDeleteSelectedUser.Enabled = false;
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvUsers.ClearSelection();
            dgvUsers.Rows[lstUsers.SelectedIndex].Selected = true;

            if (lstUsers.SelectedItem != null)
            {
                btnDeleteSelectedUser.Enabled = true;
            }
            else
            {
                btnDeleteSelectedUser.Enabled = false;
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lstUsers.SelectedIndex = dgvUsers.CurrentCell.RowIndex;
        }
    }
}
