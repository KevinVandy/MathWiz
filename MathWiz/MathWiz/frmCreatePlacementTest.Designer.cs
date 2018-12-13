namespace MathWiz
{
    partial class frmCreatePlacementTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatePlacementTest));
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboQuestionSpeed = new System.Windows.Forms.ComboBox();
            this.cboNumberOfQuestions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTest.Location = new System.Drawing.Point(281, 189);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(157, 52);
            this.btnCreateTest.TabIndex = 0;
            this.btnCreateTest.Text = "Cre&ate Test";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(70, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 52);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Question Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number of Questions";
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
            this.cboQuestionSpeed.Location = new System.Drawing.Point(281, 115);
            this.cboQuestionSpeed.Name = "cboQuestionSpeed";
            this.cboQuestionSpeed.Size = new System.Drawing.Size(121, 32);
            this.cboQuestionSpeed.TabIndex = 16;
            // 
            // cboNumberOfQuestions
            // 
            this.cboNumberOfQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumberOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumberOfQuestions.FormattingEnabled = true;
            this.cboNumberOfQuestions.Items.AddRange(new object[] {
            "24",
            "36",
            "48",
            "60"});
            this.cboNumberOfQuestions.Location = new System.Drawing.Point(281, 47);
            this.cboNumberOfQuestions.Name = "cboNumberOfQuestions";
            this.cboNumberOfQuestions.Size = new System.Drawing.Size(121, 32);
            this.cboNumberOfQuestions.TabIndex = 15;
            // 
            // frmCreatePlacementTest
            // 
            this.AcceptButton = this.btnCreateTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(508, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboQuestionSpeed);
            this.Controls.Add(this.cboNumberOfQuestions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreatePlacementTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Placement Test";
            this.Load += new System.EventHandler(this.frmCreatePlacementTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboQuestionSpeed;
        private System.Windows.Forms.ComboBox cboNumberOfQuestions;
    }
}