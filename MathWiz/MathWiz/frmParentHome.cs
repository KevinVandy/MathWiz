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
        public frmParentHome(string username)
        {
            InitializeComponent();
            parent = MathWizDA.SelectParent(username);
        }

        private void frmParentHome_Load(object sender, EventArgs e)
        {
            //Parent's name to form
            grpManageChildren.Text = parent.FirstName + "'s children";

            // Grab students that are assigned to the parent
            // And output them to the listbox on the form
            List<Student> myChildren = MathWizDA.SelectStudentsViaParent(parent.Id);
            foreach (Student child in myChildren) {
                lstChildren.Items.Add(child);
            }
        }

        private void frmParentHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new frmAboutBox();
            aboutBox.ShowDialog();
        }

        private void graded_testsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.graded_testsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathWizGroup3DataSet);

        }

        private void fillByGradedTestsToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void lstChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstChildren.SelectedIndex != -1 && lstChildren.Items.Count != 0)
            {
                //Grab the student from the listbox
                Student currentStudent = (Student)lstChildren.SelectedItem;

                //Output Mastery Level
                txtStudentMastery.Text = currentStudent.MasteryLevel.ToString();

                //Update label
                lblStudentMastery.Text = currentStudent.FirstName + "'s Mastery Level";

                //Output relevant graded test info to the data set on the form
                try
                {
                    this.graded_testsTableAdapter.FillByGradedTests(this.mathWizGroup3DataSet.graded_tests, currentStudent.Id);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
