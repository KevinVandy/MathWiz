using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    /*Tyler's Note, I wrote a few generic validation methods here. If you think up anything else that needs validated
     * then just let me know, and I'll write another method. The validation I wrote usually asks you to pass the entire
     * control for validation. It makes it easier to manipulate. In the case of checkbox and radio button validation 
     * pass the enitre groupbox containing those controls*/
     //testing ability to commit to repo BJP
    public class Validation
    {

        public static bool theTruth;

    
        public static bool IsPresent(TextBox txtBox)
        {
            if (txtBox.Text == "")
            {
                MessageBox.Show(txtBox.Tag.ToString() + " must be present.", "Input Error");
                txtBox.Focus();
                txtBox.SelectAll();
                return false;
            }

            return true;
        }

        internal static bool secondIndexNotLower(ComboBox cboMinimum, ComboBox cboMaximum)
        {
            theTruth = true;
            if (cboMaximum.SelectedIndex < cboMinimum.SelectedIndex)
            {
                MessageBox.Show("The maximum level cannot be lower than the minimum level");
                return false;
            }
                return theTruth;
        }

        public static bool IsMaskPresent(MaskedTextBox mask)
        {
            theTruth = true;
            if(!mask.MaskFull)
            {
                MessageBox.Show(mask.Tag.ToString() + " must be completly filled out", "Input Error");
                mask.Focus();
                return false;

            }
            return theTruth;
        }

        public static bool IsWithinRangeInclusive(TextBox txtBox, int high, int low)
        {
            decimal Number = Convert.ToInt32(txtBox.Text);

            if (Number > high || Number < low)
            {
                MessageBox.Show(txtBox.Tag.ToString() + " must be between the valid ranges of " + low.ToString() + " and " + high.ToString() + " inclusive.", "Input Error");
                txtBox.Focus();
                txtBox.SelectAll();
                return false;
            }
            return true;
        }
        public static bool IsBoxChecked(GroupBox grpBox)
        {
            theTruth = false;
            List<CheckBox> checkList = new List<CheckBox>();
            checkList = grpBox.Controls.OfType<CheckBox>().ToList<CheckBox>();
            foreach(CheckBox C in checkList)
            {
                if(C.Checked == true)
                {
                    theTruth = true;
                }
            }
            if(theTruth == false)
            {
                grpBox.Focus();
                MessageBox.Show("Please check at least one box", "Input Error");
            }
            return theTruth;
        }

        public static bool IsRadioSelected(GroupBox grpBox)
        {
            theTruth = false;
            List<RadioButton> radioList = new List<RadioButton>();
            radioList = grpBox.Controls.OfType<RadioButton>().ToList<RadioButton>();
            foreach (RadioButton B in radioList)
            {
                if (B.Checked == true)
                {
                    theTruth = true;
                }
            }

            if (theTruth == false)
            {
                grpBox.Focus();
                MessageBox.Show("Please select a radio button", "Input Error");
            }
            return theTruth;
        }


        public static bool IsInteger(TextBox txtBox)
        {
            int n;
            bool isNumeric = int.TryParse(txtBox.Text, out n);
            if(isNumeric == false)
            {
                MessageBox.Show(txtBox.Tag.ToString() + " must be an integer.", "Input Error");
                txtBox.Focus();
                txtBox.SelectAll();
            }
            return isNumeric;
            
        }

        public static bool  IsComboSelected(ComboBox cboBox)
        {
            if(cboBox.SelectedIndex == -1)
            {
                MessageBox.Show(cboBox.Tag.ToString() + " must have an item selected.", "Input Error");
                cboBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsStringMaxLengthInclusive(TextBox txtBox, int maxLength)
        {
            int stringLength = txtBox.Text.Length;
            if(stringLength > maxLength)
            {
                MessageBox.Show(txtBox.Tag.ToString() + " has a character limit of " + maxLength.ToString(), "Input Error");
                txtBox.Focus();
                txtBox.SelectAll();
                return false;
            }

            return true; 
        }
    }
}
