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
    public partial class frmChangeML : Form
    {
        int oldML;
        string username;

        public frmChangeML(int studentsML, string username)
        {
            InitializeComponent();
            oldML = studentsML;
            this.username = username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangeML_Load(object sender, EventArgs e)
        {
            txtOldMasteryLevel.Text = oldML.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (Validation.IsInteger(txtNewMasteryLevel) && Validation.IsWithinRangeInclusive(txtNewMasteryLevel, 12, 0))
            {
                int newML = Convert.ToInt32(txtNewMasteryLevel.Text);
                MathWizDB.UpdateMasteryLevel(username, newML);
                this.Close();
            }
        }
    }
}
