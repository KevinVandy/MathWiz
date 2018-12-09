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
            this.txtStudentMastery = new System.Windows.Forms.TextBox();
            this.lblStudentMastery = new System.Windows.Forms.Label();
            this.graded_testsDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graded_testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizGroup3DataSet = new MathWiz.MathWizGroup3DataSet();
            this.lstChildren = new System.Windows.Forms.ListBox();
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
            this.grpManageChildren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpManageChildren
            // 
            this.grpManageChildren.Controls.Add(this.txtStudentMastery);
            this.grpManageChildren.Controls.Add(this.lblStudentMastery);
            this.grpManageChildren.Controls.Add(this.graded_testsDataGridView);
            this.grpManageChildren.Controls.Add(this.lstChildren);
            this.grpManageChildren.Location = new System.Drawing.Point(9, 32);
            this.grpManageChildren.Margin = new System.Windows.Forms.Padding(2);
            this.grpManageChildren.Name = "grpManageChildren";
            this.grpManageChildren.Padding = new System.Windows.Forms.Padding(2);
            this.grpManageChildren.Size = new System.Drawing.Size(850, 344);
            this.grpManageChildren.TabIndex = 0;
            this.grpManageChildren.TabStop = false;
            this.grpManageChildren.Text = "Your Children";
            // 
            // txtStudentMastery
            // 
            this.txtStudentMastery.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentMastery.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentMastery.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStudentMastery.Location = new System.Drawing.Point(242, 35);
            this.txtStudentMastery.Multiline = true;
            this.txtStudentMastery.Name = "txtStudentMastery";
            this.txtStudentMastery.ReadOnly = true;
            this.txtStudentMastery.Size = new System.Drawing.Size(117, 55);
            this.txtStudentMastery.TabIndex = 3;
            this.txtStudentMastery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStudentMastery
            // 
            this.lblStudentMastery.AutoSize = true;
            this.lblStudentMastery.Location = new System.Drawing.Point(239, 19);
            this.lblStudentMastery.Name = "lblStudentMastery";
            this.lblStudentMastery.Size = new System.Drawing.Size(120, 13);
            this.lblStudentMastery.TabIndex = 2;
            this.lblStudentMastery.Text = "Student\'s Mastery Level";
            // 
            // graded_testsDataGridView
            // 
            this.graded_testsDataGridView.AllowUserToAddRows = false;
            this.graded_testsDataGridView.AllowUserToDeleteRows = false;
            this.graded_testsDataGridView.AutoGenerateColumns = false;
            this.graded_testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graded_testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.graded_testsDataGridView.DataSource = this.graded_testsBindingSource;
            this.graded_testsDataGridView.Location = new System.Drawing.Point(364, 35);
            this.graded_testsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.graded_testsDataGridView.Name = "graded_testsDataGridView";
            this.graded_testsDataGridView.ReadOnly = true;
            this.graded_testsDataGridView.RowTemplate.Height = 24;
            this.graded_testsDataGridView.Size = new System.Drawing.Size(470, 263);
            this.graded_testsDataGridView.TabIndex = 1;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Visible = false;
            this.StudentID.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TestID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TestID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn4.HeaderText = "Score";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Passed";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Passed";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Feedback";
            this.dataGridViewTextBoxColumn7.HeaderText = "Feedback";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // graded_testsBindingSource
            // 
            this.graded_testsBindingSource.DataMember = "graded_tests";
            this.graded_testsBindingSource.DataSource = this.mathWizGroup3DataSet;
            // 
            // mathWizGroup3DataSet
            // 
            this.mathWizGroup3DataSet.DataSetName = "MathWizGroup3DataSet";
            this.mathWizGroup3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstChildren
            // 
            this.lstChildren.FormattingEnabled = true;
            this.lstChildren.Location = new System.Drawing.Point(11, 34);
            this.lstChildren.Name = "lstChildren";
            this.lstChildren.Size = new System.Drawing.Size(214, 264);
            this.lstChildren.TabIndex = 0;
            this.lstChildren.SelectedIndexChanged += new System.EventHandler(this.lstChildren_SelectedIndexChanged);
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
            // frmParentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.lblParentName);
            this.Controls.Add(this.grpManageChildren);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmParentHome";
            this.Text = "MathWiz - Parent Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmParentHome_Load);
            this.grpManageChildren.ResumeLayout(false);
            this.grpManageChildren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).EndInit();
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
        private System.Windows.Forms.ListBox lstChildren;
        private MathWizGroup3DataSet mathWizGroup3DataSet;
        private System.Windows.Forms.BindingSource graded_testsBindingSource;
        private MathWizGroup3DataSetTableAdapters.graded_testsTableAdapter graded_testsTableAdapter;
        private MathWizGroup3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView graded_testsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtStudentMastery;
        private System.Windows.Forms.Label lblStudentMastery;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblParentName;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
    }
}