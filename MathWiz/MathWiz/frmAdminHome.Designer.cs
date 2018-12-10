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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminHome));
            this.gbxManageAccounts = new System.Windows.Forms.GroupBox();
            this.lblDeleted = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizGroup3DataSet = new MathWiz.MathWizGroup3DataSet();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlUserTypes = new System.Windows.Forms.Panel();
            this.rdoStudents = new System.Windows.Forms.RadioButton();
            this.rdoParents = new System.Windows.Forms.RadioButton();
            this.rdoTeachers = new System.Windows.Forms.RadioButton();
            this.rdoAdmins = new System.Windows.Forms.RadioButton();
            this.btnDeleteSelectedUser = new System.Windows.Forms.Button();
            this.pgbLoadData = new System.Windows.Forms.ProgressBar();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.fillBySearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.usernameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.usernameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnClearSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCreateParent = new System.Windows.Forms.Button();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxManageClasses = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvStudents = new System.Windows.Forms.ListView();
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MasteryLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvKlasses = new System.Windows.Forms.ListView();
            this.ClassID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvTeachers = new System.Windows.Forms.ListView();
            this.TeacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeacherUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.chtMasterLevelDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorkerFormDataLoad = new System.ComponentModel.BackgroundWorker();
            this.parentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.teachersTableAdapter();
            this.parentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.parentsTableAdapter();
            this.studentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.studentsTableAdapter();
            this.adminsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.adminsTableAdapter();
            this.klassesTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.klassesTableAdapter();
            this.grbStatisticalAnalysis = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.gbxManageAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).BeginInit();
            this.pnlUserTypes.SuspendLayout();
            this.fillBySearchToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbxManageClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMasterLevelDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            this.grbStatisticalAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxManageAccounts
            // 
            this.gbxManageAccounts.Controls.Add(this.lblDeleted);
            this.gbxManageAccounts.Controls.Add(this.btnChangePassword);
            this.gbxManageAccounts.Controls.Add(this.dgvUsers);
            this.gbxManageAccounts.Controls.Add(this.lblProgress);
            this.gbxManageAccounts.Controls.Add(this.btnRefresh);
            this.gbxManageAccounts.Controls.Add(this.pnlUserTypes);
            this.gbxManageAccounts.Controls.Add(this.btnDeleteSelectedUser);
            this.gbxManageAccounts.Controls.Add(this.pgbLoadData);
            this.gbxManageAccounts.Controls.Add(this.btnCreateStudent);
            this.gbxManageAccounts.Controls.Add(this.fillBySearchToolStrip);
            this.gbxManageAccounts.Controls.Add(this.btnCreateParent);
            this.gbxManageAccounts.Controls.Add(this.btnCreateTeacher);
            this.gbxManageAccounts.Controls.Add(this.btnCreateAdmin);
            this.gbxManageAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxManageAccounts.Location = new System.Drawing.Point(24, 47);
            this.gbxManageAccounts.Name = "gbxManageAccounts";
            this.gbxManageAccounts.Size = new System.Drawing.Size(1097, 335);
            this.gbxManageAccounts.TabIndex = 0;
            this.gbxManageAccounts.TabStop = false;
            this.gbxManageAccounts.Text = "Manage Accounts";
            // 
            // lblDeleted
            // 
            this.lblDeleted.AutoSize = true;
            this.lblDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleted.ForeColor = System.Drawing.Color.Green;
            this.lblDeleted.Location = new System.Drawing.Point(904, 244);
            this.lblDeleted.Name = "lblDeleted";
            this.lblDeleted.Size = new System.Drawing.Size(154, 17);
            this.lblDeleted.TabIndex = 14;
            this.lblDeleted.Text = "Username was Deleted";
            this.lblDeleted.Visible = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(907, 176);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(161, 39);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.usernameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.studentsBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(407, 81);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 10;
            this.dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(475, 230);
            this.dgvUsers.TabIndex = 7;
            this.dgvUsers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellValueChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 30.45685F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 151.6018F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 105.7999F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 112.1414F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // mathWizGroup3DataSet
            // 
            this.mathWizGroup3DataSet.DataSetName = "MathWizGroup3DataSet";
            this.mathWizGroup3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblProgress.Location = new System.Drawing.Point(773, 29);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(119, 17);
            this.lblProgress.TabIndex = 13;
            this.lblProgress.Text = "Loading Students";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(907, 81);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 39);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlUserTypes
            // 
            this.pnlUserTypes.Controls.Add(this.rdoStudents);
            this.pnlUserTypes.Controls.Add(this.rdoParents);
            this.pnlUserTypes.Controls.Add(this.rdoTeachers);
            this.pnlUserTypes.Controls.Add(this.rdoAdmins);
            this.pnlUserTypes.Location = new System.Drawing.Point(240, 83);
            this.pnlUserTypes.Name = "pnlUserTypes";
            this.pnlUserTypes.Size = new System.Drawing.Size(161, 228);
            this.pnlUserTypes.TabIndex = 8;
            // 
            // rdoStudents
            // 
            this.rdoStudents.AutoSize = true;
            this.rdoStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStudents.Location = new System.Drawing.Point(16, 198);
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
            this.rdoParents.Location = new System.Drawing.Point(16, 135);
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
            this.rdoTeachers.Location = new System.Drawing.Point(16, 72);
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
            this.btnDeleteSelectedUser.Location = new System.Drawing.Point(907, 271);
            this.btnDeleteSelectedUser.Name = "btnDeleteSelectedUser";
            this.btnDeleteSelectedUser.Size = new System.Drawing.Size(161, 39);
            this.btnDeleteSelectedUser.TabIndex = 1;
            this.btnDeleteSelectedUser.Text = "Delete Selected User";
            this.btnDeleteSelectedUser.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedUser.Click += new System.EventHandler(this.btnDeleteSelectedUser_Click);
            // 
            // pgbLoadData
            // 
            this.pgbLoadData.Location = new System.Drawing.Point(605, 23);
            this.pgbLoadData.Name = "pgbLoadData";
            this.pgbLoadData.Size = new System.Drawing.Size(463, 29);
            this.pgbLoadData.TabIndex = 12;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudent.Location = new System.Drawing.Point(17, 270);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(217, 39);
            this.btnCreateStudent.TabIndex = 4;
            this.btnCreateStudent.Text = "Create New Student Account";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // fillBySearchToolStrip
            // 
            this.fillBySearchToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.fillBySearchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillBySearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBySearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripLabel,
            this.usernameToolStripTextBox,
            this.btnSearch,
            this.btnClearSearch});
            this.fillBySearchToolStrip.Location = new System.Drawing.Point(3, 19);
            this.fillBySearchToolStrip.Name = "fillBySearchToolStrip";
            this.fillBySearchToolStrip.Size = new System.Drawing.Size(1091, 41);
            this.fillBySearchToolStrip.TabIndex = 3;
            this.fillBySearchToolStrip.Text = "fillByAdminSearchToolStrip";
            // 
            // usernameToolStripLabel
            // 
            this.usernameToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameToolStripLabel.Margin = new System.Windows.Forms.Padding(10, 1, 5, 2);
            this.usernameToolStripLabel.Name = "usernameToolStripLabel";
            this.usernameToolStripLabel.Size = new System.Drawing.Size(153, 38);
            this.usernameToolStripLabel.Text = "Search for a Student:";
            // 
            // usernameToolStripTextBox
            // 
            this.usernameToolStripTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameToolStripTextBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.usernameToolStripTextBox.Name = "usernameToolStripTextBox";
            this.usernameToolStripTextBox.Size = new System.Drawing.Size(200, 33);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(4);
            this.btnSearch.Size = new System.Drawing.Size(73, 33);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClearSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(4);
            this.btnClearSearch.Size = new System.Drawing.Size(116, 33);
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnCreateParent
            // 
            this.btnCreateParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateParent.Location = new System.Drawing.Point(17, 207);
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
            this.btnCreateTeacher.Location = new System.Drawing.Point(17, 144);
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
            this.btnCreateAdmin.Location = new System.Drawing.Point(17, 81);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(217, 39);
            this.btnCreateAdmin.TabIndex = 1;
            this.btnCreateAdmin.Text = "Create New Admin Account";
            this.btnCreateAdmin.UseVisualStyleBackColor = true;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1169, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gbxManageClasses
            // 
            this.gbxManageClasses.Controls.Add(this.label3);
            this.gbxManageClasses.Controls.Add(this.label2);
            this.gbxManageClasses.Controls.Add(this.lsvStudents);
            this.gbxManageClasses.Controls.Add(this.lsvKlasses);
            this.gbxManageClasses.Controls.Add(this.lsvTeachers);
            this.gbxManageClasses.Controls.Add(this.label1);
            this.gbxManageClasses.Controls.Add(this.btnCreateClass);
            this.gbxManageClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxManageClasses.Location = new System.Drawing.Point(24, 415);
            this.gbxManageClasses.Name = "gbxManageClasses";
            this.gbxManageClasses.Size = new System.Drawing.Size(1097, 335);
            this.gbxManageClasses.TabIndex = 2;
            this.gbxManageClasses.TabStop = false;
            this.gbxManageClasses.Text = "Manage Teachers and Classes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "View Students In Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Class";
            // 
            // lsvStudents
            // 
            this.lsvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.StudentName,
            this.StudentUsername,
            this.MasteryLevel});
            this.lsvStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvStudents.FullRowSelect = true;
            this.lsvStudents.Location = new System.Drawing.Point(621, 46);
            this.lsvStudents.Name = "lsvStudents";
            this.lsvStudents.Size = new System.Drawing.Size(446, 255);
            this.lsvStudents.TabIndex = 10;
            this.lsvStudents.UseCompatibleStateImageBehavior = false;
            this.lsvStudents.View = System.Windows.Forms.View.Details;
            this.lsvStudents.SelectedIndexChanged += new System.EventHandler(this.lsvStudents_SelectedIndexChanged);
            // 
            // StudentID
            // 
            this.StudentID.Text = "Id";
            this.StudentID.Width = 32;
            // 
            // StudentName
            // 
            this.StudentName.Text = "Name";
            this.StudentName.Width = 178;
            // 
            // StudentUsername
            // 
            this.StudentUsername.Text = "Username";
            this.StudentUsername.Width = 172;
            // 
            // MasteryLevel
            // 
            this.MasteryLevel.Text = "ML";
            this.MasteryLevel.Width = 45;
            // 
            // lsvKlasses
            // 
            this.lsvKlasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassID,
            this.ClassName});
            this.lsvKlasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvKlasses.FullRowSelect = true;
            this.lsvKlasses.Location = new System.Drawing.Point(386, 46);
            this.lsvKlasses.Name = "lsvKlasses";
            this.lsvKlasses.Size = new System.Drawing.Size(215, 200);
            this.lsvKlasses.TabIndex = 9;
            this.lsvKlasses.UseCompatibleStateImageBehavior = false;
            this.lsvKlasses.View = System.Windows.Forms.View.Details;
            this.lsvKlasses.SelectedIndexChanged += new System.EventHandler(this.lsvKlasses_SelectedIndexChanged);
            // 
            // ClassID
            // 
            this.ClassID.Text = "Id";
            this.ClassID.Width = 34;
            // 
            // ClassName
            // 
            this.ClassName.Text = "ClassName";
            this.ClassName.Width = 171;
            // 
            // lsvTeachers
            // 
            this.lsvTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TeacherID,
            this.TeacherName,
            this.TeacherUsername});
            this.lsvTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvTeachers.FullRowSelect = true;
            this.lsvTeachers.Location = new System.Drawing.Point(16, 46);
            this.lsvTeachers.MultiSelect = false;
            this.lsvTeachers.Name = "lsvTeachers";
            this.lsvTeachers.Size = new System.Drawing.Size(350, 255);
            this.lsvTeachers.TabIndex = 8;
            this.lsvTeachers.UseCompatibleStateImageBehavior = false;
            this.lsvTeachers.View = System.Windows.Forms.View.Details;
            this.lsvTeachers.SelectedIndexChanged += new System.EventHandler(this.lsvTeachers_SelectedIndexChanged);
            // 
            // TeacherID
            // 
            this.TeacherID.Text = "Id";
            this.TeacherID.Width = 40;
            // 
            // TeacherName
            // 
            this.TeacherName.Text = "Name";
            this.TeacherName.Width = 140;
            // 
            // TeacherUsername
            // 
            this.TeacherUsername.Text = "Username";
            this.TeacherUsername.Width = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Teacher";
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClass.Location = new System.Drawing.Point(386, 262);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(215, 39);
            this.btnCreateClass.TabIndex = 5;
            this.btnCreateClass.Text = "Create New Class";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // chtMasterLevelDistribution
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMasterLevelDistribution.ChartAreas.Add(chartArea1);
            this.chtMasterLevelDistribution.Location = new System.Drawing.Point(28, 72);
            this.chtMasterLevelDistribution.Name = "chtMasterLevelDistribution";
            this.chtMasterLevelDistribution.Size = new System.Drawing.Size(338, 233);
            this.chtMasterLevelDistribution.TabIndex = 14;
            // 
            // backgroundWorkerFormDataLoad
            // 
            this.backgroundWorkerFormDataLoad.WorkerReportsProgress = true;
            this.backgroundWorkerFormDataLoad.WorkerSupportsCancellation = true;
            this.backgroundWorkerFormDataLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFormDataLoad_DoWork);
            this.backgroundWorkerFormDataLoad.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerFormDataLoad_ProgressChanged);
            this.backgroundWorkerFormDataLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFormDataLoad_RunWorkerCompleted);
            // 
            // parentsBindingSource
            // 
            this.parentsBindingSource.DataMember = "parents";
            this.parentsBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // klassesBindingSource
            // 
            this.klassesBindingSource.DataMember = "klasses";
            this.klassesBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "admins";
            this.adminsBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // parentsTableAdapter
            // 
            this.parentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // klassesTableAdapter
            // 
            this.klassesTableAdapter.ClearBeforeFill = true;
            // 
            // grbStatisticalAnalysis
            // 
            this.grbStatisticalAnalysis.Controls.Add(this.label4);
            this.grbStatisticalAnalysis.Controls.Add(this.chtMasterLevelDistribution);
            this.grbStatisticalAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStatisticalAnalysis.Location = new System.Drawing.Point(24, 783);
            this.grbStatisticalAnalysis.Name = "grbStatisticalAnalysis";
            this.grbStatisticalAnalysis.Size = new System.Drawing.Size(1097, 335);
            this.grbStatisticalAnalysis.TabIndex = 13;
            this.grbStatisticalAnalysis.TabStop = false;
            this.grbStatisticalAnalysis.Text = "Statistical Analysis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Class Mastery Level Histogram";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAdminName.Location = new System.Drawing.Point(132, 6);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(134, 13);
            this.lblAdminName.TabIndex = 14;
            this.lblAdminName.Text = "Logged in as: Admin Name";
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1186, 598);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.grbStatisticalAnalysis);
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
            this.gbxManageAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).EndInit();
            this.pnlUserTypes.ResumeLayout(false);
            this.pnlUserTypes.PerformLayout();
            this.fillBySearchToolStrip.ResumeLayout(false);
            this.fillBySearchToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxManageClasses.ResumeLayout(false);
            this.gbxManageClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMasterLevelDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            this.grbStatisticalAnalysis.ResumeLayout(false);
            this.grbStatisticalAnalysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxManageAccounts;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnCreateParent;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.Button btnDeleteSelectedUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxManageClasses;
        private System.Windows.Forms.Panel pnlUserTypes;
        private System.Windows.Forms.RadioButton rdoStudents;
        private System.Windows.Forms.RadioButton rdoParents;
        private System.Windows.Forms.RadioButton rdoTeachers;
        private System.Windows.Forms.RadioButton rdoAdmins;
        private System.Windows.Forms.Button btnCreateClass;
        private MathWizGroup3DataSet mathWizGroup3DataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private MathWizGroup3DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource parentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.parentsTableAdapter parentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private MathWizGroup3DataSetTableAdapters.adminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip fillBySearchToolStrip;
        private System.Windows.Forms.ToolStripLabel usernameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox usernameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFormDataLoad;
        private System.Windows.Forms.ProgressBar pgbLoadData;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblDeleted;
        private System.Windows.Forms.BindingSource klassesBindingSource;
        private MathWizGroup3DataSetTableAdapters.klassesTableAdapter klassesTableAdapter;
        private System.Windows.Forms.ListView lsvStudents;
        private System.Windows.Forms.ListView lsvKlasses;
        private System.Windows.Forms.ListView lsvTeachers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnClearSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbStatisticalAnalysis;
        private System.Windows.Forms.ColumnHeader TeacherID;
        private System.Windows.Forms.ColumnHeader TeacherName;
        private System.Windows.Forms.ColumnHeader ClassID;
        private System.Windows.Forms.ColumnHeader ClassName;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader MasteryLevel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMasterLevelDistribution;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.ColumnHeader TeacherUsername;
        private System.Windows.Forms.ColumnHeader StudentUsername;
        private System.Windows.Forms.Label label4;
    }
}