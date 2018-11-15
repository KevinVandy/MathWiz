namespace MathWiz
{
    partial class frmAdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminHome));
            this.gbxManageAccounts = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizGroup3DataSet1 = new MathWiz.MathWizGroup3DataSet();
            this.pnlUserTypes = new System.Windows.Forms.Panel();
            this.rdoStudents = new System.Windows.Forms.RadioButton();
            this.rdoParents = new System.Windows.Forms.RadioButton();
            this.rdoTeachers = new System.Windows.Forms.RadioButton();
            this.rdoAdmins = new System.Windows.Forms.RadioButton();
            this.btnDeleteSelectedUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnCreateParent = new System.Windows.Forms.Button();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxManageClasses = new System.Windows.Forms.GroupBox();
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.mathWizGroup3DataSet = new MathWiz.MathWizGroup3DataSet();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.adminsTableAdapter();
            this.teachersTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.teachersTableAdapter();
            this.parentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.parentsTableAdapter();
            this.studentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.studentsTableAdapter();
            this.gbxManageAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet1)).BeginInit();
            this.pnlUserTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbxManageClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxManageAccounts
            // 
            this.gbxManageAccounts.Controls.Add(this.dgvUsers);
            this.gbxManageAccounts.Controls.Add(this.pnlUserTypes);
            this.gbxManageAccounts.Controls.Add(this.btnDeleteSelectedUser);
            this.gbxManageAccounts.Controls.Add(this.lstUsers);
            this.gbxManageAccounts.Controls.Add(this.btnCreateStudent);
            this.gbxManageAccounts.Controls.Add(this.btnCreateParent);
            this.gbxManageAccounts.Controls.Add(this.btnCreateTeacher);
            this.gbxManageAccounts.Controls.Add(this.btnCreateAdmin);
            this.gbxManageAccounts.Location = new System.Drawing.Point(24, 47);
            this.gbxManageAccounts.Name = "gbxManageAccounts";
            this.gbxManageAccounts.Size = new System.Drawing.Size(1144, 309);
            this.gbxManageAccounts.TabIndex = 0;
            this.gbxManageAccounts.TabStop = false;
            this.gbxManageAccounts.Text = "Manage Accounts";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.parentsBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(643, 44);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(475, 228);
            this.dgvUsers.TabIndex = 7;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.mathWizGroup3DataSet1;
            // 
            // mathWizGroup3DataSet1
            // 
            this.mathWizGroup3DataSet1.DataSetName = "MathWizGroup3DataSet";
            this.mathWizGroup3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlUserTypes
            // 
            this.pnlUserTypes.Controls.Add(this.rdoStudents);
            this.pnlUserTypes.Controls.Add(this.rdoParents);
            this.pnlUserTypes.Controls.Add(this.rdoTeachers);
            this.pnlUserTypes.Controls.Add(this.rdoAdmins);
            this.pnlUserTypes.Location = new System.Drawing.Point(257, 46);
            this.pnlUserTypes.Name = "pnlUserTypes";
            this.pnlUserTypes.Size = new System.Drawing.Size(161, 163);
            this.pnlUserTypes.TabIndex = 8;
            // 
            // rdoStudents
            // 
            this.rdoStudents.AutoSize = true;
            this.rdoStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStudents.Location = new System.Drawing.Point(16, 135);
            this.rdoStudents.Name = "rdoStudents";
            this.rdoStudents.Size = new System.Drawing.Size(120, 21);
            this.rdoStudents.TabIndex = 3;
            this.rdoStudents.TabStop = true;
            this.rdoStudents.Text = "Show Students";
            this.rdoStudents.UseVisualStyleBackColor = true;
            this.rdoStudents.CheckedChanged += new System.EventHandler(this.rdoUserTypes_CheckChanged);
            // 
            // rdoParents
            // 
            this.rdoParents.AutoSize = true;
            this.rdoParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoParents.Location = new System.Drawing.Point(16, 93);
            this.rdoParents.Name = "rdoParents";
            this.rdoParents.Size = new System.Drawing.Size(113, 21);
            this.rdoParents.TabIndex = 2;
            this.rdoParents.TabStop = true;
            this.rdoParents.Text = "Show Parents";
            this.rdoParents.UseVisualStyleBackColor = true;
            this.rdoParents.CheckedChanged += new System.EventHandler(this.rdoUserTypes_CheckChanged);
            // 
            // rdoTeachers
            // 
            this.rdoTeachers.AutoSize = true;
            this.rdoTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTeachers.Location = new System.Drawing.Point(16, 51);
            this.rdoTeachers.Name = "rdoTeachers";
            this.rdoTeachers.Size = new System.Drawing.Size(124, 21);
            this.rdoTeachers.TabIndex = 1;
            this.rdoTeachers.TabStop = true;
            this.rdoTeachers.Text = "Show Teachers";
            this.rdoTeachers.UseVisualStyleBackColor = true;
            this.rdoTeachers.CheckedChanged += new System.EventHandler(this.rdoUserTypes_CheckChanged);
            // 
            // rdoAdmins
            // 
            this.rdoAdmins.AutoSize = true;
            this.rdoAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdmins.Location = new System.Drawing.Point(16, 9);
            this.rdoAdmins.Name = "rdoAdmins";
            this.rdoAdmins.Size = new System.Drawing.Size(110, 21);
            this.rdoAdmins.TabIndex = 0;
            this.rdoAdmins.TabStop = true;
            this.rdoAdmins.Text = "Show Admins";
            this.rdoAdmins.UseVisualStyleBackColor = true;
            this.rdoAdmins.CheckedChanged += new System.EventHandler(this.rdoUserTypes_CheckChanged);
            // 
            // btnDeleteSelectedUser
            // 
            this.btnDeleteSelectedUser.Enabled = false;
            this.btnDeleteSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedUser.Location = new System.Drawing.Point(257, 233);
            this.btnDeleteSelectedUser.Name = "btnDeleteSelectedUser";
            this.btnDeleteSelectedUser.Size = new System.Drawing.Size(161, 39);
            this.btnDeleteSelectedUser.TabIndex = 1;
            this.btnDeleteSelectedUser.Text = "Delete Selected User";
            this.btnDeleteSelectedUser.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedUser.Click += new System.EventHandler(this.btnDeleteSelectedUser_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Enabled = false;
            this.lstUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 16;
            this.lstUsers.Location = new System.Drawing.Point(442, 44);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(180, 228);
            this.lstUsers.TabIndex = 5;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudent.Location = new System.Drawing.Point(16, 233);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(217, 39);
            this.btnCreateStudent.TabIndex = 4;
            this.btnCreateStudent.Text = "Create New Student Account";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnCreateParent
            // 
            this.btnCreateParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateParent.Location = new System.Drawing.Point(16, 170);
            this.btnCreateParent.Name = "btnCreateParent";
            this.btnCreateParent.Size = new System.Drawing.Size(217, 39);
            this.btnCreateParent.TabIndex = 3;
            this.btnCreateParent.Text = "Create New Parent Account";
            this.btnCreateParent.UseVisualStyleBackColor = true;
            this.btnCreateParent.Click += new System.EventHandler(this.btnCreateParent_Click);
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeacher.Location = new System.Drawing.Point(16, 107);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(217, 39);
            this.btnCreateTeacher.TabIndex = 2;
            this.btnCreateTeacher.Text = "Create New Teacher Account";
            this.btnCreateTeacher.UseVisualStyleBackColor = true;
            this.btnCreateTeacher.Click += new System.EventHandler(this.btnCreateTeacher_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdmin.Location = new System.Drawing.Point(16, 44);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(217, 39);
            this.btnCreateAdmin.TabIndex = 1;
            this.btnCreateAdmin.Text = "Create New Admin Account";
            this.btnCreateAdmin.UseVisualStyleBackColor = true;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.mathWizGroup3DataSet1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.parentToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addAccountToolStripMenuItem.Text = "Create Account";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // parentToolStripMenuItem
            // 
            this.parentToolStripMenuItem.Name = "parentToolStripMenuItem";
            this.parentToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.parentToolStripMenuItem.Text = "Parent";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // gbxManageClasses
            // 
            this.gbxManageClasses.Controls.Add(this.lstClasses);
            this.gbxManageClasses.Controls.Add(this.btnCreateClass);
            this.gbxManageClasses.Location = new System.Drawing.Point(24, 379);
            this.gbxManageClasses.Name = "gbxManageClasses";
            this.gbxManageClasses.Size = new System.Drawing.Size(1041, 309);
            this.gbxManageClasses.TabIndex = 2;
            this.gbxManageClasses.TabStop = false;
            this.gbxManageClasses.Text = "Manage Classes";
            // 
            // lstClasses
            // 
            this.lstClasses.Enabled = false;
            this.lstClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.ItemHeight = 16;
            this.lstClasses.Location = new System.Drawing.Point(263, 39);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(180, 228);
            this.lstClasses.TabIndex = 6;
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClass.Location = new System.Drawing.Point(16, 39);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(217, 39);
            this.btnCreateClass.TabIndex = 5;
            this.btnCreateClass.Text = "Create New Class";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            // 
            // mathWizGroup3DataSet
            // 
            this.mathWizGroup3DataSet.DataSetName = "MathWizGroup3DataSet";
            this.mathWizGroup3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "admins";
            this.adminsBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // parentsBindingSource
            // 
            this.parentsBindingSource.DataMember = "parents";
            this.parentsBindingSource.DataSource = this.mathWizGroup3DataSet1;
            // 
            // parentsTableAdapter
            // 
            this.parentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1214, 623);
            this.Controls.Add(this.gbxManageClasses);
            this.Controls.Add(this.gbxManageAccounts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminHome";
            this.Text = "MathWiz - Admin Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminHome_Load);
            this.gbxManageAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet1)).EndInit();
            this.pnlUserTypes.ResumeLayout(false);
            this.pnlUserTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxManageClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxManageAccounts;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnCreateParent;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.Button btnDeleteSelectedUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxManageClasses;
        private System.Windows.Forms.Panel pnlUserTypes;
        private System.Windows.Forms.RadioButton rdoStudents;
        private System.Windows.Forms.RadioButton rdoParents;
        private System.Windows.Forms.RadioButton rdoTeachers;
        private System.Windows.Forms.RadioButton rdoAdmins;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.DataGridView dgvUsers;
        private MathWizGroup3DataSet mathWizGroup3DataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private MathWizGroup3DataSetTableAdapters.adminsTableAdapter adminsTableAdapter;
        private MathWizGroup3DataSet mathWizGroup3DataSet1;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private MathWizGroup3DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource parentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.parentsTableAdapter parentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}