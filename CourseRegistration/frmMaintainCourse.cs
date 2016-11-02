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
    public partial class frmMaintainCourse : Form
    {
        public frmMaintainCourse()
        {
            InitializeComponent();
        }

        private void frmMaintainCourse_Load(object sender, EventArgs e)
        {
            LoadCourseFromFile();
        }

        private void ClearForm()
        {   //Clear out all the fields on the form
            txtCourseNumber.Text = String.Empty;
            txtCourseDescription.Text = String.Empty;
            dtpStartDate.Text = String.Empty;
            dtpEndDate.Text = String.Empty;
            txtLocation.Text = String.Empty;
            txtCredits.Text = String.Empty;
        }

        private Boolean ValidInput()
        {   //The only requirement is a Course Number, start/end date and TODO: FacultyID selection at this point in time
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

        private void SaveCourse()
        {   //Format a Course object and save it in the ListBox
            Course course = new Course();
            course.CourseNumber = txtCourseNumber.Text;
            course.CourseDescription = txtCourseDescription.Text;
            course.StartDate = dtpStartDate.Text;
            course.EndDate = dtpEndDate.Text;
            course.Location = txtLocation.Text;
            course.Credits = txtCredits.Text;

            if (lstCourse.SelectedIndex > -1)
            {
                course.ID = -1;
                lstCourse.Items[lstCourse.SelectedIndex] = course;
            }
            else
            {
                course.ID = lstCourse.Items.Count + 1;
                lstCourse.Items.Add(course);
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {   //Set up the form and to receive data for a new course
            lstCourse.SelectedIndex = -1;
            cmdNew.Enabled = false;

            ClearForm();
            txtCourseNumber.Focus();
        }

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

        private void txtCourseNumber_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtCourseDescription_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtCredits_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtFacultyID_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {   //Delete the course from the ListBox
            if (MessageBox.Show("Are you sure you want to delete this Course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                lstCourse.Items.Remove(lstCourse.SelectedItem);
                ClearForm();
                SaveCourseToFile();
            }
        }

        private void lstCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lstCourse.SelectedIndex > -1))
            {
                // When the user clicks on an existing user, populate the form from the course store
                Course course = FindCourse(lstCourse.SelectedIndex);
                PopulateFormFromCourse(course);
                cmdDelete.Enabled = true;
            }
            else
            {
                // Nothing was selected, so clear the form
                ClearForm();
                cmdDelete.Enabled = false;
                cmdSave.Enabled = false;
            }
        }

        private Course FindCourse(Int32 nIndex)
        {   //Locate a Course object in the ListBox Course store
            Course course = new Course();

            course = (Course) lstCourse.Items[nIndex];

            return course;
        }

        private void PopulateFormFromCourse(Course course)
        {   // Populate the fields from the Course object

            txtCourseNumber.Text = course.CourseNumber;
            txtCourseDescription.Text = course.CourseDescription;
            dtpStartDate.Text = course.StartDate;
            dtpEndDate.Text = course.EndDate;
            txtLocation.Text = course.Location;
            txtCredits.Text = course.Credits;
        }

        private void LoadCourseFromFile()
        {

            String line;
            System.IO.StreamReader file = new System.IO.StreamReader("Course.csv");
            while ((line = file.ReadLine()) != null)
            {
                String[] szColumn = line.Split(',');
                Course course = new Course();
                course.ID = Convert.ToInt16(szColumn[0]);
                course.CourseNumber = szColumn[1];
                course.CourseDescription = szColumn[2];
                course.StartDate = szColumn[3];
                course.EndDate = szColumn[4];
                course.Location = szColumn[5];
                course.Credits = szColumn[6];
                lstCourse.Items.Add(course);
            }
            file.Close();
        }

        private void SaveCourseToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Course.csv"))
            {
                foreach (Course course in lstCourse.Items)
                {
                    String line = String.Empty;
                    line += course.ID.ToString() + ",";
                    line += course.CourseNumber + ",";
                    line += course.CourseDescription + ",";
                    line += course.StartDate + ",";
                    line += course.EndDate + ",";
                    line += course.Location + ",";
                    line += course.Credits;

                    file.WriteLine(line);
                }
            }
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but Help is not available yet.", "Help Clicked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
