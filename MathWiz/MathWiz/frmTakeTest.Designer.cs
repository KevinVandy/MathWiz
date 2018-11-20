namespace MathWiz
{
    partial class frmTakeTest
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
            this.backgroundWorkerLoadTest = new System.ComponentModel.BackgroundWorker();
            this.gbxQuestion = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.pnlChoices = new System.Windows.Forms.Panel();
            this.rdoChoice1 = new System.Windows.Forms.RadioButton();
            this.rdoChoice2 = new System.Windows.Forms.RadioButton();
            this.rdoChoice3 = new System.Windows.Forms.RadioButton();
            this.rdoChoice4 = new System.Windows.Forms.RadioButton();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.txtStudentAnswer = new System.Windows.Forms.TextBox();
            this.gbxQuestion.SuspendLayout();
            this.pnlChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorkerLoadTest
            // 
            this.backgroundWorkerLoadTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadTest_DoWork);
            this.backgroundWorkerLoadTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadTest_RunWorkerCompleted);
            // 
            // gbxQuestion
            // 
            this.gbxQuestion.Controls.Add(this.lblCorrectAnswer);
            this.gbxQuestion.Controls.Add(this.txtStudentAnswer);
            this.gbxQuestion.Controls.Add(this.pnlChoices);
            this.gbxQuestion.Controls.Add(this.lblQuestionText);
            this.gbxQuestion.Controls.Add(this.btnNext);
            this.gbxQuestion.Controls.Add(this.btnBack);
            this.gbxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxQuestion.Location = new System.Drawing.Point(38, 36);
            this.gbxQuestion.Name = "gbxQuestion";
            this.gbxQuestion.Size = new System.Drawing.Size(449, 285);
            this.gbxQuestion.TabIndex = 0;
            this.gbxQuestion.TabStop = false;
            this.gbxQuestion.Text = "Question # of #";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(251, 231);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 37);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(25, 231);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 37);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Previous Question";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(63, 342);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 37);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start test";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(18, 31);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(144, 37);
            this.lblQuestionText.TabIndex = 3;
            this.lblQuestionText.Text = "2 + 2 = ?";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(289, 342);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(167, 37);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish Test";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnlChoices
            // 
            this.pnlChoices.Controls.Add(this.rdoChoice4);
            this.pnlChoices.Controls.Add(this.rdoChoice3);
            this.pnlChoices.Controls.Add(this.rdoChoice2);
            this.pnlChoices.Controls.Add(this.rdoChoice1);
            this.pnlChoices.Location = new System.Drawing.Point(25, 84);
            this.pnlChoices.Name = "pnlChoices";
            this.pnlChoices.Size = new System.Drawing.Size(393, 130);
            this.pnlChoices.TabIndex = 4;
            // 
            // rdoChoice1
            // 
            this.rdoChoice1.AutoSize = true;
            this.rdoChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice1.Location = new System.Drawing.Point(19, 23);
            this.rdoChoice1.Name = "rdoChoice1";
            this.rdoChoice1.Size = new System.Drawing.Size(42, 30);
            this.rdoChoice1.TabIndex = 0;
            this.rdoChoice1.TabStop = true;
            this.rdoChoice1.Text = "1";
            this.rdoChoice1.UseVisualStyleBackColor = true;
            // 
            // rdoChoice2
            // 
            this.rdoChoice2.AutoSize = true;
            this.rdoChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice2.Location = new System.Drawing.Point(19, 70);
            this.rdoChoice2.Name = "rdoChoice2";
            this.rdoChoice2.Size = new System.Drawing.Size(42, 30);
            this.rdoChoice2.TabIndex = 1;
            this.rdoChoice2.TabStop = true;
            this.rdoChoice2.Text = "2";
            this.rdoChoice2.UseVisualStyleBackColor = true;
            // 
            // rdoChoice3
            // 
            this.rdoChoice3.AutoSize = true;
            this.rdoChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice3.Location = new System.Drawing.Point(245, 23);
            this.rdoChoice3.Name = "rdoChoice3";
            this.rdoChoice3.Size = new System.Drawing.Size(42, 30);
            this.rdoChoice3.TabIndex = 2;
            this.rdoChoice3.TabStop = true;
            this.rdoChoice3.Text = "3";
            this.rdoChoice3.UseVisualStyleBackColor = true;
            // 
            // rdoChoice4
            // 
            this.rdoChoice4.AutoSize = true;
            this.rdoChoice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice4.Location = new System.Drawing.Point(245, 70);
            this.rdoChoice4.Name = "rdoChoice4";
            this.rdoChoice4.Size = new System.Drawing.Size(42, 30);
            this.rdoChoice4.TabIndex = 3;
            this.rdoChoice4.TabStop = true;
            this.rdoChoice4.Text = "4";
            this.rdoChoice4.UseVisualStyleBackColor = true;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.Green;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(355, 31);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(35, 37);
            this.lblCorrectAnswer.TabIndex = 5;
            this.lblCorrectAnswer.Text = "4";
            this.lblCorrectAnswer.Visible = false;
            // 
            // txtStudentAnswer
            // 
            this.txtStudentAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentAnswer.Location = new System.Drawing.Point(213, 27);
            this.txtStudentAnswer.MaxLength = 6;
            this.txtStudentAnswer.Name = "txtStudentAnswer";
            this.txtStudentAnswer.Size = new System.Drawing.Size(136, 44);
            this.txtStudentAnswer.TabIndex = 0;
            this.txtStudentAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 422);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbxQuestion);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.gbxQuestion.ResumeLayout(false);
            this.gbxQuestion.PerformLayout();
            this.pnlChoices.ResumeLayout(false);
            this.pnlChoices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadTest;
        private System.Windows.Forms.GroupBox gbxQuestion;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel pnlChoices;
        private System.Windows.Forms.RadioButton rdoChoice4;
        private System.Windows.Forms.RadioButton rdoChoice3;
        private System.Windows.Forms.RadioButton rdoChoice2;
        private System.Windows.Forms.RadioButton rdoChoice1;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.TextBox txtStudentAnswer;
    }
}