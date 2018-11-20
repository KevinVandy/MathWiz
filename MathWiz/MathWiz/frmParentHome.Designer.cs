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
            this.lstChildren = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathWizGroup3DataSet = new MathWiz.MathWizGroup3DataSet();
            this.graded_testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graded_testsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.graded_testsTableAdapter();
            this.tableAdapterManager = new MathWiz.MathWizGroup3DataSetTableAdapters.TableAdapterManager();
            this.graded_testsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpManageChildren.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpManageChildren
            // 
            this.grpManageChildren.Controls.Add(this.graded_testsDataGridView);
            this.grpManageChildren.Controls.Add(this.lstChildren);
            this.grpManageChildren.Location = new System.Drawing.Point(12, 39);
            this.grpManageChildren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpManageChildren.Name = "grpManageChildren";
            this.grpManageChildren.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpManageChildren.Size = new System.Drawing.Size(1043, 366);
            this.grpManageChildren.TabIndex = 0;
            this.grpManageChildren.TabStop = false;
            this.grpManageChildren.Text = "Your Children";
            // 
            // lstChildren
            // 
            this.lstChildren.FormattingEnabled = true;
            this.lstChildren.ItemHeight = 16;
            this.lstChildren.Location = new System.Drawing.Point(7, 22);
            this.lstChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstChildren.Name = "lstChildren";
            this.lstChildren.Size = new System.Drawing.Size(284, 324);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // graded_testsDataGridView
            // 
            this.graded_testsDataGridView.AllowUserToAddRows = false;
            this.graded_testsDataGridView.AllowUserToDeleteRows = false;
            this.graded_testsDataGridView.AutoGenerateColumns = false;
            this.graded_testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graded_testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.graded_testsDataGridView.DataSource = this.graded_testsBindingSource;
            this.graded_testsDataGridView.Location = new System.Drawing.Point(367, 22);
            this.graded_testsDataGridView.Name = "graded_testsDataGridView";
            this.graded_testsDataGridView.ReadOnly = true;
            this.graded_testsDataGridView.RowTemplate.Height = 24;
            this.graded_testsDataGridView.Size = new System.Drawing.Size(560, 324);
            this.graded_testsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TestID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TestID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn4.HeaderText = "Score";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Passed";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Passed";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Feedback";
            this.dataGridViewTextBoxColumn7.HeaderText = "Feedback";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // frmParentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpManageChildren);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmParentHome";
            this.Text = "MathWiz - Parent Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParentHome_FormClosing);
            this.Load += new System.EventHandler(this.frmParentHome_Load);
            this.grpManageChildren.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graded_testsDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}