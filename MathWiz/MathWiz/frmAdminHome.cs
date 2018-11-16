using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread loadingThread = new Thread(LoadData);
            loadingThread.Start();
            this.UseWaitCursor = true;
            Thread.Sleep(3000);
            this.UseWaitCursor = false;
            dgvUsers.Update();
            dgvUsers.Refresh();

            foreach (Klass k in allKlasses)
            {
                lstClasses.Items.Add(k.ToString());
            }

            rdoStudents.Checked = true;
        }

        private void LoadData() //this is opened in another thread
        {
            try
            {
                this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet1.students);
                this.adminsTableAdapter.Fill(this.mathWizGroup3DataSet1.admins);
                this.teachersTableAdapter.Fill(this.mathWizGroup3DataSet1.teachers);
                this.parentsTableAdapter.Fill(this.mathWizGroup3DataSet1.parents);
                
                allKlasses = MathWizDA.SelectAllKlasses();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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


        private void btnViewUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

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
                btnViewUserInfo.Enabled = true;
                btnChangePassword.Enabled = true;
                btnDeleteSelectedUser.Enabled = true;
            }
            else
            {
                btnViewUserInfo.Enabled = false;
                btnChangePassword.Enabled = false;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            LoadData();
            dgvUsers.Update();
            dgvUsers.Refresh();
            this.UseWaitCursor = false;
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new frmAboutBox();
            aboutForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //event handlers to save data when someone edits a cell in the users table
        private void dgvUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveDataInCellSheet();
        }

        private void SaveDataInCellSheet()
        {
            adminsTableAdapter.Update(mathWizGroup3DataSet1.admins);
            teachersTableAdapter.Update(mathWizGroup3DataSet1.teachers);
            parentsTableAdapter.Update(mathWizGroup3DataSet1.parents);
            studentsTableAdapter.Update(mathWizGroup3DataSet1.students);
        }
    }
}
