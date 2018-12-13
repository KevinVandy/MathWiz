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
        Klass currentKlass;
        Series masteryLevelSeries;

        public frmTeacherHome(string username)
        {
            InitializeComponent();
            teacher = MathWizDA.SelectTeacher(username);
        }

        private void frmTeacherHome_Load(object sender, EventArgs e)
        {
            backgroundWorkerLoadData.RunWorkerAsync();
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorkerLoadData.ReportProgress(1);
                teacher.Klasses = MathWizDA.SelectAllKlassesByTeacher(teacher.Id);
                backgroundWorkerLoadData.ReportProgress(25);
                this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet.students);
                backgroundWorkerLoadData.ReportProgress(50);
                this.graded_testsTableAdapter.Fill(this.mathWizGroup3DataSet.graded_tests);
                this.graded_questionsTableAdapter.Fill(this.mathWizGroup3DataSet.graded_questions);
                backgroundWorkerLoadData.ReportProgress(75);
                //this.testsTableAdapter.FillByNotPractice(this.mathWizGroup3DataSet.tests); //no practice tests
                backgroundWorkerLoadData.ReportProgress(100);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Internet Connection Error. This form will close. Try logging in again", "Error");
                this.Close();
            }
            
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
            lblTeacherName.Text = "Logged in as: " + teacher.FirstName + " " + teacher.LastName;
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
                currentKlass = cmbKlasses.SelectedItem as Klass;
                this.studentsTableAdapter.FillByKlass(this.mathWizGroup3DataSet.students, currentKlass.Id);
                this.testsTableAdapter.FillByKlassID(this.mathWizGroup3DataSet.tests, currentKlass.Id);

                // Check if the class has any placement tests created
                bool hasPlacementTests = true;
                hasPlacementTests = MathWizDA.FindPlacementTest(currentKlass.Id);
                if (hasPlacementTests == true)
                {
                    btnCreateTest.Enabled = false;
                    btnCreateTest.Text = "Placement Test is already generated.";
                    btnCreateTest.Height = 60;
                }
                else if (hasPlacementTests == false)
                {
                    btnCreateTest.Enabled = true;
                    btnCreateTest.Text = "Create Placement Test";
                    btnCreateTest.Height = 39;
                }


                // Check if the class has any mastery tests created
                bool hasMasteryTestsCreated = true;
                hasMasteryTestsCreated = MathWizDA.FindMasteryTest(currentKlass.Id);
                if(hasMasteryTestsCreated == true)
                {
                    btnGenerateMasteryTests.Enabled = false;
                    btnGenerateMasteryTests.Text = "Mastery Tests are already generated.";
                    btnGenerateMasteryTests.Height = 60;
                } else if (hasMasteryTestsCreated == false)
                {
                    btnGenerateMasteryTests.Enabled = true;
                    btnGenerateMasteryTests.Text = "Generate All Mastery Tests";
                    btnGenerateMasteryTests.Height = 39;
                }

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
        
        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            if (cmbKlasses.SelectedIndex == -1)
            {
                MessageBox.Show("A Class was not selected please make sure the correct class is selected");
            }
            else
            {
                frmCreatePlacementTest createTest = new frmCreatePlacementTest(teacher.Klasses[cmbKlasses.SelectedIndex].Id); //passes the selected classID
                createTest.Show();
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            lsvStudentGrades.Items.Clear();
            if (dgvStudents.SelectedRows.Count > 0)
            {
                //enable change password button
                btnChangePassword.Enabled = true;
                btnChangeML.Enabled = true;
                btnDeleteStudent.Enabled = true;

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
            else
            {
                btnChangePassword.Enabled = false;
                btnChangeML.Enabled = false;
                btnDeleteStudent.Enabled = false;
            }
        }

        private void lsvStudentGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudentGradedQuestions.Items.Clear();
            if (lsvStudentGrades.SelectedItems.Count > 0)
            {
                int j = 0;
                //show the selected student's graded tests, if any
                for (int i = 0; i < mathWizGroup3DataSet.graded_questions.Rows.Count; i++)
                {
                    DataRow drow = mathWizGroup3DataSet.graded_questions.Rows[i];
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(drow["Id"].ToString());
                        lvi.SubItems.Add(drow["QuestionID"].ToString());
                        lvi.SubItems.Add(drow["StudentAnswer"].ToString());
                        lvi.SubItems.Add(drow["TimeTakenToAnswer"].ToString());
                        
                        if (Convert.ToInt32(drow["GradedTestID"]) == Convert.ToInt32(lsvStudentGrades.SelectedItems[0].SubItems[0].Text))
                        {
                            lsvStudentGradedQuestions.Items.Add(lvi);

                            if (drow["Correct"].ToString() == "true") //show green for correct
                            {
                                lsvStudentGradedQuestions.Items[j++].SubItems[2].ForeColor = Color.Green;
                            }
                            else //show red for wrong
                            {
                                lsvStudentGradedQuestions.Items[j++].SubItems[2].ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        private void dgvTests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows.Count > 0)
            {
                btnDeleteTest.Enabled = true;
            }
            else
            {
                btnDeleteTest.Enabled = false;
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

        private void btnGenerateMasteryTests_Click(object sender, EventArgs e)
        {
            frmGenerateMasteryTests frmGenerateMasteryTests = new frmGenerateMasteryTests(currentKlass.Id);
            DialogResult theyCreatedTests = frmGenerateMasteryTests.ShowDialog();

            if(theyCreatedTests == DialogResult.OK)
            {
                btnGenerateMasteryTests.Enabled = false;
                btnGenerateMasteryTests.Text = "Mastery Tests are already generated.";
                btnGenerateMasteryTests.Height = 60;

                // Don't know how to refresh a data grid but we would want to refresh the dgvTests here
            }
        }

        //MARK saving data grid view edited data to database methods
        private void dgvStudents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            studentsTableAdapter.Update(mathWizGroup3DataSet.students);
        }

        private void dgvStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            studentsTableAdapter.Update(mathWizGroup3DataSet.students);
        }

        //Change ML Button
        private void button1_Click(object sender, EventArgs e)
        {
            string username = dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells[1].Value.ToString();
            int oldML = Convert.ToInt32(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells[4].Value);
            Form changeMLForm = new frmChangeML(oldML, username);
            changeMLForm.ShowDialog();
        }

        //Delete Student Button
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells[0].Value);
            string username = dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) //delete the user if they confirm yes
            {
                MathWizDB.DeleteUser("student", id, username);
            }
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            int testID = Convert.ToInt32(dgvTests.Rows[dgvTests.CurrentCell.RowIndex].Cells[0].Value);
            int gradedTestID;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this test?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) //delete the test if they confirm yes
            {
                // Grab the graded_test id with the test id (I'm assuming/hoping that testid is unique with this select)
                gradedTestID = MathWizDA.SelectGradedTestIDViaTestID(testID);

                //Delete the Graded Questions with the Graded Test ID
                MathWizDB.DeleteGradedQuestions(gradedTestID);

                //Delete the actual Graded Test with the Standard Test ID
                MathWizDB.DeleteGradedTestWithTestID(testID);

                //Delete Normal Questions with the Standard Test ID
                MathWizDB.DeleteNormalQuestions(testID);

                //Finally, delete the normal standard test
                MathWizDB.DeleteNormalTest(testID);
            }
        }
    }
}
