namespace MathWiz
{
    partial class frmParentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParentHome));
            this.grpManageChildren = new System.Windows.Forms.GroupBox();
            this.lsvStudentGrades = new System.Windows.Forms.ListView();
            this.gradedTestId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestDateTaken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestTimeTakenToComplete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradedTestFeedback = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizGroup3DataSet = new MathWiz.MathWizGroup3DataSet();
            this.graded_testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graded_testsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.graded_testsTableAdapter();
            this.tableAdapterManager = new MathWiz.MathWizGroup3DataSetTableAdapters.TableAdapterManager();
            this.lblParentName = new System.Windows.Forms.Label();
            this.backgroundWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChildren = new System.Windows.Forms.ComboBox();
            this.studentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.studentsTableAdapter();
            this.grpManageChildren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpManageChildren
            // 
            this.grpManageChildren.Controls.Add(this.lsvStudentGrades);
            this.grpManageChildren.Controls.Add(this.dgvStudents);
            this.grpManageChildren.Location = new System.Drawing.Point(9, 95);
            this.grpManageChildren.Margin = new System.Windows.Forms.Padding(2);
            this.grpManageChildren.Name = "grpManageChildren";
            this.grpManageChildren.Padding = new System.Windows.Forms.Padding(2);
            this.grpManageChildren.Size = new System.Drawing.Size(854, 302);
            this.grpManageChildren.TabIndex = 0;
            this.grpManageChildren.TabStop = false;
            this.grpManageChildren.Text = "Your Child\'s Info";
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
            this.lsvStudentGrades.Location = new System.Drawing.Point(9, 101);
            this.lsvStudentGrades.MultiSelect = false;
            this.lsvStudentGrades.Name = "lsvStudentGrades";
            this.lsvStudentGrades.Size = new System.Drawing.Size(704, 157);
            this.lsvStudentGrades.TabIndex = 15;
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
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11});
            this.dgvStudents.DataSource = this.studentsBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(9, 18);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(495, 58);
            this.dgvStudents.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "KlassID";
            this.dataGridViewTextBoxColumn5.HeaderText = "KlassID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn6.HeaderText = "Username";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn8.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MasteryLevel";
            this.dataGridViewTextBoxColumn11.HeaderText = "Mastery Level";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 50;
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
            // graded_testsBindingSource
            // 
            this.graded_testsBindingSource.DataMember = "graded_tests";
            this.graded_testsBindingSource.DataSource = this.mathWizGroup3DataSet;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
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
            // graded_testsTableAdapter
            // 
            this.graded_testsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.graded_questionsTableAdapter = null;
            this.tableAdapterManager.graded_testsTableAdapter = this.graded_testsTableAdapter;
            this.tableAdapterManager.klassesTableAdapter = null;
            this.tableAdapterManager.parentsTableAdapter = null;
            this.tableAdapterManager.questionsTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.testsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MathWiz.MathWizGroup3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentName.ForeColor = System.Drawing.Color.Blue;
            this.lblParentName.Location = new System.Drawing.Point(129, 7);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(71, 13);
            this.lblParentName.TabIndex = 2;
            this.lblParentName.Text = "Logged in as:";
            // 
            // backgroundWorkerLoadData
            // 
            this.backgroundWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadData_DoWork);
            this.backgroundWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadData_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Child:";
            // 
            // cmbChildren
            // 
            this.cmbChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChildren.FormattingEnabled = true;
            this.cmbChildren.Location = new System.Drawing.Point(185, 36);
            this.cmbChildren.Name = "cmbChildren";
            this.cmbChildren.Size = new System.Drawing.Size(314, 39);
            this.cmbChildren.TabIndex = 6;
            this.cmbChildren.SelectedIndexChanged += new System.EventHandler(this.cmbChildren_SelectedIndexChanged_1);
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmParentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 431);
            this.Controls.Add(this.cmbChildren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParentName);
            this.Controls.Add(this.grpManageChildren);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(360, 360);
            this.Name = "frmParentHome";
            this.Text = "MathWiz - Parent Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmParentHome_Load);
            this.grpManageChildren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpManageChildren;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MathWizGroup3DataSet mathWizGroup3DataSet;
        private System.Windows.Forms.BindingSource graded_testsBindingSource;
        private MathWizGroup3DataSetTableAdapters.graded_testsTableAdapter graded_testsTableAdapter;
        private MathWizGroup3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblParentName;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChildren;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ListView lsvStudentGrades;
        private System.Windows.Forms.ColumnHeader gradedTestId;
        private System.Windows.Forms.ColumnHeader gradedTestType;
        private System.Windows.Forms.ColumnHeader gradedTestDateTaken;
        private System.Windows.Forms.ColumnHeader gradedTestTimeTakenToComplete;
        private System.Windows.Forms.ColumnHeader gradedTestScore;
        private System.Windows.Forms.ColumnHeader gradedTestFeedback;
    }
}