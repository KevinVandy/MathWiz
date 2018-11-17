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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherHome));
            this.picBoxTeacher = new System.Windows.Forms.PictureBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lstBoxKlass = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxStudents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxTeacher
            // 
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
            // lstBoxKlass
            // 
            this.lstBoxKlass.FormattingEnabled = true;
            this.lstBoxKlass.Location = new System.Drawing.Point(52, 346);
            this.lstBoxKlass.Name = "lstBoxKlass";
            this.lstBoxKlass.Size = new System.Drawing.Size(120, 69);
            this.lstBoxKlass.TabIndex = 2;
            this.lstBoxKlass.SelectedIndexChanged += new System.EventHandler(this.lstBoxKlass_SelectedIndexChanged);
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
            // lstBoxStudents
            // 
            this.lstBoxStudents.FormattingEnabled = true;
            this.lstBoxStudents.Location = new System.Drawing.Point(387, 157);
            this.lstBoxStudents.Name = "lstBoxStudents";
            this.lstBoxStudents.Size = new System.Drawing.Size(120, 95);
            this.lstBoxStudents.TabIndex = 4;
            // 
            // frmTeacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MathWiz.Properties.Resources.numbers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxKlass);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.picBoxTeacher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeacherHome";
            this.Text = "MathWiz - Teacher Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeacherHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxTeacher;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.ListBox lstBoxKlass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxStudents;
    }
}