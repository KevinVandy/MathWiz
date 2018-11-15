using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public class Validation
    {
        bool theTruth;
        public bool IsPresent(TextBox txtBox)
        {
            if (txtBox.Text == "")
            {
                MessageBox.Show(txtBox.Tag.ToString() + " must be present.", "Input Error");
                return false;
            }

            return true;
        }

        public bool IsWithinRangeInclusive(TextBox txtBox, int high, int low)
        {
            decimal Number = Convert.ToInt32(txtBox.Text);

            if (Number > high || Number < low)
            {
                MessageBox.Show(txtBox.Tag.ToString() + " must be between the valid ranges of " + low.ToString() + " and " + high.ToString() + " inclusive.", "Input Error");
                return false;
            }
            return true;
        }
        public bool IsBoxChecked(GroupBox grpBox)
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
                MessageBox.Show("Please check at least one box", "Input Error");
            }
            return theTruth;
        }

        public bool IsRadioSelected(GroupBox grpBox)
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
                MessageBox.Show("Please select a radio button", "Input Error");
            }
            return theTruth;
        }


        public bool IsInteger(TextBox txtBox)
        {
            bool isNumeric = int.TryParse(txtBox.Text, out int n);
            if(isNumeric == false)
            {
                MessageBox.Show(txtBox.Tag.ToString() + " must be an integer.", "Input Error");
            }
            return isNumeric;
            
        }
    }
}
