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
    {   //This form displays the "Course Registration" window 
        #region Constructors
        public frmRegistration()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Event Handlers
        /// <summary>
        /// When the form loads, load the Student combox box, load the Course combox box, Maximize the window and add the delete link column to the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Student selected, so Enable the Register button if Course is selected and expose the Student's Schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdRegister.Enabled = ((cboStudents.SelectedIndex > -1) && (cboCourses.SelectedIndex > -1));
            if (cboStudents.SelectedIndex > -1)
            {
                Student student = (Student)cboStudents.SelectedItem;
                ExposeStudentSchedule(student);
            }
        }
        /// <summary>
        /// Course selected, so expose the Start Date, Enable the Register button. If Start Date has passed, show Class is Closed and disable Register button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course course = null;
            if (cboCourses.SelectedIndex > -1)
            {
                course = (Course)cboCourses.SelectedItem;
                lblStartDate.Enabled = true;
                lblStartDate.Text = "Start Date: " + course.StartDate;
            }
            cmdRegister.Enabled = ((cboStudents.SelectedIndex > -1) && (cboCourses.SelectedIndex > -1));
            if (course != null)
            {
                if (Convert.ToDateTime(course.StartDate) > DateTime.Now)
                {
                    lblClassClosed.Visible = false;
                }
                else
                {
                    cmdRegister.Enabled = false;
                    lblClassClosed.Visible = true;
                }
            }
        }
        /// <summary>
        /// Register button clicked. So, append Registration to Registration CSV file and re-Expose the student's schedule 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Delete cell clicked, so delete the registration and re-Expose the Student Schedule.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student student = (Student)cboStudents.SelectedItem;
            Int16 CourseID = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            Course course = Globals.GetCourse(Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
            Globals.DeleteRegistration(student.ID, course.ID);

            ExposeStudentSchedule(student);
        }
        /// <summary>
        /// When the split container resizes, make sure all content controls are uniformly resized because they are not docked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            ResizeDataGridView();
        }
        /// <summary>
        /// Content controls are uniformly resized because they are not docked
        /// </summary>
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
        /// <summary>
        /// When the split container's panel #2 resizes, make sure all content controls are uniformly resized because they are not docked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            ResizeDataGridView();
        }
        #endregion Event Handlers

        #region Helper functions
        /// <summary>
        /// Build the Schedule table and populate it from the Registration CSV file
        /// </summary>
        /// <param name="student"></param>
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
                Registration registration = new Registration(RegistrationLine);
                if (registration.StudentID.Equals(student.ID))
                {
                    Course course = Globals.GetCourse(registration.CourseID);
                    if (course != null)
                    {
                        table.Rows.Add(course.ID, course.CourseNumber, course.StartDate);
                    }
                }
            }
            RegistrationFile.Close();

            //Arrange the columns, set the data source and expose the datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;

            //Title the headers of the remaining columns
            dataGridView1.Columns[0].HeaderText = "UnRegister";
            dataGridView1.Columns[1].HeaderText = "Course ID";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Course Number";
            dataGridView1.Columns[3].HeaderText = "Course Start Date";

            ResizeDataGridView();

            splitContainer1.Panel2Collapsed = false;
        }
        #endregion Helper functions
    }
}
