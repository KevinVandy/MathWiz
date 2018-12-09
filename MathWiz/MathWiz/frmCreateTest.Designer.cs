namespace MathWiz
{
    partial class frmCreateTest
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
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaxMaster = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.mskThreshold = new System.Windows.Forms.MaskedTextBox();
            this.cboMinimum = new System.Windows.Forms.ComboBox();
            this.cboMaximum = new System.Windows.Forms.ComboBox();
            this.cboRandom = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTest.Location = new System.Drawing.Point(260, 356);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(157, 52);
            this.btnCreateTest.TabIndex = 0;
            this.btnCreateTest.Text = "Cre&ate Test";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Practice Test",
            "Placement Test",
            "Mastery Test"});
            this.cboType.Location = new System.Drawing.Point(241, 33);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(176, 32);
            this.cboType.TabIndex = 1;
            this.cboType.Tag = "Test Type";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Limit (hh:mm:ss)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pass Threshold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minimum Level:";
            // 
            // lblMaxMaster
            // 
            this.lblMaxMaster.AutoSize = true;
            this.lblMaxMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxMaster.Location = new System.Drawing.Point(78, 226);
            this.lblMaxMaster.Name = "lblMaxMaster";
            this.lblMaxMaster.Size = new System.Drawing.Size(143, 24);
            this.lblMaxMaster.TabIndex = 6;
            this.lblMaxMaster.Text = "Maximum Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Randomly Generated?";
            // 
            // mskTime
            // 
            this.mskTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTime.Location = new System.Drawing.Point(241, 82);
            this.mskTime.Mask = "00:00:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(176, 29);
            this.mskTime.TabIndex = 9;
            this.mskTime.Tag = "Time Limit";
            // 
            // mskThreshold
            // 
            this.mskThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskThreshold.Location = new System.Drawing.Point(241, 126);
            this.mskThreshold.Mask = "00.000000";
            this.mskThreshold.Name = "mskThreshold";
            this.mskThreshold.Size = new System.Drawing.Size(176, 29);
            this.mskThreshold.TabIndex = 10;
            this.mskThreshold.Tag = "Pass Threshold";
            // 
            // cboMinimum
            // 
            this.cboMinimum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMinimum.FormattingEnabled = true;
            this.cboMinimum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMinimum.Location = new System.Drawing.Point(241, 174);
            this.cboMinimum.Name = "cboMinimum";
            this.cboMinimum.Size = new System.Drawing.Size(176, 32);
            this.cboMinimum.TabIndex = 11;
            this.cboMinimum.Tag = "Minimum Level";
            // 
            // cboMaximum
            // 
            this.cboMaximum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaximum.FormattingEnabled = true;
            this.cboMaximum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMaximum.Location = new System.Drawing.Point(241, 223);
            this.cboMaximum.Name = "cboMaximum";
            this.cboMaximum.Size = new System.Drawing.Size(176, 32);
            this.cboMaximum.TabIndex = 12;
            this.cboMaximum.Tag = "Maximum Level";
            // 
            // cboRandom
            // 
            this.cboRandom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRandom.FormattingEnabled = true;
            this.cboRandom.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboRandom.Location = new System.Drawing.Point(241, 281);
            this.cboRandom.Name = "cboRandom";
            this.cboRandom.Size = new System.Drawing.Size(176, 32);
            this.cboRandom.TabIndex = 13;
            this.cboRandom.Tag = "Ranodmly Generated";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(57, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 52);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateTest
            // 
            this.AcceptButton = this.btnCreateTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 468);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboRandom);
            this.Controls.Add(this.cboMaximum);
            this.Controls.Add(this.cboMinimum);
            this.Controls.Add(this.mskThreshold);
            this.Controls.Add(this.mskTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMaxMaster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnCreateTest);
            this.Name = "frmCreateTest";
            this.Text = "Create New Test";
            this.Load += new System.EventHandler(this.frmCreateTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaxMaster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTime;
        private System.Windows.Forms.MaskedTextBox mskThreshold;
        private System.Windows.Forms.ComboBox cboMinimum;
        private System.Windows.Forms.ComboBox cboMaximum;
        private System.Windows.Forms.ComboBox cboRandom;
        private System.Windows.Forms.Button btnCancel;
    }
}