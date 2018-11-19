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
    public partial class frmNewTest : Form
    {
        public frmNewTest()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
               
                if(cboMinimum.Visible == true)
                {
                    int min = cboMinimum.SelectedIndex + 1;
                    int max = cboMaximum.SelectedIndex + 1;
                }
                else
                {
                    decimal threshhold = Convert.ToDecimal(mskThreshold.Text);
                }
                List<Question> qL = new List<Question>();
                TimeSpan time = TimeSpan.Parse(mskTime.Text);
                bool isTrue = Convert.ToBoolean(cboRandom.SelectedIndex);
                
                
                
                int caseswitch = cboType.SelectedIndex;
                switch (caseswitch)
                {
                    case 0:
                        //PracticeTest practiceTest = new PracticeTest(qL, time, isTrue, min, max);
                        MessageBox.Show("Case 1");
                        break;
                    case 1:
                        MessageBox.Show("Case 2");
                        //PlacementTest PlacementTest = new PlacementTest(qL, time, isTrue, min, max);
                        break;
                    case 2:
                        MessageBox.Show("Case 3");
                        //MasteryTest masteryTest = new MasteryTest(qL, time, isTrue, max, threshhold);
                        break;


                }
                if (cboRandom.SelectedIndex == 0)
                {
                    //Question.
                }
            }
        }

        private bool ValidateForm()
        {
            if(cboMinimum.Enabled == true)
            {
                if(Validation.IsComboSelected(cboType) &&
               Validation.IsMaskPresent(mskTime) &&
               Validation.IsComboSelected(cboMinimum) &&
               Validation.IsComboSelected(cboMaximum) &&
               Validation.IsComboSelected(cboRandom) &&
               Validation.secondIndexNotLower(cboMinimum, cboMaximum) == true)
               {
                    MessageBox.Show("Validated practice / placement");
                    return true;
                }

                return false;
            }
            else
            {
                if(Validation.IsComboSelected(cboType) &&
               Validation.IsMaskPresent(mskTime) &&
               Validation.IsMaskPresent(mskThreshold) &&
               Validation.IsComboSelected(cboMaximum) &&
               Validation.IsComboSelected(cboRandom) &&
               Validation.secondIndexNotLower(cboMinimum, cboMaximum) == true)
                {
                    MessageBox.Show("Validated Mastery");
                    return true;
                }

                return false;
            }

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int caseswtich = cboType.SelectedIndex;
            switch(caseswtich)
            {
                case 0:
                    cboMinimum.Enabled = true;
                    lblMaxMaster.Text = "Maximum Level:";
                    mskThreshold.Enabled = false;
                    break;
                case 1:
                    cboMinimum.Enabled = true;
                    lblMaxMaster.Text = "Maximum Level:";
                    mskThreshold.Enabled = false;
                    break;
                case 2:
                    cboMinimum.Enabled = false;
                    lblMaxMaster.Text = "Mastery Level:";
                    mskThreshold.Enabled = true;
                    break;
            }
        }
    }
}
