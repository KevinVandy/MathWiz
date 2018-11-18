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
        List<Klass> allKlasses = new List<Klass>();
        
        public frmAdminHome(string username)
        {
            InitializeComponent();
            admin = MathWizDA.SelectAdmin(username);
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            backgroundWorkerFormDataLoad.RunWorkerAsync(); //load data, but as a background job so the form does not freeze
        }



        //Begin Background Worker event handlers for loading data
        private void backgroundWorkerFormDataLoad_DoWork(object sender, DoWorkEventArgs e)//load data in the background so form remains responsive
        {
            try
            {
                backgroundWorkerFormDataLoad.ReportProgress(1);
                this.adminsTableAdapter.Fill(this.mathWizGroup3DataSet.admins);

                backgroundWorkerFormDataLoad.ReportProgress(20);
                this.teachersTableAdapter.Fill(this.mathWizGroup3DataSet.teachers);

                backgroundWorkerFormDataLoad.ReportProgress(40);
                this.parentsTableAdapter.Fill(this.mathWizGroup3DataSet.parents);

                backgroundWorkerFormDataLoad.ReportProgress(60);
                this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet.students);

                backgroundWorkerFormDataLoad.ReportProgress(80);
                allKlasses = MathWizDA.SelectAllKlasses();

                backgroundWorkerFormDataLoad.ReportProgress(100); //done
            }
            catch(Exception)
            {
                MessageBox.Show("Error Loading Data. Try Refreshing");
            }
        }

        private void backgroundWorkerFormDataLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)//update progress bar
        {
            pgbLoadData.Value = e.ProgressPercentage;
            switch (e.ProgressPercentage)
            {
                case 1:
                    lblProgress.Text = "Loading Admins";
                    break;

                case 20:
                    lblProgress.Text = "Loading Teachers";
                    break;

                case 40:
                    lblProgress.Text = "Loading Parents";
                    break;

                case 60:
                    lblProgress.Text = "Loading Students";
                    break;

                case 80:
                    lblProgress.Text = "Loading Classes";
                    break;

                case 100:
                    lblProgress.Text = "";
                    break;
            }
        }

        private void backgroundWorkerFormDataLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) //refresh the form with the newly loaded data
        {
            dgvUsers.Update();
            dgvUsers.Refresh();
            rdoAdmins.Checked = true;
            rdoStudents.Checked = true; //just a hack to get the table to refresh

            lstClasses.Items.Clear();
            foreach (Klass k in allKlasses)
            {
                lstClasses.Items.Add(k.ToString());
            }
        }
        //End Background Worker event handlers for loading data

        //Begin Button Event Handlers
        //unfortunatley, using the same background worker as when page loads for refreshing causes exception, so this instead
        private void btnRefresh_Click(object sender, EventArgs e) 
        {
            if (rdoAdmins.Checked)
            {
                this.adminsTableAdapter.Fill(this.mathWizGroup3DataSet.admins);
            }
            else if (rdoTeachers.Checked)
            {
                this.teachersTableAdapter.Fill(this.mathWizGroup3DataSet.teachers);
            }
            else if (rdoParents.Checked)
            {
                this.parentsTableAdapter.Fill(this.mathWizGroup3DataSet.parents);
            }
            else if (rdoStudents.Checked)
            {
                this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet.students);
            }

            allKlasses = MathWizDA.SelectAllKlasses();

            dgvUsers.Update();
            dgvUsers.Refresh();

            //rdoUserTypes_CheckChanged(null, null);
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = dgvUsers.Rows[dgvUsers.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Form changePasswordForm = new frmChangePassword(username);
            changePasswordForm.ShowDialog();
        }

        private void btnDeleteSelectedUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //TODO Delete a user
        }

        
        //END Button Event Handlers

        private void rdoUserTypes_CheckChanged(object sender, EventArgs e)
        {

            //check which radio button is selected and display the correct users in the  datagridview
            if (rdoAdmins.Checked)
            {
                dgvUsers.DataSource = adminsBindingSource;
                usernameToolStripLabel.Text = "Search for an Admin";
            }
            else if (rdoTeachers.Checked)
            {
                dgvUsers.DataSource = teachersBindingSource;
                usernameToolStripLabel.Text = "Search for a Teacher";
            }
            else if (rdoParents.Checked)
            {
                dgvUsers.DataSource = parentsBindingSource;
                usernameToolStripLabel.Text = "Search for a Parent";
            }
            else if (rdoStudents.Checked)
            {
                dgvUsers.DataSource = studentsBindingSource;
                usernameToolStripLabel.Text = "Search for a Student";
            }

            //only enable the delete user button if someone is selected
            if (dgvUsers.SelectedRows != null)
            {
                btnChangePassword.Enabled = true;
                btnDeleteSelectedUser.Enabled = true;
            }
            else
            {
                btnChangePassword.Enabled = false;
                btnDeleteSelectedUser.Enabled = false;
            }
        }

        private void lstClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstClasses.SelectedItem != null)
            {
                lstStudentsInKlass.Enabled = true;
                lstStudentsInKlass.Items.Clear();
                foreach(Student s in allKlasses[lstClasses.SelectedIndex].Students)
                {
                    lstStudentsInKlass.Items.Add(s.ToString());
                }
            }
            else
            {
                lstStudentsInKlass.Enabled = false;
            }
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
        
        //button to search for a user at the top of the form
        private void fillByUsernameSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoAdmins.Checked)
                {
                    this.adminsTableAdapter.FillByAdminSearch(this.mathWizGroup3DataSet.admins, "%" + usernameToolStripTextBox.Text.Trim() + "%");
                }
                else if (rdoTeachers.Checked)
                {
                    this.teachersTableAdapter.FillByTeacherSearch(this.mathWizGroup3DataSet.teachers, "%" + usernameToolStripTextBox.Text.Trim() + "%");
                }
                else if (rdoParents.Checked)
                {
                    this.parentsTableAdapter.FillByParentSearch(this.mathWizGroup3DataSet.parents, "%" + usernameToolStripTextBox.Text.Trim() + "%");
                }
                else if (rdoStudents.Checked)
                {
                    this.studentsTableAdapter.FillByStudentSearch(this.mathWizGroup3DataSet.students, "%" + usernameToolStripTextBox.Text.Trim() + "%");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //event handlers to save data when someone edits a cell in the users table
        private void dgvUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SaveDataInCellSheet();
        }

        private void SaveDataInCellSheet()
        {
            if (rdoAdmins.Checked)
            {
                adminsTableAdapter.Update(mathWizGroup3DataSet.admins);
            }
            else if (rdoTeachers.Checked)
            {
                teachersTableAdapter.Update(mathWizGroup3DataSet.teachers);
            }
            else if(rdoParents.Checked)
            {
                parentsTableAdapter.Update(mathWizGroup3DataSet.parents);
            }
            else if (rdoStudents.Checked)
            {
                studentsTableAdapter.Update(mathWizGroup3DataSet.students);
            }
        }
    }
}
