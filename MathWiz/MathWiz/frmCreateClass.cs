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
    public partial class frmCreateClass : Form
    {
        List<Teacher> allTeachers;

        public frmCreateClass(int? teacherIndex = null)
        {
            InitializeComponent();

            if(teacherIndex != null) //if a teacher was selected in the listbox of teachers, pre-select them
            {

            }
            else
            {

            }
        }

        private void frmCreateClass_Load(object sender, EventArgs e)
        {
            backgroundWorkerLoadTeachers.RunWorkerAsync();
        }

        private void backgroundWorkerLoadTeachers_DoWork(object sender, DoWorkEventArgs e)
        {
            allTeachers = MathWizDA.SelectAllTeachers();
        }

        private void backgroundWorkerLoadTeachers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(Teacher t in allTeachers)
            {
                cmbTeacher.Items.Add(t.ToString());
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
