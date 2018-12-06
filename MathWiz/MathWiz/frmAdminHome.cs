using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathWiz
{
    public partial class frmAdminHome : Form
    {
        Admin admin;
        Series masteryLevelSeries;


        public frmAdminHome(string username)
        {
            InitializeComponent();
            admin = MathWizDA.SelectAdmin(username);
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            backgroundWorkerFormDataLoad.RunWorkerAsync();

            lblAdminName.Text = "Logged in as: " + admin.FirstName + " " + admin.LastName;

            masteryLevelSeries = this.chtMasterLevelDistribution.Series.Add("masteryLevels");

            chtMasterLevelDistribution.ChartAreas[0].AxisX.Title = "Mastery Levels";
            chtMasterLevelDistribution.ChartAreas[0].AxisX.Interval = 1;

            chtMasterLevelDistribution.ChartAreas[0].AxisY.Title = "Number of Students";
            chtMasterLevelDistribution.ChartAreas[0].AxisY.Interval = 1;
        }

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
                usernameToolStripLabel.Text = "Search for a Parent  ";
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
                contextMenuStrip.Enabled = true;
            }
            else
            {
                btnChangePassword.Enabled = false;
                btnDeleteSelectedUser.Enabled = false;
                contextMenuStrip.Enabled = true;
            }
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

                this.klassesTableAdapter.Fill(this.mathWizGroup3DataSet.klasses);
                backgroundWorkerFormDataLoad.ReportProgress(80);

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
            rdoStudents.Checked = true; //just a hack to get the table to refresh and show new info
            
            //manage classes section
            for(int i = 0; i < mathWizGroup3DataSet.teachers.Rows.Count; i++)
            {
                DataRow drow = mathWizGroup3DataSet.teachers.Rows[i];
                if(drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["Id"].ToString());
                    lvi.SubItems.Add(drow["FirstName"].ToString() + " " + drow["LastName"].ToString());
                    lvi.SubItems.Add(drow["Username"].ToString());
                    lsvTeachers.Items.Add(lvi);
                }
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

            dgvUsers.Update();
            dgvUsers.Refresh();

            lsvTeachers.Items.Clear();
            
            for (int i = 0; i < mathWizGroup3DataSet.teachers.Rows.Count; i++)
            {
                DataRow drow = mathWizGroup3DataSet.teachers.Rows[i];
                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["Id"].ToString());
                    lvi.SubItems.Add(drow["FirstName"].ToString() + " " + drow["LastName"].ToString());
                    lvi.SubItems.Add(drow["Username"].ToString());
                    lsvTeachers.Items.Add(lvi);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            try
            {
                usernameToolStripTextBox.Text = "";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = dgvUsers.Rows[dgvUsers.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Form changePasswordForm = new frmChangePassword(username);
            changePasswordForm.ShowDialog();
        }

        private void btnDeleteSelectedUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsers.Rows[dgvUsers.CurrentCell.RowIndex].Cells[0].Value);
            string username = dgvUsers.Rows[dgvUsers.CurrentCell.RowIndex].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes) //delete the user if they confirm yes
            {
                if (rdoAdmins.Checked) //check for the type of user (admin,teacher,parent,student)
                {
                    MathWizDB.DeleteUser("admin", id, username);
                }
                else if (rdoTeachers.Checked)
                {
                    MathWizDB.DeleteUser("teacher", id, username);
                }
                else if (rdoParents.Checked)
                {
                    MathWizDB.DeleteUser("parent", id, username);
                }
                else if (rdoStudents.Checked)
                {
                    MathWizDB.DeleteUser("student", id, username);
                }
                lblDeleted.Text = username + " was deleted";
                lblDeleted.Show();
                btnRefresh_Click(null,null);
            }
            else if (dialogResult == DialogResult.No)
            {
                lblDeleted.Text = "Delete cancelled";
                lblDeleted.Show();
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            Form createClassForm = new frmCreateClass();
            createClassForm.ShowDialog();
        }
        //END Button Event Handlers

        //BEGIN Context Menu Event Handlers
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChangePassword_Click(null, null);
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteSelectedUser_Click(null, null);
        }
        //END Context Menu Event Handlers
        
        
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

        private void lsvTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            lsvKlasses.Items.Clear();
            if (lsvTeachers.SelectedItems.Count > 0)
            {
                for (int i = 0; i < mathWizGroup3DataSet.klasses.Rows.Count; i++)
                {
                    DataRow drow = mathWizGroup3DataSet.klasses.Rows[i];
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(drow["Id"].ToString());
                        lvi.SubItems.Add(drow["KlassName"].ToString());
                        if (Convert.ToInt32(drow["TeacherID"]) == Convert.ToInt32(lsvTeachers.SelectedItems[0].SubItems[0].Text))
                        {
                            lsvKlasses.Items.Add(lvi);
                        }
                    }
                }
            }
        }

        private void lsvKlasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            if (lsvKlasses.SelectedItems.Count > 0)
            {
                for (int i = 0; i < mathWizGroup3DataSet.students.Rows.Count; i++)
                {
                    DataRow drow = mathWizGroup3DataSet.students.Rows[i];
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(drow["Id"].ToString());
                        lvi.SubItems.Add(drow["FirstName"].ToString() + " " + drow["LastName"].ToString());
                        lvi.SubItems.Add(drow["Username"].ToString());
                        lvi.SubItems.Add(drow["MasteryLevel"].ToString());
                        if (Convert.ToInt32(drow["KlassID"]) == Convert.ToInt32(lsvKlasses.SelectedItems[0].SubItems[0].Text))
                        {
                            lsvStudents.Items.Add(lvi);
                        }
                    }
                }
            }

            //populate mastery level chart
            ShowMasteryLevelChartData();

        }

        private void lsvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Show chart data
        private void ShowMasteryLevelChartData()
        {
            chtMasterLevelDistribution.Series[0].Points.Clear();

            int[] masteryLevels = new int[lsvStudents.Items.Count];
            int[] masteryLevelFrequency;


            for (int i = 0; i < lsvStudents.Items.Count; i++)
            {
                masteryLevels[i] = Convert.ToInt32(lsvStudents.Items[i].SubItems[3].Text);
            }

            if(masteryLevels.Count() > 0)
            {
                masteryLevelFrequency = new int[(masteryLevels).Max()]; //only make the size of the array the size of the max mastery level achieved in class
            }
            else
            {
                masteryLevelFrequency = new int[12]; //only make the size of the array the size of the max mastery level achieved in class
            }
            
            for (int i = 0; i <= masteryLevelFrequency.GetUpperBound(0); i++)
            {
                for (int j = 0; j < lsvStudents.Items.Count; j++)
                {
                    if (masteryLevels[j] == i + 1)
                    {
                        masteryLevelFrequency[i]++;
                    }
                }
                masteryLevelSeries.Points.Add(masteryLevelFrequency[i]);
            }
        }
    }
}
