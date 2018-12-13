namespace MathWiz
{
    partial class frmGenerateMasteryTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateMasteryTests));
            this.btnGenerateTests = new System.Windows.Forms.Button();
            this.cboNumberOfQuestions = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboQuestionSpeed = new System.Windows.Forms.ComboBox();
            this.cboPassThreshhold = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateTests
            // 
            this.btnGenerateTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTests.Location = new System.Drawing.Point(258, 274);
            this.btnGenerateTests.Name = "btnGenerateTests";
            this.btnGenerateTests.Size = new System.Drawing.Size(226, 49);
            this.btnGenerateTests.TabIndex = 0;
            this.btnGenerateTests.Text = "Generate Tests";
            this.btnGenerateTests.UseVisualStyleBackColor = true;
            this.btnGenerateTests.Click += new System.EventHandler(this.btnGenerateTests_Click);
            // 
            // cboNumberOfQuestions
            // 
            this.cboNumberOfQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumberOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumberOfQuestions.FormattingEnabled = true;
            this.cboNumberOfQuestions.Items.AddRange(new object[] {
            "10",
            "20",
            "25",
            "50"});
            this.cboNumberOfQuestions.Location = new System.Drawing.Point(309, 52);
            this.cboNumberOfQuestions.Name = "cboNumberOfQuestions";
            this.cboNumberOfQuestions.Size = new System.Drawing.Size(121, 32);
            this.cboNumberOfQuestions.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(30, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 49);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboQuestionSpeed
            // 
            this.cboQuestionSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuestionSpeed.FormattingEnabled = true;
            this.cboQuestionSpeed.Items.AddRange(new object[] {
            "Slow",
            "Medium",
            "Fast"});
            this.cboQuestionSpeed.Location = new System.Drawing.Point(309, 120);
            this.cboQuestionSpeed.Name = "cboQuestionSpeed";
            this.cboQuestionSpeed.Size = new System.Drawing.Size(121, 32);
            this.cboQuestionSpeed.TabIndex = 3;
            // 
            // cboPassThreshhold
            // 
            this.cboPassThreshhold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPassThreshhold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPassThreshhold.FormattingEnabled = true;
            this.cboPassThreshhold.Items.AddRange(new object[] {
            "70%",
            "80%",
            "90%",
            "95%",
            "100%"});
            this.cboPassThreshhold.Location = new System.Drawing.Point(309, 188);
            this.cboPassThreshhold.Name = "cboPassThreshhold";
            this.cboPassThreshhold.Size = new System.Drawing.Size(121, 32);
            this.cboPassThreshhold.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Questions Per Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pass Threshhold";
            // 
            // frmGenerateMasteryTests
            // 
            this.AcceptButton = this.btnGenerateTests;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(526, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPassThreshhold);
            this.Controls.Add(this.cboQuestionSpeed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboNumberOfQuestions);
            this.Controls.Add(this.btnGenerateTests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerateMasteryTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Mastery Tests";
            this.Load += new System.EventHandler(this.frmGenerateMasteryTests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateTests;
        private System.Windows.Forms.ComboBox cboNumberOfQuestions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboQuestionSpeed;
        private System.Windows.Forms.ComboBox cboPassThreshhold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}