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
    public partial class frmTakeTest : Form
    {
        Test thisTest;
        int testID;
        int currentQuestionNum;

        public frmTakeTest(int testId = 0) //default test ID of 0 if there is no ID passed
        {
            InitializeComponent();
            testID = testId;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            backgroundWorkerLoadTest.RunWorkerAsync();
        }

        private void backgroundWorkerLoadTest_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "placement":
                    thisTest = MathWizDA.SelectPlaceTest(testID);
                    break;
                case "practice":
                    //TODO call a method to generate a test -- OR I guess load one from the database
                    break;
                case "mastery":
                    thisTest = MathWizDA.SelectMastTest(testID);
                    break;
            }
        }

        private void backgroundWorkerLoadTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void ShowQuestion(Question q)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
