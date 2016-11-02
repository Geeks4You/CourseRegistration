namespace CourseRegistration
{
    partial class frmMaintainCourse
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
            this.cmdNew = new System.Windows.Forms.Button();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(160, 359);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 23);
            this.cmdNew.TabIndex = 72;
            this.cmdNew.Text = "New";
            this.cmdNew.UseVisualStyleBackColor = true;
            // 
            // lblCourses
            // 
            this.lblCourses.Location = new System.Drawing.Point(93, 69);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(120, 16);
            this.lblCourses.TabIndex = 87;
            this.lblCourses.Text = "Courses:";
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(93, 88);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(120, 251);
            this.lstCourse.TabIndex = 61;
            this.lstCourse.SelectedIndexChanged += new System.EventHandler(this.lstCourse_SelectedIndexChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(245, 359);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 73;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(488, 359);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 76;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.Location = new System.Drawing.Point(407, 359);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(75, 23);
            this.cmdHelp.TabIndex = 75;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Location = new System.Drawing.Point(326, 359);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 74;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(318, 292);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(100, 20);
            this.txtCredits.TabIndex = 71;
            this.txtCredits.TextChanged += new System.EventHandler(this.txtCredits_TextChanged);
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(318, 112);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(256, 112);
            this.txtCourseDescription.TabIndex = 64;
            this.txtCourseDescription.TextChanged += new System.EventHandler(this.txtCourseDescription_TextChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(318, 270);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(200, 20);
            this.txtLocation.TabIndex = 67;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Location = new System.Drawing.Point(318, 90);
            this.txtCourseNumber.MaxLength = 10;
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCourseNumber.TabIndex = 62;
            this.txtCourseNumber.TextChanged += new System.EventHandler(this.txtCourseNumber_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(216, 292);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(96, 16);
            this.lblEmail.TabIndex = 86;
            this.lblEmail.Text = "Credits:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProgram
            // 
            this.lblProgram.Location = new System.Drawing.Point(213, 112);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(96, 16);
            this.lblProgram.TabIndex = 85;
            this.lblProgram.Text = "Description:";
            this.lblProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(216, 270);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(96, 16);
            this.lblCity.TabIndex = 81;
            this.lblCity.Text = "Location:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.Location = new System.Drawing.Point(216, 248);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(96, 16);
            this.lblAddressLine2.TabIndex = 80;
            this.lblAddressLine2.Text = "End Date:";
            this.lblAddressLine2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.Location = new System.Drawing.Point(216, 226);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(96, 16);
            this.lblAddressLine1.TabIndex = 79;
            this.lblAddressLine1.Text = "Start Date:";
            this.lblAddressLine1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(213, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 16);
            this.lblFirstName.TabIndex = 77;
            this.lblFirstName.Text = "Number:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(318, 226);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 90;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(318, 248);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 91;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // frmMaintainCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lstCourse);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtCourseDescription);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtCourseNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmMaintainCourse";
            this.Text = "Maintain Course";
            this.Load += new System.EventHandler(this.frmMaintainCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdNew;
        internal System.Windows.Forms.Label lblCourses;
        internal System.Windows.Forms.ListBox lstCourse;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.Button cmdClose;
        internal System.Windows.Forms.Button cmdHelp;
        internal System.Windows.Forms.Button cmdDelete;
        internal System.Windows.Forms.TextBox txtCredits;
        internal System.Windows.Forms.TextBox txtCourseDescription;
        internal System.Windows.Forms.TextBox txtLocation;
        internal System.Windows.Forms.TextBox txtCourseNumber;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblProgram;
        internal System.Windows.Forms.Label lblCity;
        internal System.Windows.Forms.Label lblAddressLine2;
        internal System.Windows.Forms.Label lblAddressLine1;
        internal System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}