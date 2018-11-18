namespace MathWiz
{
    partial class frmCreateUserAccount
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblAdded = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.btnClassQuestion = new System.Windows.Forms.Button();
            this.backgroundWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerInsertData = new System.ComponentModel.BackgroundWorker();
            this.lblFirstNameRequired = new System.Windows.Forms.Label();
            this.lblLastNameRequired = new System.Windows.Forms.Label();
            this.lblUsernameRequired = new System.Windows.Forms.Label();
            this.lblPasswordRequired = new System.Windows.Forms.Label();
            this.lblClassRequired = new System.Windows.Forms.Label();
            this.lblParentRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(100, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(162, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(100, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(162, 22);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(100, 163);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 22);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(20, 166);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(21, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 17);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(24, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 17);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "LastName";
            // 
            // cmbParent
            // 
            this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParent.FormattingEnabled = true;
            this.cmbParent.Location = new System.Drawing.Point(339, 39);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(200, 24);
            this.cmbParent.TabIndex = 5;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParent.Location = new System.Drawing.Point(281, 42);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(50, 17);
            this.lblParent.TabIndex = 7;
            this.lblParent.Text = "Parent";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(100, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 124);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(64, 125);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 17);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID#";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(100, 261);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(162, 32);
            this.btnCreateUser.TabIndex = 7;
            this.btnCreateUser.Text = "Create User Account";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(315, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(291, 85);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 17);
            this.lblClass.TabIndex = 14;
            this.lblClass.Text = "Class";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(339, 82);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(200, 24);
            this.cmbClass.TabIndex = 6;
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdded.ForeColor = System.Drawing.Color.Green;
            this.lblAdded.Location = new System.Drawing.Point(157, 314);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(220, 19);
            this.lblAdded.TabIndex = 16;
            this.lblAdded.Text = "First Last was succesfully Added";
            this.lblAdded.Visible = false;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUsernameError.Location = new System.Drawing.Point(281, 166);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(222, 15);
            this.lblUsernameError.TabIndex = 17;
            this.lblUsernameError.Text = "That Username has already been taken";
            this.lblUsernameError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPasswordError.Location = new System.Drawing.Point(281, 207);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(132, 15);
            this.lblPasswordError.TabIndex = 18;
            this.lblPasswordError.Text = "A Password is required";
            this.lblPasswordError.Visible = false;
            // 
            // btnClassQuestion
            // 
            this.btnClassQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassQuestion.Location = new System.Drawing.Point(545, 81);
            this.btnClassQuestion.Name = "btnClassQuestion";
            this.btnClassQuestion.Size = new System.Drawing.Size(30, 26);
            this.btnClassQuestion.TabIndex = 19;
            this.btnClassQuestion.Text = "?";
            this.btnClassQuestion.UseVisualStyleBackColor = true;
            this.btnClassQuestion.Visible = false;
            this.btnClassQuestion.Click += new System.EventHandler(this.btnClassQuestion_Click);
            // 
            // backgroundWorkerLoadData
            // 
            this.backgroundWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadData_DoWork);
            this.backgroundWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadData_RunWorkerCompleted);
            // 
            // backgroundWorkerInsertData
            // 
            this.backgroundWorkerInsertData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerInsertData_DoWork);
            this.backgroundWorkerInsertData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerInsertData_RunWorkerCompleted);
            // 
            // lblFirstNameRequired
            // 
            this.lblFirstNameRequired.AutoSize = true;
            this.lblFirstNameRequired.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFirstNameRequired.Location = new System.Drawing.Point(264, 47);
            this.lblFirstNameRequired.Name = "lblFirstNameRequired";
            this.lblFirstNameRequired.Size = new System.Drawing.Size(11, 13);
            this.lblFirstNameRequired.TabIndex = 21;
            this.lblFirstNameRequired.Text = "*";
            // 
            // lblLastNameRequired
            // 
            this.lblLastNameRequired.AutoSize = true;
            this.lblLastNameRequired.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLastNameRequired.Location = new System.Drawing.Point(264, 87);
            this.lblLastNameRequired.Name = "lblLastNameRequired";
            this.lblLastNameRequired.Size = new System.Drawing.Size(11, 13);
            this.lblLastNameRequired.TabIndex = 22;
            this.lblLastNameRequired.Text = "*";
            // 
            // lblUsernameRequired
            // 
            this.lblUsernameRequired.AutoSize = true;
            this.lblUsernameRequired.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUsernameRequired.Location = new System.Drawing.Point(264, 168);
            this.lblUsernameRequired.Name = "lblUsernameRequired";
            this.lblUsernameRequired.Size = new System.Drawing.Size(11, 13);
            this.lblUsernameRequired.TabIndex = 23;
            this.lblUsernameRequired.Text = "*";
            // 
            // lblPasswordRequired
            // 
            this.lblPasswordRequired.AutoSize = true;
            this.lblPasswordRequired.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPasswordRequired.Location = new System.Drawing.Point(264, 209);
            this.lblPasswordRequired.Name = "lblPasswordRequired";
            this.lblPasswordRequired.Size = new System.Drawing.Size(11, 13);
            this.lblPasswordRequired.TabIndex = 24;
            this.lblPasswordRequired.Text = "*";
            // 
            // lblClassRequired
            // 
            this.lblClassRequired.AutoSize = true;
            this.lblClassRequired.ForeColor = System.Drawing.Color.Firebrick;
            this.lblClassRequired.Location = new System.Drawing.Point(545, 89);
            this.lblClassRequired.Name = "lblClassRequired";
            this.lblClassRequired.Size = new System.Drawing.Size(11, 13);
            this.lblClassRequired.TabIndex = 25;
            this.lblClassRequired.Text = "*";
            // 
            // lblParentRequired
            // 
            this.lblParentRequired.AutoSize = true;
            this.lblParentRequired.ForeColor = System.Drawing.Color.Firebrick;
            this.lblParentRequired.Location = new System.Drawing.Point(545, 44);
            this.lblParentRequired.Name = "lblParentRequired";
            this.lblParentRequired.Size = new System.Drawing.Size(11, 13);
            this.lblParentRequired.TabIndex = 26;
            this.lblParentRequired.Text = "*";
            // 
            // frmCreateUserAccount
            // 
            this.AcceptButton = this.btnCreateUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(587, 354);
            this.Controls.Add(this.lblParentRequired);
            this.Controls.Add(this.lblPasswordRequired);
            this.Controls.Add(this.lblUsernameRequired);
            this.Controls.Add(this.lblLastNameRequired);
            this.Controls.Add(this.lblFirstNameRequired);
            this.Controls.Add(this.btnClassQuestion);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblUsernameError);
            this.Controls.Add(this.lblAdded);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.cmbParent);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblClassRequired);
            this.Name = "frmCreateUserAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCreateUserAccount";
            this.Load += new System.EventHandler(this.frmCreateUserAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cmbParent;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblAdded;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Button btnClassQuestion;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInsertData;
        private System.Windows.Forms.Label lblFirstNameRequired;
        private System.Windows.Forms.Label lblLastNameRequired;
        private System.Windows.Forms.Label lblUsernameRequired;
        private System.Windows.Forms.Label lblPasswordRequired;
        private System.Windows.Forms.Label lblClassRequired;
        private System.Windows.Forms.Label lblParentRequired;
    }
}