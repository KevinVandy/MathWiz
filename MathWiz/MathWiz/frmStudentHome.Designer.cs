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
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTakeMasteryTest = new System.Windows.Forms.Button();
            this.btnTakePracticeTest = new System.Windows.Forms.Button();
            this.btnTakePlacementTest = new System.Windows.Forms.Button();
            this.gbxTakeTests = new System.Windows.Forms.GroupBox();
            this.btnTakeRandomPracticeTest = new System.Windows.Forms.Button();
            this.cmbMasteryLevel = new System.Windows.Forms.ComboBox();
            this.gbxViewProgress = new System.Windows.Forms.GroupBox();
            this.backgroundWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMasteryLevel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbxTakeTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnTakeMasteryTest
            // 
            this.btnTakeMasteryTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeMasteryTest.Location = new System.Drawing.Point(28, 294);
            this.btnTakeMasteryTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeMasteryTest.Name = "btnTakeMasteryTest";
            this.btnTakeMasteryTest.Size = new System.Drawing.Size(317, 63);
            this.btnTakeMasteryTest.TabIndex = 3;
            this.btnTakeMasteryTest.Text = "Take Next Mastery Test";
            this.btnTakeMasteryTest.UseVisualStyleBackColor = true;
            this.btnTakeMasteryTest.Click += new System.EventHandler(this.btnTakeMasteryTest_Click);
            // 
            // btnTakePracticeTest
            // 
            this.btnTakePracticeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePracticeTest.Location = new System.Drawing.Point(28, 127);
            this.btnTakePracticeTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakePracticeTest.Name = "btnTakePracticeTest";
            this.btnTakePracticeTest.Size = new System.Drawing.Size(317, 63);
            this.btnTakePracticeTest.TabIndex = 4;
            this.btnTakePracticeTest.Text = "Take Teacher\'s Practice Test";
            this.btnTakePracticeTest.UseVisualStyleBackColor = true;
            this.btnTakePracticeTest.Click += new System.EventHandler(this.btnTakePracticeTest_Click);
            // 
            // btnTakePlacementTest
            // 
            this.btnTakePlacementTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePlacementTest.Location = new System.Drawing.Point(28, 44);
            this.btnTakePlacementTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakePlacementTest.Name = "btnTakePlacementTest";
            this.btnTakePlacementTest.Size = new System.Drawing.Size(317, 63);
            this.btnTakePlacementTest.TabIndex = 5;
            this.btnTakePlacementTest.Text = "Take Placement Test";
            this.btnTakePlacementTest.UseVisualStyleBackColor = true;
            this.btnTakePlacementTest.Click += new System.EventHandler(this.btnTakePlacementTest_Click);
            // 
            // gbxTakeTests
            // 
            this.gbxTakeTests.Controls.Add(this.btnTakeRandomPracticeTest);
            this.gbxTakeTests.Controls.Add(this.cmbMasteryLevel);
            this.gbxTakeTests.Controls.Add(this.btnTakeMasteryTest);
            this.gbxTakeTests.Controls.Add(this.btnTakePracticeTest);
            this.gbxTakeTests.Controls.Add(this.btnTakePlacementTest);
            this.gbxTakeTests.Location = new System.Drawing.Point(31, 106);
            this.gbxTakeTests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTakeTests.Name = "gbxTakeTests";
            this.gbxTakeTests.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTakeTests.Size = new System.Drawing.Size(947, 386);
            this.gbxTakeTests.TabIndex = 6;
            this.gbxTakeTests.TabStop = false;
            this.gbxTakeTests.Text = "Take Tests";
            // 
            // btnTakeRandomPracticeTest
            // 
            this.btnTakeRandomPracticeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeRandomPracticeTest.Location = new System.Drawing.Point(28, 210);
            this.btnTakeRandomPracticeTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeRandomPracticeTest.Name = "btnTakeRandomPracticeTest";
            this.btnTakeRandomPracticeTest.Size = new System.Drawing.Size(317, 63);
            this.btnTakeRandomPracticeTest.TabIndex = 7;
            this.btnTakeRandomPracticeTest.Text = "Take Random Practice Test";
            this.btnTakeRandomPracticeTest.UseVisualStyleBackColor = true;
            this.btnTakeRandomPracticeTest.Click += new System.EventHandler(this.btnTakeRandomPracticeTest_Click);
            // 
            // cmbMasteryLevel
            // 
            this.cmbMasteryLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMasteryLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMasteryLevel.FormattingEnabled = true;
            this.cmbMasteryLevel.Items.AddRange(new object[] {
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
            "12",
            "13"});
            this.cmbMasteryLevel.Location = new System.Drawing.Point(372, 220);
            this.cmbMasteryLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMasteryLevel.Name = "cmbMasteryLevel";
            this.cmbMasteryLevel.Size = new System.Drawing.Size(119, 39);
            this.cmbMasteryLevel.TabIndex = 6;
            // 
            // gbxViewProgress
            // 
            this.gbxViewProgress.Location = new System.Drawing.Point(31, 539);
            this.gbxViewProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxViewProgress.Name = "gbxViewProgress";
            this.gbxViewProgress.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxViewProgress.Size = new System.Drawing.Size(947, 204);
            this.gbxViewProgress.TabIndex = 7;
            this.gbxViewProgress.TabStop = false;
            this.gbxViewProgress.Text = "View Progress";
            // 
            // backgroundWorkerLoadData
            // 
            this.backgroundWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadData_DoWork);
            this.backgroundWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadData_RunWorkerCompleted);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(24, 49);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(296, 31);
            this.lblStudentName.TabIndex = 7;
            this.lblStudentName.Text = "Student: Student Name";
            // 
            // lblMasteryLevel
            // 
            this.lblMasteryLevel.AutoSize = true;
            this.lblMasteryLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasteryLevel.Location = new System.Drawing.Point(695, 49);
            this.lblMasteryLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasteryLevel.Name = "lblMasteryLevel";
            this.lblMasteryLevel.Size = new System.Drawing.Size(228, 31);
            this.lblMasteryLevel.TabIndex = 8;
            this.lblMasteryLevel.Text = "Mastery Level: 00";
            // 
            // frmStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1041, 677);
            this.Controls.Add(this.lblMasteryLevel);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.gbxViewProgress);
            this.Controls.Add(this.gbxTakeTests);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnTakeMasteryTest;
        private System.Windows.Forms.Button btnTakePracticeTest;
        private System.Windows.Forms.Button btnTakePlacementTest;
        private System.Windows.Forms.GroupBox gbxTakeTests;
        private System.Windows.Forms.GroupBox gbxViewProgress;
        private System.Windows.Forms.ComboBox cmbMasteryLevel;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblMasteryLevel;
        private System.Windows.Forms.Button btnTakeRandomPracticeTest;
    }
}