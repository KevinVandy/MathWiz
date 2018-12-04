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
            this.btnTakePlacementTest = new System.Windows.Forms.Button();
            this.gbxTakeTests = new System.Windows.Forms.GroupBox();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.lblMasteryLevels = new System.Windows.Forms.Label();
            this.cmbNumberOfQuestions = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
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
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnTakeMasteryTest
            // 
            this.btnTakeMasteryTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeMasteryTest.Location = new System.Drawing.Point(21, 176);
            this.btnTakeMasteryTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakeMasteryTest.Name = "btnTakeMasteryTest";
            this.btnTakeMasteryTest.Size = new System.Drawing.Size(238, 51);
            this.btnTakeMasteryTest.TabIndex = 3;
            this.btnTakeMasteryTest.Text = "Take Next Mastery Test";
            this.btnTakeMasteryTest.UseVisualStyleBackColor = true;
            this.btnTakeMasteryTest.Click += new System.EventHandler(this.btnTakeMasteryTest_Click);
            // 
            // btnTakePlacementTest
            // 
            this.btnTakePlacementTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePlacementTest.Location = new System.Drawing.Point(21, 36);
            this.btnTakePlacementTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakePlacementTest.Name = "btnTakePlacementTest";
            this.btnTakePlacementTest.Size = new System.Drawing.Size(238, 51);
            this.btnTakePlacementTest.TabIndex = 5;
            this.btnTakePlacementTest.Text = "Take Placement Test";
            this.btnTakePlacementTest.UseVisualStyleBackColor = true;
            this.btnTakePlacementTest.Click += new System.EventHandler(this.btnTakePlacementTest_Click);
            // 
            // gbxTakeTests
            // 
            this.gbxTakeTests.Controls.Add(this.lblNumberOfQuestions);
            this.gbxTakeTests.Controls.Add(this.lblMasteryLevels);
            this.gbxTakeTests.Controls.Add(this.cmbNumberOfQuestions);
            this.gbxTakeTests.Controls.Add(this.btnTakeRandomPracticeTest);
            this.gbxTakeTests.Controls.Add(this.cmbMasteryLevel);
            this.gbxTakeTests.Controls.Add(this.btnTakeMasteryTest);
            this.gbxTakeTests.Controls.Add(this.btnTakePlacementTest);
            this.gbxTakeTests.Location = new System.Drawing.Point(23, 86);
            this.gbxTakeTests.Name = "gbxTakeTests";
            this.gbxTakeTests.Size = new System.Drawing.Size(710, 269);
            this.gbxTakeTests.TabIndex = 6;
            this.gbxTakeTests.TabStop = false;
            this.gbxTakeTests.Text = "Take Tests";
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(379, 108);
            this.lblNumberOfQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(79, 13);
            this.lblNumberOfQuestions.TabIndex = 10;
            this.lblNumberOfQuestions.Text = "# of Questions:";
            // 
            // lblMasteryLevels
            // 
            this.lblMasteryLevels.AutoSize = true;
            this.lblMasteryLevels.Location = new System.Drawing.Point(272, 108);
            this.lblMasteryLevels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMasteryLevels.Name = "lblMasteryLevels";
            this.lblMasteryLevels.Size = new System.Drawing.Size(76, 13);
            this.lblMasteryLevels.TabIndex = 9;
            this.lblMasteryLevels.Text = "Mastery Level:";
            // 
            // cmbNumberOfQuestions
            // 
            this.cmbNumberOfQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumberOfQuestions.FormattingEnabled = true;
            this.cmbNumberOfQuestions.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cmbNumberOfQuestions.Location = new System.Drawing.Point(382, 124);
            this.cmbNumberOfQuestions.Name = "cmbNumberOfQuestions";
            this.cmbNumberOfQuestions.Size = new System.Drawing.Size(90, 33);
            this.cmbNumberOfQuestions.TabIndex = 8;
            this.cmbNumberOfQuestions.Tag = "Number of Questions";
            // 
            // btnTakeRandomPracticeTest
            // 
            this.btnTakeRandomPracticeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeRandomPracticeTest.Location = new System.Drawing.Point(21, 108);
            this.btnTakeRandomPracticeTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakeRandomPracticeTest.Name = "btnTakeRandomPracticeTest";
            this.btnTakeRandomPracticeTest.Size = new System.Drawing.Size(238, 51);
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
            this.cmbMasteryLevel.Location = new System.Drawing.Point(275, 124);
            this.cmbMasteryLevel.Name = "cmbMasteryLevel";
            this.cmbMasteryLevel.Size = new System.Drawing.Size(90, 33);
            this.cmbMasteryLevel.TabIndex = 6;
            this.cmbMasteryLevel.Tag = "Mastery Level";
            // 
            // gbxViewProgress
            // 
            this.gbxViewProgress.Location = new System.Drawing.Point(23, 438);
            this.gbxViewProgress.Name = "gbxViewProgress";
            this.gbxViewProgress.Size = new System.Drawing.Size(710, 166);
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
            this.lblStudentName.Location = new System.Drawing.Point(18, 40);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(239, 26);
            this.lblStudentName.TabIndex = 7;
            this.lblStudentName.Text = "Student: Student Name";
            // 
            // lblMasteryLevel
            // 
            this.lblMasteryLevel.AutoSize = true;
            this.lblMasteryLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasteryLevel.Location = new System.Drawing.Point(521, 40);
            this.lblMasteryLevel.Name = "lblMasteryLevel";
            this.lblMasteryLevel.Size = new System.Drawing.Size(183, 26);
            this.lblMasteryLevel.TabIndex = 8;
            this.lblMasteryLevel.Text = "Mastery Level: 00";
            // 
            // frmStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(813, 550);
            this.Controls.Add(this.lblMasteryLevel);
            this.Controls.Add(this.lblStudentName);
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
            this.gbxTakeTests.PerformLayout();
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
        private System.Windows.Forms.Button btnTakePlacementTest;
        private System.Windows.Forms.GroupBox gbxTakeTests;
        private System.Windows.Forms.GroupBox gbxViewProgress;
        private System.Windows.Forms.ComboBox cmbMasteryLevel;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblMasteryLevel;
        private System.Windows.Forms.Button btnTakeRandomPracticeTest;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Label lblMasteryLevels;
        private System.Windows.Forms.ComboBox cmbNumberOfQuestions;
    }
}