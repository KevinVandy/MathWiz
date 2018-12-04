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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherHome));
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlasses = new System.Windows.Forms.ComboBox();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.backgroundWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.dgvGradedTests = new System.Windows.Forms.DataGridView();
            this.gradedTest_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestTimeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestDateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestNumberAttempts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestPast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recommendedLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradedTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizGroup3DataSet = new MathWiz.MathWizGroup3DataSet();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasteryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.studentsTableAdapter();
            this.testsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.testsTableAdapter();
            this.gradedTestsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.graded_testsTableAdapter();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.tabForm = new System.Windows.Forms.TabControl();
            this.tabStudentTests = new System.Windows.Forms.TabPage();
            this.tabKlassTests = new System.Windows.Forms.TabPage();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomlyGeneratedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passThreshHoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradedTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradedTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabStudentTests.SuspendLayout();
            this.tabKlassTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.Blue;
            this.lblTeacherName.Location = new System.Drawing.Point(22, 49);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(141, 22);
            this.lblTeacherName.TabIndex = 1;
            this.lblTeacherName.Text = "Teacher Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(192, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Classes";
            // 
            // cmbKlasses
            // 
            this.cmbKlasses.FormattingEnabled = true;
            this.cmbKlasses.Location = new System.Drawing.Point(351, 51);
            this.cmbKlasses.Name = "cmbKlasses";
            this.cmbKlasses.Size = new System.Drawing.Size(121, 21);
            this.cmbKlasses.TabIndex = 5;
            this.cmbKlasses.SelectedIndexChanged += new System.EventHandler(this.cmbKlasses_SelectedIndexChanged);
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(1111, 475);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(116, 36);
            this.btnCreateTest.TabIndex = 7;
            this.btnCreateTest.Text = "Create New Test";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // backgroundWorkerLoadData
            // 
            this.backgroundWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadData_DoWork);
            this.backgroundWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadData_RunWorkerCompleted);
            // 
            // dgvGradedTests
            // 
            this.dgvGradedTests.AllowUserToAddRows = false;
            this.dgvGradedTests.AllowUserToDeleteRows = false;
            this.dgvGradedTests.AutoGenerateColumns = false;
            this.dgvGradedTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradedTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradedTest_Id,
            this.gradedTestStudentID,
            this.gradedTestTestID,
            this.gradedTestScore,
            this.gradedTestTimeTaken,
            this.gradedTestDateTaken,
            this.gradedTestFeedback,
            this.gradedTestNumberAttempts,
            this.gradedTestPast,
            this.recommendedLevelDataGridViewTextBoxColumn});
            this.dgvGradedTests.DataSource = this.gradedTestBindingSource;
            this.dgvGradedTests.Location = new System.Drawing.Point(25, 51);
            this.dgvGradedTests.MultiSelect = false;
            this.dgvGradedTests.Name = "dgvGradedTests";
            this.dgvGradedTests.ReadOnly = true;
            this.dgvGradedTests.RowHeadersVisible = false;
            this.dgvGradedTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradedTests.Size = new System.Drawing.Size(822, 150);
            this.dgvGradedTests.TabIndex = 0;
            // 
            // gradedTest_Id
            // 
            this.gradedTest_Id.DataPropertyName = "Id";
            this.gradedTest_Id.HeaderText = "Id";
            this.gradedTest_Id.Name = "gradedTest_Id";
            this.gradedTest_Id.ReadOnly = true;
            this.gradedTest_Id.Visible = false;
            // 
            // gradedTestStudentID
            // 
            this.gradedTestStudentID.DataPropertyName = "StudentID";
            this.gradedTestStudentID.HeaderText = "StudentID";
            this.gradedTestStudentID.Name = "gradedTestStudentID";
            this.gradedTestStudentID.ReadOnly = true;
            this.gradedTestStudentID.Visible = false;
            // 
            // gradedTestTestID
            // 
            this.gradedTestTestID.DataPropertyName = "TestID";
            this.gradedTestTestID.HeaderText = "TestID";
            this.gradedTestTestID.Name = "gradedTestTestID";
            this.gradedTestTestID.ReadOnly = true;
            // 
            // gradedTestScore
            // 
            this.gradedTestScore.DataPropertyName = "Score";
            this.gradedTestScore.HeaderText = "Score";
            this.gradedTestScore.Name = "gradedTestScore";
            this.gradedTestScore.ReadOnly = true;
            // 
            // gradedTestTimeTaken
            // 
            this.gradedTestTimeTaken.DataPropertyName = "TimeTakenToComplete";
            this.gradedTestTimeTaken.HeaderText = "TimeTakenToComplete";
            this.gradedTestTimeTaken.Name = "gradedTestTimeTaken";
            this.gradedTestTimeTaken.ReadOnly = true;
            // 
            // gradedTestDateTaken
            // 
            this.gradedTestDateTaken.DataPropertyName = "DateTaken";
            this.gradedTestDateTaken.HeaderText = "DateTaken";
            this.gradedTestDateTaken.Name = "gradedTestDateTaken";
            this.gradedTestDateTaken.ReadOnly = true;
            // 
            // gradedTestFeedback
            // 
            this.gradedTestFeedback.DataPropertyName = "Feedback";
            this.gradedTestFeedback.HeaderText = "Feedback";
            this.gradedTestFeedback.Name = "gradedTestFeedback";
            this.gradedTestFeedback.ReadOnly = true;
            // 
            // gradedTestNumberAttempts
            // 
            this.gradedTestNumberAttempts.DataPropertyName = "NumberAttempts";
            this.gradedTestNumberAttempts.HeaderText = "NumberAttempts";
            this.gradedTestNumberAttempts.Name = "gradedTestNumberAttempts";
            this.gradedTestNumberAttempts.ReadOnly = true;
            // 
            // gradedTestPast
            // 
            this.gradedTestPast.DataPropertyName = "Passed";
            this.gradedTestPast.HeaderText = "Passed";
            this.gradedTestPast.Name = "gradedTestPast";
            this.gradedTestPast.ReadOnly = true;
            // 
            // recommendedLevelDataGridViewTextBoxColumn
            // 
            this.recommendedLevelDataGridViewTextBoxColumn.DataPropertyName = "RecommendedLevel";
            this.recommendedLevelDataGridViewTextBoxColumn.HeaderText = "RecommendedLevel";
            this.recommendedLevelDataGridViewTextBoxColumn.Name = "recommendedLevelDataGridViewTextBoxColumn";
            this.recommendedLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradedTestBindingSource
            // 
            this.gradedTestBindingSource.DataMember = "graded_tests";
            this.gradedTestBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // mathWizGroup3DataSet
            // 
            this.mathWizGroup3DataSet.DataSetName = "MathWizGroup3DataSet";
            this.mathWizGroup3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.FirstName,
            this.LastName,
            this.MasteryLevel});
            this.dgvStudents.DataSource = this.studentsBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(26, 103);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(405, 123);
            this.dgvStudents.TabIndex = 9;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 40;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
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
            // MasteryLevel
            // 
            this.MasteryLevel.DataPropertyName = "MasteryLevel";
            this.MasteryLevel.HeaderText = "MasteryLevel";
            this.MasteryLevel.Name = "MasteryLevel";
            this.MasteryLevel.ReadOnly = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.mathWizGroup3DataSet;
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
            this.randomlyGeneratedDataGridViewCheckBoxColumn,
            this.passThreshHoldDataGridViewTextBoxColumn,
            this.minLevelDataGridViewTextBoxColumn,
            this.maxLevelDataGridViewTextBoxColumn});
            this.dgvTests.DataSource = this.testsBindingSource;
            this.dgvTests.Location = new System.Drawing.Point(35, 54);
            this.dgvTests.MultiSelect = false;
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.RowHeadersVisible = false;
            this.dgvTests.Size = new System.Drawing.Size(604, 259);
            this.dgvTests.TabIndex = 8;
            this.dgvTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTests_CellContentClick);
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "tests";
            this.testsBindingSource.DataSource = this.mathWizGroup3DataSet;
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
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
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
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // gradedTestsTableAdapter
            // 
            this.gradedTestsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 24);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1290, 25);
            this.fillByToolStrip.TabIndex = 10;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.tabStudentTests);
            this.tabForm.Controls.Add(this.tabKlassTests);
            this.tabForm.Location = new System.Drawing.Point(12, 258);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(888, 364);
            this.tabForm.TabIndex = 11;
            this.tabForm.TabStop = false;
            this.tabForm.Visible = false;
            // 
            // tabStudentTests
            // 
            this.tabStudentTests.Controls.Add(this.dgvGradedTests);
            this.tabStudentTests.Location = new System.Drawing.Point(4, 22);
            this.tabStudentTests.Name = "tabStudentTests";
            this.tabStudentTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentTests.Size = new System.Drawing.Size(880, 338);
            this.tabStudentTests.TabIndex = 0;
            // 
            // tabKlassTests
            // 
            this.tabKlassTests.Controls.Add(this.dgvTests);
            this.tabKlassTests.Location = new System.Drawing.Point(4, 22);
            this.tabKlassTests.Name = "tabKlassTests";
            this.tabKlassTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabKlassTests.Size = new System.Drawing.Size(880, 338);
            this.tabKlassTests.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // testTypeDataGridViewTextBoxColumn
            // 
            this.testTypeDataGridViewTextBoxColumn.DataPropertyName = "TestType";
            this.testTypeDataGridViewTextBoxColumn.HeaderText = "Test Type";
            this.testTypeDataGridViewTextBoxColumn.Name = "testTypeDataGridViewTextBoxColumn";
            this.testTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeLimitDataGridViewTextBoxColumn
            // 
            this.timeLimitDataGridViewTextBoxColumn.DataPropertyName = "TimeLimit";
            this.timeLimitDataGridViewTextBoxColumn.HeaderText = "Time Limit";
            this.timeLimitDataGridViewTextBoxColumn.Name = "timeLimitDataGridViewTextBoxColumn";
            this.timeLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // randomlyGeneratedDataGridViewCheckBoxColumn
            // 
            this.randomlyGeneratedDataGridViewCheckBoxColumn.DataPropertyName = "RandomlyGenerated";
            this.randomlyGeneratedDataGridViewCheckBoxColumn.HeaderText = "Randomly Generated";
            this.randomlyGeneratedDataGridViewCheckBoxColumn.Name = "randomlyGeneratedDataGridViewCheckBoxColumn";
            this.randomlyGeneratedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // passThreshHoldDataGridViewTextBoxColumn
            // 
            this.passThreshHoldDataGridViewTextBoxColumn.DataPropertyName = "PassThreshHold";
            this.passThreshHoldDataGridViewTextBoxColumn.HeaderText = "Pass ThreshHold";
            this.passThreshHoldDataGridViewTextBoxColumn.Name = "passThreshHoldDataGridViewTextBoxColumn";
            this.passThreshHoldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minLevelDataGridViewTextBoxColumn
            // 
            this.minLevelDataGridViewTextBoxColumn.DataPropertyName = "MinLevel";
            this.minLevelDataGridViewTextBoxColumn.HeaderText = "Min Level";
            this.minLevelDataGridViewTextBoxColumn.Name = "minLevelDataGridViewTextBoxColumn";
            this.minLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxLevelDataGridViewTextBoxColumn
            // 
            this.maxLevelDataGridViewTextBoxColumn.DataPropertyName = "MaxLevel";
            this.maxLevelDataGridViewTextBoxColumn.HeaderText = "Max Level";
            this.maxLevelDataGridViewTextBoxColumn.Name = "maxLevelDataGridViewTextBoxColumn";
            this.maxLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmTeacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 670);
            this.Controls.Add(this.tabForm);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCreateTest);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.cmbKlasses);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeacherHome";
            this.Text = "MathWiz - Teacher Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeacherHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradedTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradedTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.tabForm.ResumeLayout(false);
            this.tabStudentTests.ResumeLayout(false);
            this.tabKlassTests.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCreateTest;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private MathWizGroup3DataSetTableAdapters.testsTableAdapter testsTableAdapter;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasteryLevel;
        private MathWizGroup3DataSetTableAdapters.graded_testsTableAdapter gradedTestsTableAdapter;
        private System.Windows.Forms.BindingSource gradedTestBindingSource;
        private System.Windows.Forms.DataGridView dgvGradedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradedTest_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradedTestStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradedTestTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradedTestScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradedTestTimeTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradedTestDateTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradedTestFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradedTestNumberAttempts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gradedTestPast;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendedLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tabStudentTests;
        private System.Windows.Forms.TabPage tabKlassTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn randomlyGeneratedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passThreshHoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLevelDataGridViewTextBoxColumn;
    }
}