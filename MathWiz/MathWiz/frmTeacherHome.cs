﻿using System;
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
    public partial class frmTeacherHome : Form
    {
        public frmTeacherHome(Teacher teacher)
        {
            InitializeComponent();
        }

        private void frmTeacherHome_Load(object sender, EventArgs e)
        {

        }

        private void frmTeacherHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}