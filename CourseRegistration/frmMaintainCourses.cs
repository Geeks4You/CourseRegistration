using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    public partial class frmMaintainCourses : Form
    {   //This form displays the "Course Maintenance" window 
        #region Constructors
        public frmMaintainCourses()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Event Handlers
        /// <summary>
        /// When the form loads, initialize the Course listbox, Maximize the window, and add the Delete column to the datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaintainCourse_Load(object sender, EventArgs e)
        {
            LoadCourseFromFile();
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
        /// Set up the form to receive data for a new Course when the user clicks the New button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNew_Click(object sender, EventArgs e)
        {
            lstCourse.SelectedIndex = -1;
            cmdNew.Enabled = false;

            ClearForm();
            txtCourseNumber.Focus();
        }
        /// <summary>
        /// When the user clicks Save, validate the data, create a Course object, save the Course in the data file and set various button's disposition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {   //User clicked Save, so validate the fields and save the course in the course store if good data
            if (ValidInput())
            {
                SaveCourse();
                SaveCourseToFile();
                cmdNew.Enabled = true;
                cmdSave.Enabled = false;
            }
        }
        /// <summary>
        /// Course Number text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCourseNumber_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Course Description text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCourseDescription_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Start Date text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// End Date text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Location text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Credits text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCredits_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Faculty ID text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFacultyID_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Location selected index changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Credits selected index changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCredits_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// User clicked Delete. Confirm the user's intent, if the Course is not currently schedule, remove from the listbox, clear the form and update the Course CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDelete_Click(object sender, EventArgs e)
        {   //Delete the course from the ListBox
            if (MessageBox.Show("Are you sure you want to delete this Course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                Course course = (Course)lstCourse.SelectedItem;
                if (Globals.CourseIsScheduled(course.ID))
                {
                    MessageBox.Show(course.CourseNumber + " is currently scheduled in the University calendar. Please UnRegister all students from the course before attempting to delete the course.", "Related Data Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    lstCourse.Items.Remove(lstCourse.SelectedItem);
                    ClearForm();
                    SaveCourseToFile();
                }
            }
        }
        /// <summary>
        /// User clicked on a Course in the listbox, so populate the form from the Course, expose any Faculty relationships and set various control's dispositions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lstCourse.SelectedIndex > -1))
            {
                // When the user clicks on an existing user, populate the form from the course store
                Course course = FindCourse(Convert.ToInt16(lstCourse.SelectedIndex));
                PopulateFormFromCourse(course);
                ExposeRelatedFaculty();
                cmdDelete.Enabled = true;
                lnkAssignFaculty.Enabled = true;
                splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                // Nothing was selected, so clear the form
                ClearForm();
                cmdDelete.Enabled = false;
                cmdSave.Enabled = false;
            }
        }
        /// <summary>
        /// User clicked the Help button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but Help is not available yet.", "Help Clicked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// User clicked the Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// User clicked the Assign Faculty link, so popup the Faculty selection form and if "Select" is clicked on that form, save the CourseFaculty update to the CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkAssignFaculty_Click(object sender, EventArgs e)
        {
            frmSelectFaculty fSelectFaculty = new frmSelectFaculty();
            if (fSelectFaculty.ShowDialog().Equals(DialogResult.OK))
            {
                CourseFaculty coursefaculty = new CourseFaculty();

                Course course = (Course) lstCourse.SelectedItem;
                Faculty faculty = (Faculty) fSelectFaculty.cboFaculty.SelectedItem;

                coursefaculty.CourseID = course.ID;
                coursefaculty.FacultyID = faculty.ID;


                SaveCourseFacultyToFile(coursefaculty);
                splitContainer1.Panel2Collapsed = false;
            }
        }
        /// <summary>
        /// User clicked on the Delete cell in the data grid view. Delete the CourseFaculty row and re-expose the related Faculty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Click: Row=" + e.RowIndex.ToString() + " Column=" +e.ColumnIndex.ToString());

            Int16 FacultyID = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            Course course = (Course)lstCourse.SelectedItem;
            Globals.DeleteCourseFaculty(course.ID, FacultyID);
            ExposeRelatedFaculty();
        }
        #endregion Event Handlers

        #region Helper Functions
        /// <summary>
        /// Clears all the data enterable controls on the form
        /// </summary>
        private void ClearForm()
        {
            txtCourseNumber.Text = String.Empty;
            txtCourseDescription.Text = String.Empty;
            dtpStartDate.Text = String.Empty;
            dtpEndDate.Text = String.Empty;
            cboLocation.Text = String.Empty;
            cboCredits.Text = String.Empty;
        }
        /// <summary>
        /// Validates the data enterable controls for minimum validity
        /// </summary>
        /// <returns></returns>
        private Boolean ValidInput()
        {   //The only requirement is a Course Number, start/end date
            if (txtCourseNumber.Text.Equals(String.Empty))
            {
                System.Windows.Forms.MessageBox.Show("You must provide a course number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpStartDate.Text.Equals(String.Empty))
            {
                System.Windows.Forms.MessageBox.Show("You must provide a start date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpEndDate.Text.Equals(String.Empty))
            {
                System.Windows.Forms.MessageBox.Show("You must provide a end date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /// <summary>
        /// Format a Course object from the data enterable controls and save it in the ListBox
        /// </summary>
        private void SaveCourse()
        {
            Course course = new Course();
            if (lstCourse.SelectedIndex > -1)
            {
                course = (Course)lstCourse.Items[lstCourse.SelectedIndex];
            }
            course.CourseNumber = txtCourseNumber.Text;
            course.CourseDescription = txtCourseDescription.Text;
            course.StartDate = dtpStartDate.Value.ToShortDateString();
            course.EndDate = dtpEndDate.Value.ToShortDateString();
            course.Location = cboLocation.Text;
            course.Credits = cboCredits.Text;

            if (lstCourse.SelectedIndex > -1)
            {
                lstCourse.Items[lstCourse.SelectedIndex] = course;
            }
            else
            {
                course.ID = GetNextID();
                lstCourse.Items.Add(course);
            }
        }
        /// <summary>
        /// Read through the Course saving the maximum ID in use and increment by 1
        /// </summary>
        /// <returns></returns>
        private Int16 GetNextID()
        {
            Int16 nID = -1;

            String line;
            System.IO.StreamReader file = new System.IO.StreamReader("Course.csv");
            while ((line = file.ReadLine()) != null)
            {
                String[] szColumn = line.Split(',');
                if (Convert.ToInt16(szColumn[0]) > nID)
                {
                    nID = Convert.ToInt16(szColumn[0]);
                }
            }
            file.Close();

            nID++;
            return nID;
        }
        /// <summary>
        /// Create a data table from populate it from the Faculty that instruct the Course
        /// </summary>
        private void ExposeRelatedFaculty()
        {
            //Get the Course ID for the selected Course
            Course course = FindCourse(Convert.ToInt16(lstCourse.SelectedIndex));

            // Create two typed columns in a DataTable.
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Faculty Name", typeof(string));

            //Find all the Faculty thsat teach this course and add them to the table
            ArrayList alFaculty = Globals.GetRelatedFacultyForCourse(course.ID);
            foreach (Faculty faculty in alFaculty)
            {
                table.Rows.Add(faculty.ID, faculty.FirstName + " " + faculty.LastName);
            }
            //Arrange the columns, set the data source and expose the datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;
            splitContainer1.Panel2Collapsed = false;
        }
        /// <summary>
        /// Locate a Course object in the ListBox Course store
        /// </summary>
        /// <param name="nIndex">The index of the Course listbox control</param>
        /// <returns>The Course object related to the nIndex</returns>
        private Course FindCourse(Int16 nIndex)
        {
            Course course = new Course();

            course = (Course) lstCourse.Items[nIndex];

            return course;
        }
        /// <summary>
        /// Populate the data enterable controls from a Course object
        /// </summary>
        /// <param name="course">The Course object</param>
        private void PopulateFormFromCourse(Course course)
        {   // Populate the fields from the Course object
            txtCourseNumber.Text = course.CourseNumber;
            txtCourseDescription.Text = course.CourseDescription;
            dtpStartDate.Text = course.StartDate;
            dtpEndDate.Text = course.EndDate;
            cboLocation.Text = course.Location;
            cboCredits.Text = course.Credits;
            txtID.Text = course.ID.ToString();
        }
        /// <summary>
        /// Load the Course listbox from the data in the Course CSV file
        /// </summary>
        private void LoadCourseFromFile()
        {
            String line;
            System.IO.StreamReader file = new System.IO.StreamReader("Course.csv");
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                Course course = new Course(line);
                if (course != null)
                {
                    lstCourse.Items.Add(course);
                }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Exception Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            file.Close();
        }
        /// <summary>
        /// Write the contents of the items in the Course listbox to the Course CSV file
        /// </summary>
        private void SaveCourseToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Course.csv"))
            {
                foreach (Course course in lstCourse.Items)
                {
                    file.WriteLine(course.ToRecord());
                }
            }
        }
        /// <summary>
        /// Append a CourseFaculty object to the CourseFaculty CSV file
        /// </summary>
        /// <param name="coursefaculty"></param>
        private void SaveCourseFacultyToFile(CourseFaculty coursefaculty)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("CourseFaculty.csv", true))
            {
                file.WriteLine(coursefaculty.ToRecord());
                file.Close();
            }
            ExposeRelatedFaculty();
        }
        #endregion Helper Functions
    }
}
