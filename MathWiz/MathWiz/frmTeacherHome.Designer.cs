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
            this.picBoxTeacher = new System.Windows.Forms.PictureBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlasses = new System.Windows.Forms.ComboBox();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masteryLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizGroup3DataSet = new MathWiz.MathWizGroup3DataSet();
            this.studentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.studentsTableAdapter();
            this.btnTest = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxTeacher
            // 
            this.picBoxTeacher.BackgroundImage = global::MathWiz.Properties.Resources.teacher;
            this.picBoxTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxTeacher.InitialImage = null;
            this.picBoxTeacher.Location = new System.Drawing.Point(31, 57);
            this.picBoxTeacher.Name = "picBoxTeacher";
            this.picBoxTeacher.Size = new System.Drawing.Size(160, 191);
            this.picBoxTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxTeacher.TabIndex = 0;
            this.picBoxTeacher.TabStop = false;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.Blue;
            this.lblTeacherName.Location = new System.Drawing.Point(88, 251);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(64, 22);
            this.lblTeacherName.TabIndex = 1;
            this.lblTeacherName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(55, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Classes";
            // 
            // cmbKlasses
            // 
            this.cmbKlasses.FormattingEnabled = true;
            this.cmbKlasses.Location = new System.Drawing.Point(51, 346);
            this.cmbKlasses.Name = "cmbKlasses";
            this.cmbKlasses.Size = new System.Drawing.Size(121, 21);
            this.cmbKlasses.TabIndex = 5;
            this.cmbKlasses.SelectedIndexChanged += new System.EventHandler(this.cmbKlasses_SelectedIndexChanged);
            // 
            // studentTable
            // 
            this.studentTable.AllowUserToAddRows = false;
            this.studentTable.AllowUserToDeleteRows = false;
            this.studentTable.AllowUserToResizeColumns = false;
            this.studentTable.AllowUserToResizeRows = false;
            this.studentTable.AutoGenerateColumns = false;
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.Id,
            this.ParentID,
            this.KlassID,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.masteryLevelDataGridViewTextBoxColumn});
            this.studentTable.DataSource = this.studentsBindingSource;
            this.studentTable.Location = new System.Drawing.Point(225, 12);
            this.studentTable.MultiSelect = false;
            this.studentTable.Name = "studentTable";
            this.studentTable.Size = new System.Drawing.Size(443, 236);
            this.studentTable.TabIndex = 6;
            this.studentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTable_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ParentID
            // 
            this.ParentID.DataPropertyName = "ParentID";
            this.ParentID.HeaderText = "ParentID";
            this.ParentID.Name = "ParentID";
            this.ParentID.ReadOnly = true;
            this.ParentID.Visible = false;
            // 
            // KlassID
            // 
            this.KlassID.DataPropertyName = "KlassID";
            this.KlassID.HeaderText = "KlassID";
            this.KlassID.Name = "KlassID";
            this.KlassID.ReadOnly = true;
            this.KlassID.Visible = false;
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
            // masteryLevelDataGridViewTextBoxColumn
            // 
            this.masteryLevelDataGridViewTextBoxColumn.DataPropertyName = "MasteryLevel";
            this.masteryLevelDataGridViewTextBoxColumn.HeaderText = "MasteryLevel";
            this.masteryLevelDataGridViewTextBoxColumn.Name = "masteryLevelDataGridViewTextBoxColumn";
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
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(683, 28);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(116, 36);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmTeacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MathWiz.Properties.Resources.numbers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.studentTable);
            this.Controls.Add(this.cmbKlasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.picBoxTeacher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeacherHome";
            this.Text = "MathWiz - Teacher Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeacherHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxTeacher;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKlasses;
        private System.Windows.Forms.DataGridView studentTable;
        private MathWizGroup3DataSet mathWizGroup3DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masteryLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}