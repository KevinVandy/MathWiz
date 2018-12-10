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
    public partial class frmParentHome : Form
    {
        Parent parent;

        //MARK Form load stuff
        public frmParentHome(string username)
        {
            InitializeComponent();
            parent = MathWizDA.SelectParent(username); //this has to go here
        }

        private void frmParentHome_Load(object sender, EventArgs e)
        {
            backgroundWorkerLoadData.RunWorkerAsync();
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            parent.Children = MathWizDA.SelectStudentsViaParent(parent.Id);
            this.studentsTableAdapter.Fill(this.mathWizGroup3DataSet.students);
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbChildren.DataSource = parent.Children;
            cmbChildren.DisplayMember = "Username";
            cmbChildren.SelectedIndex = 0;
            lblParentName.Text = "Logged in as: " + parent.FirstName + " " + parent.LastName;
        }
        //END Form load stuff

        //MARK MenuStrip event handlers
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
            Form aboutBox = new frmAboutBox();
            aboutBox.ShowDialog();
        }
        //END MenuStrip event handlers

        private void graded_testsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.graded_testsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathWizGroup3DataSet);

        }

        private void cmbChildren_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbChildren.SelectedIndex != -1 && cmbChildren.Items.Count != 0)
            {
                //Grab the student from the listbox
                Student currentStudent = (Student)cmbChildren.SelectedItem;

                grpManageChildren.Text = currentStudent.FirstName + " " + currentStudent.LastName + "'s Info";

                //Output relevant graded test info to the data set on the form
                try
                {
                    this.studentsTableAdapter.FillByStudentSearch(this.mathWizGroup3DataSet.students, currentStudent.Username);
                    this.graded_testsTableAdapter.FillByGradedTests(this.mathWizGroup3DataSet.graded_tests, currentStudent.Id);

                    lsvStudentGrades.Items.Clear();
                    if (cmbChildren.Items.Count > 0)
                    {
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
                                if (Convert.ToInt32(currentStudent.Id) == Convert.ToInt32(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells[0].Value))
                                {
                                    lsvStudentGrades.Items.Add(lvi);
                                }
                            }
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
