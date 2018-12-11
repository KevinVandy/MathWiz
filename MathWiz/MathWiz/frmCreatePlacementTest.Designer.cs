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
            this.label2 = new System.Windows.Forms.Label();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTest.Location = new System.Drawing.Point(259, 123);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(157, 52);
            this.btnCreateTest.TabIndex = 0;
            this.btnCreateTest.Text = "Cre&ate Test";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Limit (hh:mm:ss)";
            // 
            // mskTime
            // 
            this.mskTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTime.Location = new System.Drawing.Point(241, 32);
            this.mskTime.Mask = "00:00:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(176, 29);
            this.mskTime.TabIndex = 9;
            this.mskTime.Tag = "Time Limit";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(48, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 52);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreatePlacementTest
            // 
            this.AcceptButton = this.btnCreateTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 214);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.mskTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreatePlacementTest";
            this.Text = "Create Placement Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTime;
        private System.Windows.Forms.Button btnCancel;
    }
}