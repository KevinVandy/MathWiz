namespace MathWiz
{
    partial class frmStudentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMastery = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnPlacement = new System.Windows.Forms.Button();
            this.gbxTakeTests = new System.Windows.Forms.GroupBox();
            this.gbxViewProgress = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.gbxTakeTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem2.Text = "Edit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnMastery
            // 
            this.btnMastery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMastery.Location = new System.Drawing.Point(477, 37);
            this.btnMastery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMastery.Name = "btnMastery";
            this.btnMastery.Size = new System.Drawing.Size(204, 51);
            this.btnMastery.TabIndex = 3;
            this.btnMastery.Text = "Take Next Mastery Test";
            this.btnMastery.UseVisualStyleBackColor = true;
            this.btnMastery.Click += new System.EventHandler(this.btnMastery_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.Location = new System.Drawing.Point(250, 36);
            this.btnPractice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(204, 51);
            this.btnPractice.TabIndex = 4;
            this.btnPractice.Text = "Take Practice Test";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnPlacement
            // 
            this.btnPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlacement.Location = new System.Drawing.Point(23, 37);
            this.btnPlacement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlacement.Name = "btnPlacement";
            this.btnPlacement.Size = new System.Drawing.Size(204, 51);
            this.btnPlacement.TabIndex = 5;
            this.btnPlacement.Text = "Take Placement Test";
            this.btnPlacement.UseVisualStyleBackColor = true;
            this.btnPlacement.Click += new System.EventHandler(this.btnPlacement_Click);
            // 
            // gbxTakeTests
            // 
            this.gbxTakeTests.Controls.Add(this.btnMastery);
            this.gbxTakeTests.Controls.Add(this.btnPractice);
            this.gbxTakeTests.Controls.Add(this.btnPlacement);
            this.gbxTakeTests.Location = new System.Drawing.Point(23, 40);
            this.gbxTakeTests.Name = "gbxTakeTests";
            this.gbxTakeTests.Size = new System.Drawing.Size(710, 116);
            this.gbxTakeTests.TabIndex = 6;
            this.gbxTakeTests.TabStop = false;
            this.gbxTakeTests.Text = "Take Tests";
            // 
            // gbxViewProgress
            // 
            this.gbxViewProgress.Location = new System.Drawing.Point(23, 188);
            this.gbxViewProgress.Name = "gbxViewProgress";
            this.gbxViewProgress.Size = new System.Drawing.Size(710, 116);
            this.gbxViewProgress.TabIndex = 7;
            this.gbxViewProgress.TabStop = false;
            this.gbxViewProgress.Text = "View Progress";
            // 
            // frmStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 550);
            this.Controls.Add(this.gbxViewProgress);
            this.Controls.Add(this.gbxTakeTests);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudentHome";
            this.Text = "MathWiz - Student Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudentHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxTakeTests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnMastery;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnPlacement;
        private System.Windows.Forms.GroupBox gbxTakeTests;
        private System.Windows.Forms.GroupBox gbxViewProgress;
    }
}