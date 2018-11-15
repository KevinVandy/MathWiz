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
    public partial class frmAdminHome : Form
    {
        Admin admin;

        List<Admin> allAdmins = new List<Admin>();
        List<Teacher> allTeachers = new List<Teacher>();
        List<Parent> allParents = new List<Parent>();
        List<Student> allStudents = new List<Student>();

        public frmAdminHome(string username)
        {
            InitializeComponent();
            admin = MathWizDA.SelectAdmin(username);
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            lstUserTypes.Items.Add("Admins");
            lstUserTypes.Items.Add("Teachers");
            lstUserTypes.Items.Add("Parents");
            lstUserTypes.Items.Add("Students");

            allAdmins = MathWizDA.SelectAllAdmins();
            allTeachers = MathWizDA.SelectAllTeachers();
            allParents = MathWizDA.SelectAllParents();
            allStudents = MathWizDA.SelectAllStudents();
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUserAccount();
            createUserForm.Tag = "Admin";
            createUserForm.ShowDialog();
        }

        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUserAccount();
            createUserForm.Tag = "Teacher";
            createUserForm.ShowDialog();
        }

        private void btnCreateParent_Click(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUserAccount();
            createUserForm.Tag = "Parent";
            createUserForm.ShowDialog();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            Form createUserForm = new frmCreateUserAccount();
            createUserForm.Tag = "Student";
            createUserForm.ShowDialog();
        }

        private void btnDeleteSelectedUser_Click(object sender, EventArgs e)
        {

        }

        private void lstUserTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUsers.Enabled = true;
            lstUsers.Items.Clear();
            
            if(lstUserTypes.SelectedIndex == 0)
            {
                foreach(Admin a in allAdmins)
                {
                    lstUsers.Items.Add(a.ToString());
                }
            }
            else if (lstUserTypes.SelectedIndex == 1)
            {
                foreach (Teacher t in allTeachers)
                {
                    lstUsers.Items.Add(t.ToString());
                }
            }
            else if (lstUserTypes.SelectedIndex == 2)
            {
                foreach (Parent p in allParents)
                {
                    lstUsers.Items.Add(p.ToString());
                }
            }
            else if (lstUserTypes.SelectedIndex == 3)
            {
                foreach (Student s in allStudents)
                {
                    lstUsers.Items.Add(s.ToString());
                }
            }
            if (lstUsers.SelectedItem != null)
            {
                btnDeleteSelectedUser.Enabled = true;
            }
            else
            {
                btnDeleteSelectedUser.Enabled = false;
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstUsers.SelectedItem != null)
            {
                btnDeleteSelectedUser.Enabled = true;
            }
            else
            {
                btnDeleteSelectedUser.Enabled = false;
            }
        }
    }
}
