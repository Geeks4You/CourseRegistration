namespace CourseRegistration
{
    partial class frmMaintainStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainStudents));
            this.cmdNew = new System.Windows.Forms.Button();
            this.lblStudentsSelLst = new System.Windows.Forms.Label();
            this.lstStudent = new System.Windows.Forms.ListBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtbZip = new System.Windows.Forms.MaskedTextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(239, 324);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 23);
            this.cmdNew.TabIndex = 12;
            this.cmdNew.Text = "New";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // lblStudentsSelLst
            // 
            this.lblStudentsSelLst.Location = new System.Drawing.Point(29, 34);
            this.lblStudentsSelLst.Name = "lblStudentsSelLst";
            this.lblStudentsSelLst.Size = new System.Drawing.Size(120, 16);
            this.lblStudentsSelLst.TabIndex = 60;
            this.lblStudentsSelLst.Text = "Students Selection List:";
            // 
            // lstStudent
            // 
            this.lstStudent.FormattingEnabled = true;
            this.lstStudent.Location = new System.Drawing.Point(29, 53);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(192, 290);
            this.lstStudent.TabIndex = 1;
            this.lstStudent.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(324, 324);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 13;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(567, 324);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 16;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.Location = new System.Drawing.Point(486, 324);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(75, 23);
            this.cmdHelp.TabIndex = 15;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Location = new System.Drawing.Point(405, 324);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 14;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(346, 231);
            this.mtbPhone.Mask = "(999)000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(128, 20);
            this.mtbPhone.TabIndex = 10;
            this.mtbPhone.TextChanged += new System.EventHandler(this.mtbPhone_TextChanged);
            // 
            // mtbZip
            // 
            this.mtbZip.Location = new System.Drawing.Point(346, 209);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(128, 20);
            this.mtbZip.TabIndex = 9;
            this.mtbZip.TextChanged += new System.EventHandler(this.mtbZip_TextChanged);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(346, 187);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(128, 21);
            this.cboState.TabIndex = 8;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(346, 165);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(128, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(346, 143);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(128, 20);
            this.txtAddressLine2.TabIndex = 6;
            this.txtAddressLine2.TextChanged += new System.EventHandler(this.txtAddressLine2_TextChanged);
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(346, 121);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(128, 20);
            this.txtAddressLine1.TabIndex = 5;
            this.txtAddressLine1.TextChanged += new System.EventHandler(this.txtAddressLine1_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(346, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(128, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(346, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(128, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(244, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(96, 16);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProgram
            // 
            this.lblProgram.Location = new System.Drawing.Point(238, 99);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(96, 16);
            this.lblProgram.TabIndex = 50;
            this.lblProgram.Text = "College Program:";
            this.lblProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(244, 231);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 16);
            this.lblPhone.TabIndex = 49;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZip
            // 
            this.lblZip.Location = new System.Drawing.Point(244, 209);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(96, 16);
            this.lblZip.TabIndex = 47;
            this.lblZip.Text = "Zip:";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(244, 187);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(96, 16);
            this.lblState.TabIndex = 45;
            this.lblState.Text = "State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(244, 165);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(96, 16);
            this.lblCity.TabIndex = 43;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.Location = new System.Drawing.Point(244, 143);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(96, 16);
            this.lblAddressLine2.TabIndex = 40;
            this.lblAddressLine2.Text = "Address Line 2:";
            this.lblAddressLine2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.Location = new System.Drawing.Point(244, 121);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(96, 16);
            this.lblAddressLine1.TabIndex = 38;
            this.lblAddressLine1.Text = "Address Line 1:";
            this.lblAddressLine1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(241, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 16);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(241, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 16);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(244, 275);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(96, 16);
            this.lblID.TabIndex = 61;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Silver;
            this.txtID.Location = new System.Drawing.Point(346, 275);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(127, 20);
            this.txtID.TabIndex = 62;
            // 
            // cboProgram
            // 
            this.cboProgram.FormattingEnabled = true;
            this.cboProgram.Items.AddRange(new object[] {
            "Business Management",
            "Communications",
            "Education",
            "Humanities & Science",
            "Mathmatics & Science",
            "Technology & Cyber Security"});
            this.cboProgram.Location = new System.Drawing.Point(346, 99);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(256, 21);
            this.cboProgram.TabIndex = 64;
            // 
            // frmMaintainStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 402);
            this.Controls.Add(this.cboProgram);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.lblStudentsSelLst);
            this.Controls.Add(this.lstStudent);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.mtbZip);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaintainStudents";
            this.Text = "Maintain Students";
            this.Load += new System.EventHandler(this.frmMaintainStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdNew;
        internal System.Windows.Forms.Label lblStudentsSelLst;
        internal System.Windows.Forms.ListBox lstStudent;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.Button cmdClose;
        internal System.Windows.Forms.Button cmdHelp;
        internal System.Windows.Forms.Button cmdDelete;
        internal System.Windows.Forms.MaskedTextBox mtbPhone;
        internal System.Windows.Forms.MaskedTextBox mtbZip;
        internal System.Windows.Forms.ComboBox cboState;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddressLine2;
        internal System.Windows.Forms.TextBox txtAddressLine1;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblProgram;
        internal System.Windows.Forms.Label lblPhone;
        internal System.Windows.Forms.Label lblZip;
        internal System.Windows.Forms.Label lblState;
        internal System.Windows.Forms.Label lblCity;
        internal System.Windows.Forms.Label lblAddressLine2;
        internal System.Windows.Forms.Label lblAddressLine1;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboProgram;
    }
}