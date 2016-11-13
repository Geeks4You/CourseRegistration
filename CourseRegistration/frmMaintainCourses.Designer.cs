namespace CourseRegistration
{
    partial class frmMaintainCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainCourses));
            this.cmdNew = new System.Windows.Forms.Button();
            this.lblCourseSelLst = new System.Windows.Forms.Label();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCourseDesc = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCourseNum = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.cboCredits = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lnkAssignFaculty = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCourseFaculty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(256, 311);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 23);
            this.cmdNew.TabIndex = 72;
            this.cmdNew.Text = "New";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // lblCourseSelLst
            // 
            this.lblCourseSelLst.Location = new System.Drawing.Point(35, 21);
            this.lblCourseSelLst.Name = "lblCourseSelLst";
            this.lblCourseSelLst.Size = new System.Drawing.Size(120, 16);
            this.lblCourseSelLst.TabIndex = 87;
            this.lblCourseSelLst.Text = "Course Selection List:";
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(38, 40);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(202, 290);
            this.lstCourse.TabIndex = 61;
            this.lstCourse.SelectedIndexChanged += new System.EventHandler(this.lstCourse_SelectedIndexChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(341, 311);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 73;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(584, 311);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 76;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.Location = new System.Drawing.Point(503, 311);
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
            this.cmdDelete.Location = new System.Drawing.Point(422, 311);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 74;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(362, 64);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(287, 112);
            this.txtCourseDescription.TabIndex = 64;
            this.txtCourseDescription.TextChanged += new System.EventHandler(this.txtCourseDescription_TextChanged);
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Location = new System.Drawing.Point(362, 42);
            this.txtCourseNumber.MaxLength = 10;
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCourseNumber.TabIndex = 62;
            this.txtCourseNumber.TextChanged += new System.EventHandler(this.txtCourseNumber_TextChanged);
            // 
            // lblCredits
            // 
            this.lblCredits.Location = new System.Drawing.Point(260, 244);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(96, 16);
            this.lblCredits.TabIndex = 86;
            this.lblCredits.Text = "Credits:";
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCourseDesc
            // 
            this.lblCourseDesc.Location = new System.Drawing.Point(254, 64);
            this.lblCourseDesc.Name = "lblCourseDesc";
            this.lblCourseDesc.Size = new System.Drawing.Size(99, 18);
            this.lblCourseDesc.TabIndex = 85;
            this.lblCourseDesc.Text = "Course Description:";
            this.lblCourseDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(260, 222);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(96, 16);
            this.lblLocation.TabIndex = 81;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(260, 200);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(96, 16);
            this.lblEndDate.TabIndex = 80;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(260, 178);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 16);
            this.lblStartDate.TabIndex = 79;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCourseNum
            // 
            this.lblCourseNum.Location = new System.Drawing.Point(257, 42);
            this.lblCourseNum.Name = "lblCourseNum";
            this.lblCourseNum.Size = new System.Drawing.Size(96, 16);
            this.lblCourseNum.TabIndex = 77;
            this.lblCourseNum.Text = "Course Number:";
            this.lblCourseNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(362, 178);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 90;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(362, 200);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 91;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Silver;
            this.txtID.Location = new System.Drawing.Point(362, 267);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(47, 20);
            this.txtID.TabIndex = 94;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(260, 267);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(96, 16);
            this.lblID.TabIndex = 93;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Items.AddRange(new object[] {
            "Phoenix Online",
            "Phoenix Campus"});
            this.cboLocation.Location = new System.Drawing.Point(362, 221);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 21);
            this.cboLocation.TabIndex = 99;
            this.cboLocation.SelectedIndexChanged += new System.EventHandler(this.cboLocation_SelectedIndexChanged);
            // 
            // cboCredits
            // 
            this.cboCredits.FormattingEnabled = true;
            this.cboCredits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboCredits.Location = new System.Drawing.Point(362, 244);
            this.cboCredits.Name = "cboCredits";
            this.cboCredits.Size = new System.Drawing.Size(121, 21);
            this.cboCredits.TabIndex = 100;
            this.cboCredits.SelectedIndexChanged += new System.EventHandler(this.cboCredits_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lnkAssignFaculty);
            this.splitContainer1.Panel1.Controls.Add(this.lblCourseSelLst);
            this.splitContainer1.Panel1.Controls.Add(this.cboCredits);
            this.splitContainer1.Panel1.Controls.Add(this.lblCourseNum);
            this.splitContainer1.Panel1.Controls.Add(this.cboLocation);
            this.splitContainer1.Panel1.Controls.Add(this.lblStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.lblEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.lblLocation);
            this.splitContainer1.Panel1.Controls.Add(this.lblCourseDesc);
            this.splitContainer1.Panel1.Controls.Add(this.lblCredits);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.txtCourseNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.txtCourseDescription);
            this.splitContainer1.Panel1.Controls.Add(this.dtpEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.cmdDelete);
            this.splitContainer1.Panel1.Controls.Add(this.dtpStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.cmdHelp);
            this.splitContainer1.Panel1.Controls.Add(this.cmdNew);
            this.splitContainer1.Panel1.Controls.Add(this.cmdClose);
            this.splitContainer1.Panel1.Controls.Add(this.cmdSave);
            this.splitContainer1.Panel1.Controls.Add(this.lstCourse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.lblCourseFaculty);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(682, 604);
            this.splitContainer1.SplitterDistance = 447;
            this.splitContainer1.TabIndex = 101;
            // 
            // lnkAssignFaculty
            // 
            this.lnkAssignFaculty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnkAssignFaculty.Enabled = false;
            this.lnkAssignFaculty.Location = new System.Drawing.Point(0, 591);
            this.lnkAssignFaculty.Name = "lnkAssignFaculty";
            this.lnkAssignFaculty.Size = new System.Drawing.Size(682, 13);
            this.lnkAssignFaculty.TabIndex = 101;
            this.lnkAssignFaculty.TabStop = true;
            this.lnkAssignFaculty.Text = "Add Faculty to Course:";
            this.lnkAssignFaculty.Click += new System.EventHandler(this.lnkAssignFaculty_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(150, 30);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblCourseFaculty
            // 
            this.lblCourseFaculty.BackColor = System.Drawing.Color.Black;
            this.lblCourseFaculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourseFaculty.ForeColor = System.Drawing.Color.Lime;
            this.lblCourseFaculty.Location = new System.Drawing.Point(0, 0);
            this.lblCourseFaculty.Name = "lblCourseFaculty";
            this.lblCourseFaculty.Size = new System.Drawing.Size(150, 16);
            this.lblCourseFaculty.TabIndex = 0;
            this.lblCourseFaculty.Text = "This course is taught by the following instructor(s)";
            this.lblCourseFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMaintainCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 604);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaintainCourses";
            this.Text = "Maintain Courses";
            this.Load += new System.EventHandler(this.frmMaintainCourse_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdNew;
        internal System.Windows.Forms.Label lblCourseSelLst;
        internal System.Windows.Forms.ListBox lstCourse;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.Button cmdClose;
        internal System.Windows.Forms.Button cmdHelp;
        internal System.Windows.Forms.Button cmdDelete;
        internal System.Windows.Forms.TextBox txtCourseDescription;
        internal System.Windows.Forms.TextBox txtCourseNumber;
        internal System.Windows.Forms.Label lblCredits;
        internal System.Windows.Forms.Label lblCourseDesc;
        internal System.Windows.Forms.Label lblLocation;
        internal System.Windows.Forms.Label lblEndDate;
        internal System.Windows.Forms.Label lblStartDate;
        internal System.Windows.Forms.Label lblCourseNum;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.ComboBox cboCredits;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCourseFaculty;
        private System.Windows.Forms.LinkLabel lnkAssignFaculty;
    }
}