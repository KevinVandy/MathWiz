using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathWiz
{
    public partial class frmTeacherHome : Form
    {
        Teacher teacher;
        Series masteryLevelSeries;

        public frmTeacherHome(string username)
        {
            InitializeComponent();
            teacher = MathWizDA.SelectTeacher(username);
        }

        private void frmTeacherHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathWizGroup3DataSet.tests' table. You can move, or remove it, as needed.
            
            backgroundWorkerLoadData.RunWorkerAsync();
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerLoadData.ReportProgress(1);
            teacher.Klasses = MathWizDA.SelectAllKlassesByTeacher(teacher.Id);
            backgroundWorkerLoadData.ReportProgress(25);
            this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet.students);
            backgroundWorkerLoadData.ReportProgress(50);
            this.graded_testsTableAdapter.Fill(this.mathWizGroup3DataSet.graded_tests);
            backgroundWorkerLoadData.ReportProgress(75);
            this.testsTableAdapter.Fill(this.mathWizGroup3DataSet.tests);
            backgroundWorkerLoadData.ReportProgress(100);
        }

        private void backgroundWorkerLoadData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbLoadData.Value = e.ProgressPercentage;
            lblProgress.Text = e.ProgressPercentage.ToString() + "% - ";
            switch (e.ProgressPercentage)
            {
                case 1:
                    lblProgress.Text += "Loading Your Classes";
                    break;
                case 25:
                    lblProgress.Text += "Loading Your Students";
                    break;
                case 50:
                    lblProgress.Text += "Loading Grades";
                    break;
                case 75:
                    lblProgress.Text += "Loading Tests";
                    break;
                case 100:
                    lblProgress.Text = "";
                    pgbLoadData.Value = 0;
                    break;
            }
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblTeacherName.Text = teacher.FirstName + " " + teacher.LastName;
            cmbKlasses.DataSource = teacher.Klasses;
            cmbKlasses.DisplayMember = "KlassName";
            cmbKlasses.SelectedIndex = 0;
            masteryLevelSeries = this.chtMasterLevelDistribution.Series.Add("masteryLevels");
            UpdateKlassInfo();
        }
        
        private void cmbKlasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKlasses.SelectedIndex != -1 && cmbKlasses.SelectedItem != null)
            {
                Klass selectedItem = cmbKlasses.SelectedItem as Klass;
                this.studentsTableAdapter.FillByKlass(this.mathWizGroup3DataSet.students, selectedItem.Id);
                this.testsTableAdapter.FillByKlassID(this.mathWizGroup3DataSet.tests, selectedItem.Id);
                
                UpdateKlassInfo();
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStudents.SelectedRows[0];
            string studentName = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();
            int studentId = Int32.Parse(row.Cells["Id"].Value.ToString());
            
            lblStudentGrades.Text = studentName + "'s Grades";
        }
        

        //MARK Menustrip Event Handlers
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new frmAboutBox();
            aboutForm.Show();
        }
        //END Menustrip Event Handlers

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.gradedTestsTableAdapter.FillBy(this.mathWizGroup3DataSet.graded_tests);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Form changePasswordForm = new frmChangePassword(username);
            changePasswordForm.ShowDialog();
        }

        private void btnGenerateTests_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            if (cmbKlasses.SelectedIndex == -1)
            {
                MessageBox.Show("A Class was not selected please make sure the correct calss is selected");
                cmbKlasses.SelectedIndex = 0;
            }
            else
            {
                frmCreateTest createTest = new frmCreateTest(teacher.Klasses[cmbKlasses.SelectedIndex].Id); //passes the selected classID
                createTest.Show();
            }
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            lsvStudentGrades.Items.Clear();
            if (dgvStudents.SelectedRows.Count > 0)
            {
                //enable change password button
                btnChangePassword.Enabled = true;

                //show the selected student's graded tests, if any
                for (int i = 0; i < mathWizGroup3DataSet.graded_tests.Rows.Count; i++)
                {
                    DataRow drow = mathWizGroup3DataSet.graded_tests.Rows[i];
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(drow["Id"].ToString());
                        lvi.SubItems.Add(drow["TestType"].ToString());
                        lvi.SubItems.Add(drow["DateTaken"].ToString());
                        lvi.SubItems.Add(drow["TimeTakenToComplete"].ToString());
                        lvi.SubItems.Add(drow["Score"].ToString());
                        lvi.SubItems.Add(drow["Feedback"].ToString());
                        if (Convert.ToInt32(drow["StudentID"]) == Convert.ToInt32(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells[0].Value))
                        {
                            lsvStudentGrades.Items.Add(lvi);
                        }
                    }
                }
            }
        }

        private void dgvTests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                btnEditTest.Enabled = true;
            }
            else
            {
                btnEditTest.Enabled = false;
            }
        }

        private void UpdateKlassInfo()
        {
            lblNumberStudents.Text = "Number of Students: " +  dgvStudents.RowCount.ToString();
            ShowMasteryLevelChartData();
        }

        private void ShowMasteryLevelChartData()
        {
            if(chtMasterLevelDistribution.Series.Count > 0)
            {
                chtMasterLevelDistribution.Series[0].Points.Clear();

                int[] masteryLevels = new int[dgvStudents.RowCount];
                int[] masteryLevelFrequency;
                
                for (int i = 0; i < dgvStudents.RowCount; i++)
                {
                    masteryLevels[i] = Convert.ToInt32(dgvStudents.Rows[i].Cells[4].Value);
                }
                
                if (masteryLevels.Count() > 0)
                {
                    lblAverageML.Text = "Average Class Mastery Level: " + masteryLevels.Average().ToString("#.0");
                    masteryLevelFrequency = new int[(masteryLevels).Max()]; //only make the size of the array the size of the max mastery level achieved in class
                }
                else
                {
                    masteryLevelFrequency = new int[12]; //make the array the size of the max number of mastery levels
                }

                for (int i = 0; i <= masteryLevelFrequency.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < dgvStudents.RowCount; j++)
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
}
