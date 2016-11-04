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
            this.updateStu = new System.Windows.Forms.Button();
            this.gradDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.editStu = new System.Windows.Forms.Button();
            this.addStu = new System.Windows.Forms.Button();
            this.fosStu = new System.Windows.Forms.ComboBox();
            this.elStu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stuID = new System.Windows.Forms.TextBox();
            this.addressStu = new System.Windows.Forms.TextBox();
            this.lNameStu = new System.Windows.Forms.TextBox();
            this.fNameStu = new System.Windows.Forms.TextBox();
            this.listStu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // updateStu
            // 
            this.updateStu.Location = new System.Drawing.Point(450, 282);
            this.updateStu.Name = "updateStu";
            this.updateStu.Size = new System.Drawing.Size(95, 23);
            this.updateStu.TabIndex = 38;
            this.updateStu.Text = "Update Student";
            this.updateStu.UseVisualStyleBackColor = true;
            // 
            // gradDate
            // 
            this.gradDate.Location = new System.Drawing.Point(450, 224);
            this.gradDate.Name = "gradDate";
            this.gradDate.Size = new System.Drawing.Size(200, 20);
            this.gradDate.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Graduation Date";
            // 
            // editStu
            // 
            this.editStu.Location = new System.Drawing.Point(67, 311);
            this.editStu.Name = "editStu";
            this.editStu.Size = new System.Drawing.Size(130, 25);
            this.editStu.TabIndex = 35;
            this.editStu.Text = "Edit Selected Student";
            this.editStu.UseVisualStyleBackColor = true;
            // 
            // addStu
            // 
            this.addStu.Location = new System.Drawing.Point(450, 250);
            this.addStu.Name = "addStu";
            this.addStu.Size = new System.Drawing.Size(75, 23);
            this.addStu.TabIndex = 34;
            this.addStu.Text = "Add Student";
            this.addStu.UseVisualStyleBackColor = true;
            // 
            // fosStu
            // 
            this.fosStu.FormattingEnabled = true;
            this.fosStu.Location = new System.Drawing.Point(450, 171);
            this.fosStu.Name = "fosStu";
            this.fosStu.Size = new System.Drawing.Size(121, 21);
            this.fosStu.TabIndex = 33;
            this.fosStu.Text = "Select...";
            // 
            // elStu
            // 
            this.elStu.FormattingEnabled = true;
            this.elStu.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.elStu.Location = new System.Drawing.Point(450, 197);
            this.elStu.Name = "elStu";
            this.elStu.Size = new System.Drawing.Size(121, 21);
            this.elStu.TabIndex = 32;
            this.elStu.Text = "Select...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Education Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Field of Study";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "First Name";
            // 
            // stuID
            // 
            this.stuID.BackColor = System.Drawing.SystemColors.Info;
            this.stuID.Location = new System.Drawing.Point(450, 145);
            this.stuID.Name = "stuID";
            this.stuID.ReadOnly = true;
            this.stuID.Size = new System.Drawing.Size(100, 20);
            this.stuID.TabIndex = 25;
            // 
            // addressStu
            // 
            this.addressStu.Location = new System.Drawing.Point(450, 119);
            this.addressStu.Name = "addressStu";
            this.addressStu.Size = new System.Drawing.Size(197, 20);
            this.addressStu.TabIndex = 24;
            // 
            // lNameStu
            // 
            this.lNameStu.Location = new System.Drawing.Point(450, 93);
            this.lNameStu.Name = "lNameStu";
            this.lNameStu.Size = new System.Drawing.Size(100, 20);
            this.lNameStu.TabIndex = 23;
            // 
            // fNameStu
            // 
            this.fNameStu.Location = new System.Drawing.Point(450, 67);
            this.fNameStu.Name = "fNameStu";
            this.fNameStu.Size = new System.Drawing.Size(100, 20);
            this.fNameStu.TabIndex = 22;
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
            this.listStu.Location = new System.Drawing.Point(10, 67);
            this.listStu.Name = "listStu";
            this.listStu.Size = new System.Drawing.Size(242, 238);
            this.listStu.TabIndex = 21;
            // 
            // frmMaintainStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.listStu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaintainStudents";
            this.Text = "Maintain Students";
            this.Load += new System.EventHandler(this.frmMaintainStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateStu;
        private System.Windows.Forms.DateTimePicker gradDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button editStu;
        private System.Windows.Forms.Button addStu;
        private System.Windows.Forms.ComboBox fosStu;
        private System.Windows.Forms.ComboBox elStu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stuID;
        private System.Windows.Forms.TextBox addressStu;
        private System.Windows.Forms.TextBox lNameStu;
        private System.Windows.Forms.TextBox fNameStu;
        private System.Windows.Forms.ListBox listStu;

    }
}