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
    public partial class frmStudentHome : Form
    {
        public frmStudentHome(Student student)
        {
            InitializeComponent();
        }

        private void frmStudentHome_Load(object sender, EventArgs e)
        {

        }

        private void frmStudentHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}