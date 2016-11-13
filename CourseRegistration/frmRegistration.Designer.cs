namespace CourseRegistration
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cboStudents = new System.Windows.Forms.ComboBox();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboCourses = new System.Windows.Forms.ComboBox();
            this.lblStudentScheduled = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblClassClosed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.Location = new System.Drawing.Point(41, 35);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(128, 20);
            this.lblSelectStudent.TabIndex = 0;
            this.lblSelectStudent.Text = "Select a Student:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.Location = new System.Drawing.Point(41, 57);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(128, 20);
            this.lblSelectCourse.TabIndex = 1;
            this.lblSelectCourse.Text = "Select a Course:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Enabled = false;
            this.lblStartDate.Location = new System.Drawing.Point(41, 79);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(128, 20);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // cboStudents
            // 
            this.cboStudents.FormattingEnabled = true;
            this.cboStudents.Location = new System.Drawing.Point(179, 33);
            this.cboStudents.Name = "cboStudents";
            this.cboStudents.Size = new System.Drawing.Size(121, 21);
            this.cboStudents.TabIndex = 4;
            this.cboStudents.SelectedIndexChanged += new System.EventHandler(this.cboStudents_SelectedIndexChanged);
            // 
            // cmdRegister
            // 
            this.cmdRegister.Enabled = false;
            this.cmdRegister.Location = new System.Drawing.Point(179, 99);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(121, 23);
            this.cmdRegister.TabIndex = 5;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.lblClassClosed);
            this.splitContainer1.Panel1.Controls.Add(this.cboStudents);
            this.splitContainer1.Panel1.Controls.Add(this.cboCourses);
            this.splitContainer1.Panel1.Controls.Add(this.lblSelectStudent);
            this.splitContainer1.Panel1.Controls.Add(this.lblSelectCourse);
            this.splitContainer1.Panel1.Controls.Add(this.cmdRegister);
            this.splitContainer1.Panel1.Controls.Add(this.lblStartDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblStudentScheduled);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(661, 402);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // cboCourses
            // 
            this.cboCourses.FormattingEnabled = true;
            this.cboCourses.Location = new System.Drawing.Point(179, 55);
            this.cboCourses.Name = "cboCourses";
            this.cboCourses.Size = new System.Drawing.Size(256, 21);
            this.cboCourses.TabIndex = 7;
            this.cboCourses.SelectedIndexChanged += new System.EventHandler(this.cboCourses_SelectedIndexChanged);
            // 
            // lblStudentScheduled
            // 
            this.lblStudentScheduled.BackColor = System.Drawing.Color.Black;
            this.lblStudentScheduled.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStudentScheduled.ForeColor = System.Drawing.Color.Lime;
            this.lblStudentScheduled.Location = new System.Drawing.Point(0, 0);
            this.lblStudentScheduled.Name = "lblStudentScheduled";
            this.lblStudentScheduled.Size = new System.Drawing.Size(150, 20);
            this.lblStudentScheduled.TabIndex = 1;
            this.lblStudentScheduled.Text = "This student is scheduled in the following courses on the following start dates:";
            this.lblStudentScheduled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 97);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblClassClosed
            // 
            this.lblClassClosed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblClassClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassClosed.ForeColor = System.Drawing.Color.Red;
            this.lblClassClosed.Location = new System.Drawing.Point(179, 77);
            this.lblClassClosed.Name = "lblClassClosed";
            this.lblClassClosed.Size = new System.Drawing.Size(386, 20);
            this.lblClassClosed.TabIndex = 8;
            this.lblClassClosed.Text = "This class has been closed for registration because it has already commenced.";
            this.lblClassClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClassClosed.Visible = false;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 402);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistrationMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cboStudents;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboCourses;
        private System.Windows.Forms.Label lblStudentScheduled;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblClassClosed;

    }
}