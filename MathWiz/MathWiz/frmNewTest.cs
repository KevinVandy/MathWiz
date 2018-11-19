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
            if (Validation.IsComboSelected(cboType) &&
               Validation.IsMaskPresent(mskTime) &&
               Validation.IsMaskPresent(mskThreshold) &&
               Validation.IsComboSelected(cboMinimum) &&
               Validation.IsComboSelected(cboMaximum) &&
               Validation.IsComboSelected(cboRandom) &&
               Validation.secondIndexNotLower(cboMinimum, cboMaximum))
            {
                MessageBox.Show("hooray!");
            }
        }
    }
}
