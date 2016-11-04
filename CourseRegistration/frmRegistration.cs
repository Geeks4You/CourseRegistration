using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistrationMenu_Load(object sender, EventArgs e)
        {
            Globals.LoadStudents(cboStudents);
            Globals.LoadCourses(cboCourses);
            this.WindowState = FormWindowState.Maximized;

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dataGridView1.Columns.Add(Deletelink);
        }

        private void cboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdRegister.Enabled = ((cboStudents.SelectedIndex > -1) && (cboCourses.SelectedIndex > -1));
            if (cboStudents.SelectedIndex > -1)
            {
                Student student = (Student)cboStudents.SelectedItem;
                ExposeStudentSchedule(student);
            }
        }

        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourses.SelectedIndex > -1)
            {
                Course course = (Course)cboCourses.SelectedItem;
                lblStartDate.Enabled = true;
                lblStartDate.Text = "Start Date: " + course.StartDate;
            }
            cmdRegister.Enabled = ((cboStudents.SelectedIndex > -1) && (cboCourses.SelectedIndex > -1));
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Registration.csv", true))
            {
                Student student = (Student)cboStudents.SelectedItem;
                Course course = (Course)cboCourses.SelectedItem;
                String line = String.Empty;
                line += student.ID.ToString() + ",";
                line += course.ID.ToString();

                file.WriteLine(line);
                file.Close();
                ExposeStudentSchedule(student);
            }
        }
        private void ExposeStudentSchedule(Student student)
        {
            // Create two typed columns in a DataTable.
            DataTable table = new DataTable();
            table.Columns.Add("Course ID", typeof(Int16));
            table.Columns.Add("Course Name", typeof(string));
            table.Columns.Add("Start Date", typeof(string));

            String RegistrationLine;
            System.IO.StreamReader RegistrationFile = new System.IO.StreamReader("Registration.csv");
            while ((RegistrationLine = RegistrationFile.ReadLine()) != null)
            {
                String[] szColumn = RegistrationLine.Split(',');
                if (szColumn.Length == 2)
                {
                    Registration registration = new Registration();
                    registration.StudentID = Convert.ToInt16(szColumn[0]);
                    registration.CourseID = Convert.ToInt16(szColumn[1]);
                    if (registration.StudentID.Equals(student.ID))
                    {
                        Course course = Globals.GetCourse(registration.CourseID);
                        table.Rows.Add(course.ID, course.CourseNumber, course.StartDate);
                    }
                }
            }
            RegistrationFile.Close();

            //Arrange the columns, set the data source and expose the datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "UnRegister";
            dataGridView1.Columns[1].HeaderText = "Course ID";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Course Number";
            dataGridView1.Columns[3].HeaderText = "Course Start Date";

            ResizeDataGridView();

            splitContainer1.Panel2Collapsed = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Click: Row=" + e.RowIndex.ToString() + " Column=" +e.ColumnIndex.ToString());

            Student student = (Student)cboStudents.SelectedItem;
            Int16 CourseID = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            Course course = Globals.GetCourse(Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
            Globals.DeleteRegistration(student.ID, course.ID);

            ExposeStudentSchedule(student);
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            ResizeDataGridView();
        }

        private void ResizeDataGridView()
        {
            try
            {
                dataGridView1.Top = 22;
                dataGridView1.Left = 0;
                dataGridView1.Height = splitContainer1.Panel2.Height - 22;
                dataGridView1.Width = splitContainer1.Panel2.Width;
            }
            catch (Exception) { }
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            ResizeDataGridView();
        }
    }
}
