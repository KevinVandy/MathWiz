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

        List<Klass> allKlasses = new List<Klass>();

        public frmAdminHome(string username)
        {
            InitializeComponent();
            admin = MathWizDA.SelectAdmin(username);
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet1.admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.mathWizGroup3DataSet1.admins);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet1.students);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet1.parents' table. You can move, or remove it, as needed.
            this.parentsTableAdapter.Fill(this.mathWizGroup3DataSet1.parents);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet1.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.mathWizGroup3DataSet1.teachers);
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet.admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.mathWizGroup3DataSet1.admins);

            allAdmins = MathWizDA.SelectAllAdmins();
            allTeachers = MathWizDA.SelectAllTeachers();
            allParents = MathWizDA.SelectAllParents();
            allStudents = MathWizDA.SelectAllStudents();
            allKlasses = MathWizDA.SelectAllKlasses();

            foreach(Klass k in allKlasses)
            {
                lstClasses.Items.Add(k.ToString());
            }

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

            //check which radio button is selected and display the correct users in the  datagridview
            if (rdoAdmins.Checked)
            {
                dgvUsers.DataSource = adminsBindingSource;
            }
            else if (rdoTeachers.Checked)
            {
                dgvUsers.DataSource = teachersBindingSource;
            }
            else if (rdoParents.Checked)
            {
                dgvUsers.DataSource = parentsBindingSource;
            }
            else if (rdoStudents.Checked)
            {
                dgvUsers.DataSource = studentsBindingSource;
            }

            //only enable the delete user button if someone is selected
            if (dgvUsers.SelectedRows != null)
            {
                btnDeleteSelectedUser.Enabled = true;
            }
            else
            {
                btnDeleteSelectedUser.Enabled = false;
            }
        }

        private void lstClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstClasses.SelectedItem != null)
            {
                lstStudentsInKlass.Items.Clear();
                foreach(Student s in allKlasses[lstClasses.SelectedIndex].Students)
                {
                    lstStudentsInKlass.Items.Add(s.ToString());
                }
            }
        }

        private void fillByStudentsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillByStudents(this.mathWizGroup3DataSet1.students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
