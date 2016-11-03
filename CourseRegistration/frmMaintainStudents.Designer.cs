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
            this.listStu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fNameStu = new System.Windows.Forms.TextBox();
            this.lNameStu = new System.Windows.Forms.TextBox();
            this.addressStu = new System.Windows.Forms.TextBox();
            this.stuID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.elStu = new System.Windows.Forms.ComboBox();
            this.fosStu = new System.Windows.Forms.ComboBox();
            this.addStu = new System.Windows.Forms.Button();
            this.editStu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gradDate = new System.Windows.Forms.DateTimePicker();
            this.updateStu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listStu
            // 
            this.listStu.FormattingEnabled = true;
            this.listStu.Items.AddRange(new object[] {
            "Andrew Brown",
            "Bob Dart",
            "Carter Evans",
            "Dale Gilbert",
            "Frank Hammond"});
            this.listStu.Location = new System.Drawing.Point(12, 75);
            this.listStu.Name = "listStu";
            this.listStu.Size = new System.Drawing.Size(242, 238);
            this.listStu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Information";
            // 
            // fNameStu
            // 
            this.fNameStu.Location = new System.Drawing.Point(452, 75);
            this.fNameStu.Name = "fNameStu";
            this.fNameStu.Size = new System.Drawing.Size(100, 20);
            this.fNameStu.TabIndex = 2;
            // 
            // lNameStu
            // 
            this.lNameStu.Location = new System.Drawing.Point(452, 101);
            this.lNameStu.Name = "lNameStu";
            this.lNameStu.Size = new System.Drawing.Size(100, 20);
            this.lNameStu.TabIndex = 3;
            // 
            // addressStu
            // 
            this.addressStu.Location = new System.Drawing.Point(452, 127);
            this.addressStu.Name = "addressStu";
            this.addressStu.Size = new System.Drawing.Size(197, 20);
            this.addressStu.TabIndex = 4;
            // 
            // stuID
            // 
            this.stuID.BackColor = System.Drawing.SystemColors.Info;
            this.stuID.Location = new System.Drawing.Point(452, 153);
            this.stuID.Name = "stuID";
            this.stuID.ReadOnly = true;
            this.stuID.Size = new System.Drawing.Size(100, 20);
            this.stuID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Field of Study";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Education Level";
            // 
            // elStu
            // 
            this.elStu.FormattingEnabled = true;
            this.elStu.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.elStu.Location = new System.Drawing.Point(452, 205);
            this.elStu.Name = "elStu";
            this.elStu.Size = new System.Drawing.Size(121, 21);
            this.elStu.TabIndex = 14;
            this.elStu.Text = "Select...";
            // 
            // fosStu
            // 
            this.fosStu.FormattingEnabled = true;
            this.fosStu.Location = new System.Drawing.Point(452, 179);
            this.fosStu.Name = "fosStu";
            this.fosStu.Size = new System.Drawing.Size(121, 21);
            this.fosStu.TabIndex = 15;
            this.fosStu.Text = "Select...";
            // 
            // addStu
            // 
            this.addStu.Location = new System.Drawing.Point(452, 258);
            this.addStu.Name = "addStu";
            this.addStu.Size = new System.Drawing.Size(75, 23);
            this.addStu.TabIndex = 16;
            this.addStu.Text = "Add Student";
            this.addStu.UseVisualStyleBackColor = true;
            // 
            // editStu
            // 
            this.editStu.Location = new System.Drawing.Point(69, 319);
            this.editStu.Name = "editStu";
            this.editStu.Size = new System.Drawing.Size(130, 25);
            this.editStu.TabIndex = 17;
            this.editStu.Text = "Edit Selected Student";
            this.editStu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Graduation Date";
            // 
            // gradDate
            // 
            this.gradDate.Location = new System.Drawing.Point(452, 232);
            this.gradDate.Name = "gradDate";
            this.gradDate.Size = new System.Drawing.Size(200, 20);
            this.gradDate.TabIndex = 19;
            // 
            // updateStu
            // 
            this.updateStu.Location = new System.Drawing.Point(452, 290);
            this.updateStu.Name = "updateStu";
            this.updateStu.Size = new System.Drawing.Size(95, 23);
            this.updateStu.TabIndex = 20;
            this.updateStu.Text = "Update Student";
            this.updateStu.UseVisualStyleBackColor = true;
            // 
            // frmMaintainStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(661, 402);
            this.Controls.Add(this.updateStu);
            this.Controls.Add(this.gradDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.editStu);
            this.Controls.Add(this.addStu);
            this.Controls.Add(this.fosStu);
            this.Controls.Add(this.elStu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.addressStu);
            this.Controls.Add(this.lNameStu);
            this.Controls.Add(this.fNameStu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaintainStudents";
            this.Text = "Maintain Students";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaintainStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listStu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fNameStu;
        private System.Windows.Forms.TextBox lNameStu;
        private System.Windows.Forms.TextBox addressStu;
        private System.Windows.Forms.TextBox stuID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox elStu;
        private System.Windows.Forms.ComboBox fosStu;
        private System.Windows.Forms.Button addStu;
        private System.Windows.Forms.Button editStu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker gradDate;
        private System.Windows.Forms.Button updateStu;


    }
}