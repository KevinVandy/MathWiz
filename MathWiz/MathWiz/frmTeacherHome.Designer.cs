namespace MathWiz
{
    partial class frmTeacherHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherHome));
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlasses = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMasteryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizGroup3DataSet = new MathWiz.MathWizGroup3DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKlass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblStudentGrades = new System.Windows.Forms.Label();
            this.lsvStudentGrades = new System.Windows.Forms.ListView();
            this.gradedTestId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestDateTaken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestTimeTakenToComplete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestFeedback = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtMasterLevelDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxKlassStatistics = new System.Windows.Forms.GroupBox();
            this.lblAverageML = new System.Windows.Forms.Label();
            this.lblNumberStudents = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.studentsTableAdapter();
            this.graded_testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graded_testsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.graded_testsTableAdapter();
            this.pgbLoadData = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.gbxTests = new System.Windows.Forms.GroupBox();
            this.btnEditTest = new System.Windows.Forms.Button();
            this.btnGenerateTests = new System.Windows.Forms.Button();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passThreshHoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.testsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMasterLevelDistribution)).BeginInit();
            this.gbxKlassStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsBindingSource)).BeginInit();
            this.gbxTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.Blue;
            this.lblTeacherName.Location = new System.Drawing.Point(134, 6);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(71, 13);
            this.lblTeacherName.TabIndex = 1;
            this.lblTeacherName.Text = "Logged in as:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Class:";
            // 
            // cmbKlasses
            // 
            this.cmbKlasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKlasses.FormattingEnabled = true;
            this.cmbKlasses.Location = new System.Drawing.Point(202, 46);
            this.cmbKlasses.Name = "cmbKlasses";
            this.cmbKlasses.Size = new System.Drawing.Size(314, 39);
            this.cmbKlasses.TabIndex = 5;
            this.cmbKlasses.SelectedIndexChanged += new System.EventHandler(this.cmbKlasses_SelectedIndexChanged);
            // 
            // backgroundWorkerLoadData
            // 
            this.backgroundWorkerLoadData.WorkerReportsProgress = true;
            this.backgroundWorkerLoadData.WorkerSupportsCancellation = true;
            this.backgroundWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadData_DoWork);
            this.backgroundWorkerLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerLoadData_ProgressChanged);
            this.backgroundWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadData_RunWorkerCompleted);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.FirstName,
            this.LastName,
            this.studentMasteryLevel});
            this.dgvStudents.DataSource = this.studentsBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(20, 30);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(468, 233);
            this.dgvStudents.TabIndex = 9;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // studentMasteryLevel
            // 
            this.studentMasteryLevel.DataPropertyName = "MasteryLevel";
            this.studentMasteryLevel.HeaderText = "ML";
            this.studentMasteryLevel.Name = "studentMasteryLevel";
            this.studentMasteryLevel.ReadOnly = true;
            this.studentMasteryLevel.Width = 40;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1434, 24);
            this.menuStrip1.TabIndex = 9;
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
            // lblKlass
            // 
            this.lblKlass.AutoSize = true;
            this.lblKlass.Location = new System.Drawing.Point(486, 87);
            this.lblKlass.Name = "lblKlass";
            this.lblKlass.Size = new System.Drawing.Size(0, 13);
            this.lblKlass.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.lblStudentGrades);
            this.groupBox1.Controls.Add(this.lsvStudentGrades);
            this.groupBox1.Controls.Add(this.dgvStudents);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 480);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(513, 30);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(211, 39);
            this.btnChangePassword.TabIndex = 17;
            this.btnChangePassword.Text = "Change Student\'s Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblStudentGrades
            // 
            this.lblStudentGrades.AutoSize = true;
            this.lblStudentGrades.Location = new System.Drawing.Point(17, 280);
            this.lblStudentGrades.Name = "lblStudentGrades";
            this.lblStudentGrades.Size = new System.Drawing.Size(127, 17);
            this.lblStudentGrades.TabIndex = 16;
            this.lblStudentGrades.Text = "First Last\'s Grades";
            // 
            // lsvStudentGrades
            // 
            this.lsvStudentGrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gradedTestId,
            this.gradedTestType,
            this.gradedTestDateTaken,
            this.gradedTestTimeTakenToComplete,
            this.gradedTestScore,
            this.gradedTestFeedback});
            this.lsvStudentGrades.FullRowSelect = true;
            this.lsvStudentGrades.Location = new System.Drawing.Point(20, 300);
            this.lsvStudentGrades.MultiSelect = false;
            this.lsvStudentGrades.Name = "lsvStudentGrades";
            this.lsvStudentGrades.Size = new System.Drawing.Size(704, 157);
            this.lsvStudentGrades.TabIndex = 14;
            this.lsvStudentGrades.UseCompatibleStateImageBehavior = false;
            this.lsvStudentGrades.View = System.Windows.Forms.View.Details;
            // 
            // gradedTestId
            // 
            this.gradedTestId.Text = "Id";
            this.gradedTestId.Width = 36;
            // 
            // gradedTestType
            // 
            this.gradedTestType.Text = "Test Type";
            this.gradedTestType.Width = 134;
            // 
            // gradedTestDateTaken
            // 
            this.gradedTestDateTaken.Text = "Date Taken";
            this.gradedTestDateTaken.Width = 123;
            // 
            // gradedTestTimeTakenToComplete
            // 
            this.gradedTestTimeTakenToComplete.Text = "Duration";
            this.gradedTestTimeTakenToComplete.Width = 102;
            // 
            // gradedTestScore
            // 
            this.gradedTestScore.Text = "Score";
            this.gradedTestScore.Width = 71;
            // 
            // gradedTestFeedback
            // 
            this.gradedTestFeedback.Text = "Feedback";
            this.gradedTestFeedback.Width = 209;
            // 
            // chtMasterLevelDistribution
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMasterLevelDistribution.ChartAreas.Add(chartArea1);
            this.chtMasterLevelDistribution.Location = new System.Drawing.Point(30, 192);
            this.chtMasterLevelDistribution.Name = "chtMasterLevelDistribution";
            this.chtMasterLevelDistribution.Size = new System.Drawing.Size(509, 265);
            this.chtMasterLevelDistribution.TabIndex = 15;
            // 
            // gbxKlassStatistics
            // 
            this.gbxKlassStatistics.Controls.Add(this.lblAverageML);
            this.gbxKlassStatistics.Controls.Add(this.lblNumberStudents);
            this.gbxKlassStatistics.Controls.Add(this.label4);
            this.gbxKlassStatistics.Controls.Add(this.chtMasterLevelDistribution);
            this.gbxKlassStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKlassStatistics.Location = new System.Drawing.Point(812, 103);
            this.gbxKlassStatistics.Name = "gbxKlassStatistics";
            this.gbxKlassStatistics.Size = new System.Drawing.Size(571, 480);
            this.gbxKlassStatistics.TabIndex = 18;
            this.gbxKlassStatistics.TabStop = false;
            this.gbxKlassStatistics.Text = "Class Statistics";
            // 
            // lblAverageML
            // 
            this.lblAverageML.AutoSize = true;
            this.lblAverageML.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageML.Location = new System.Drawing.Point(18, 70);
            this.lblAverageML.Name = "lblAverageML";
            this.lblAverageML.Size = new System.Drawing.Size(240, 26);
            this.lblAverageML.TabIndex = 20;
            this.lblAverageML.Text = "Average Mastery Level:";
            // 
            // lblNumberStudents
            // 
            this.lblNumberStudents.AutoSize = true;
            this.lblNumberStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberStudents.Location = new System.Drawing.Point(18, 34);
            this.lblNumberStudents.Name = "lblNumberStudents";
            this.lblNumberStudents.Size = new System.Drawing.Size(212, 26);
            this.lblNumberStudents.TabIndex = 19;
            this.lblNumberStudents.Text = "Number of Students:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Class Mastery Level Histogram";
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // graded_testsBindingSource
            // 
            this.graded_testsBindingSource.DataMember = "graded_tests";
            this.graded_testsBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // graded_testsTableAdapter
            // 
            this.graded_testsTableAdapter.ClearBeforeFill = true;
            // 
            // pgbLoadData
            // 
            this.pgbLoadData.Location = new System.Drawing.Point(541, 46);
            this.pgbLoadData.Name = "pgbLoadData";
            this.pgbLoadData.Size = new System.Drawing.Size(238, 39);
            this.pgbLoadData.TabIndex = 19;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(590, 61);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 20;
            // 
            // gbxTests
            // 
            this.gbxTests.Controls.Add(this.btnEditTest);
            this.gbxTests.Controls.Add(this.btnGenerateTests);
            this.gbxTests.Controls.Add(this.btnCreateTest);
            this.gbxTests.Controls.Add(this.dgvTests);
            this.gbxTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTests.Location = new System.Drawing.Point(28, 613);
            this.gbxTests.Name = "gbxTests";
            this.gbxTests.Size = new System.Drawing.Size(1345, 300);
            this.gbxTests.TabIndex = 21;
            this.gbxTests.TabStop = false;
            this.gbxTests.Text = "Manage Tests";
            // 
            // btnEditTest
            // 
            this.btnEditTest.Enabled = false;
            this.btnEditTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTest.Location = new System.Drawing.Point(914, 239);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Size = new System.Drawing.Size(245, 39);
            this.btnEditTest.TabIndex = 25;
            this.btnEditTest.Text = "Delete Test";
            this.btnEditTest.UseVisualStyleBackColor = true;
            this.btnEditTest.Click += new System.EventHandler(this.btnEditTest_Click);
            // 
            // btnGenerateTests
            // 
            this.btnGenerateTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTests.Location = new System.Drawing.Point(914, 145);
            this.btnGenerateTests.Name = "btnGenerateTests";
            this.btnGenerateTests.Size = new System.Drawing.Size(245, 39);
            this.btnGenerateTests.TabIndex = 24;
            this.btnGenerateTests.Text = "Generate All Mastery Tests";
            this.btnGenerateTests.UseVisualStyleBackColor = true;
            this.btnGenerateTests.Click += new System.EventHandler(this.btnGenerateTests_Click);
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTest.Location = new System.Drawing.Point(914, 43);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(245, 39);
            this.btnCreateTest.TabIndex = 23;
            this.btnCreateTest.Text = "Create Placement Test";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.AllowUserToDeleteRows = false;
            this.dgvTests.AutoGenerateColumns = false;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.testTypeDataGridViewTextBoxColumn,
            this.timeLimitDataGridViewTextBoxColumn,
            this.passThreshHoldDataGridViewTextBoxColumn,
            this.minLevelDataGridViewTextBoxColumn,
            this.maxLevelDataGridViewTextBoxColumn});
            this.dgvTests.DataSource = this.testsBindingSource;
            this.dgvTests.Location = new System.Drawing.Point(20, 43);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.Size = new System.Drawing.Size(851, 236);
            this.dgvTests.TabIndex = 22;
            this.dgvTests.SelectionChanged += new System.EventHandler(this.dgvTests_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // testTypeDataGridViewTextBoxColumn
            // 
            this.testTypeDataGridViewTextBoxColumn.DataPropertyName = "TestType";
            this.testTypeDataGridViewTextBoxColumn.HeaderText = "TestType";
            this.testTypeDataGridViewTextBoxColumn.Name = "testTypeDataGridViewTextBoxColumn";
            this.testTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.testTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // timeLimitDataGridViewTextBoxColumn
            // 
            this.timeLimitDataGridViewTextBoxColumn.DataPropertyName = "TimeLimit";
            this.timeLimitDataGridViewTextBoxColumn.HeaderText = "TimeLimit";
            this.timeLimitDataGridViewTextBoxColumn.Name = "timeLimitDataGridViewTextBoxColumn";
            this.timeLimitDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeLimitDataGridViewTextBoxColumn.Width = 120;
            // 
            // passThreshHoldDataGridViewTextBoxColumn
            // 
            this.passThreshHoldDataGridViewTextBoxColumn.DataPropertyName = "PassThreshHold";
            this.passThreshHoldDataGridViewTextBoxColumn.HeaderText = "PassThreshHold";
            this.passThreshHoldDataGridViewTextBoxColumn.Name = "passThreshHoldDataGridViewTextBoxColumn";
            this.passThreshHoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.passThreshHoldDataGridViewTextBoxColumn.Width = 150;
            // 
            // minLevelDataGridViewTextBoxColumn
            // 
            this.minLevelDataGridViewTextBoxColumn.DataPropertyName = "MinLevel";
            this.minLevelDataGridViewTextBoxColumn.HeaderText = "MinLevel";
            this.minLevelDataGridViewTextBoxColumn.Name = "minLevelDataGridViewTextBoxColumn";
            this.minLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxLevelDataGridViewTextBoxColumn
            // 
            this.maxLevelDataGridViewTextBoxColumn.DataPropertyName = "MaxLevel";
            this.maxLevelDataGridViewTextBoxColumn.HeaderText = "MaxLevel";
            this.maxLevelDataGridViewTextBoxColumn.Name = "maxLevelDataGridViewTextBoxColumn";
            this.maxLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "tests";
            this.testsBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // frmTeacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1434, 1003);
            this.Controls.Add(this.gbxTests);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.gbxKlassStatistics);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblKlass);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbKlasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbLoadData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeacherHome";
            this.Text = "MathWiz - Teacher Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeacherHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMasterLevelDistribution)).EndInit();
            this.gbxKlassStatistics.ResumeLayout(false);
            this.gbxKlassStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsBindingSource)).EndInit();
            this.gbxTests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKlasses;
        private MathWizGroup3DataSet mathWizGroup3DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblKlass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvStudentGrades;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMasterLevelDistribution;
        private System.Windows.Forms.Label lblStudentGrades;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ColumnHeader gradedTestId;
        private System.Windows.Forms.ColumnHeader gradedTestType;
        private System.Windows.Forms.ColumnHeader gradedTestScore;
        private System.Windows.Forms.ColumnHeader gradedTestFeedback;
        private System.Windows.Forms.GroupBox gbxKlassStatistics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader gradedTestDateTaken;
        private System.Windows.Forms.ColumnHeader gradedTestTimeTakenToComplete;
        private System.Windows.Forms.Label lblNumberStudents;
        private System.Windows.Forms.BindingSource graded_testsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMasteryLevel;
        private System.Windows.Forms.Label lblAverageML;
        private MathWizGroup3DataSetTableAdapters.graded_testsTableAdapter graded_testsTableAdapter;
        private System.Windows.Forms.ProgressBar pgbLoadData;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox gbxTests;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private MathWizGroup3DataSetTableAdapters.testsTableAdapter testsTableAdapter;
        private System.Windows.Forms.Button btnEditTest;
        private System.Windows.Forms.Button btnGenerateTests;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passThreshHoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLevelDataGridViewTextBoxColumn;
    }
}