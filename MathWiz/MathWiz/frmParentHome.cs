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
            lblParentName.Text = "Logged in as: " + parent.FirstName + " " + parent.LastName;
            backgroundWorkerLoadData.RunWorkerAsync();
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            parent.Children = MathWizDA.SelectStudentsViaParent(parent.Id);
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Student c in parent.Children)
            {
                lstChildren.Items.Add(c);
            }
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
