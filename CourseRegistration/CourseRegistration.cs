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
    /*  Program Name:   CourseRegistration
     *  Programmer:     Learning Team C
     *  Date:           11-21-2016
     *  Description:    Develop the details in the Register Students to Courses Program 
     *  menu option using the program your team created in Weeks Two and Three and expanding
     *  upon it. The program should be able to retrieve information from flat files and allow
     *  users to register students to courses. Include appropriate exception handling techniques.
     *  For example, a student should not be able to register for a course that has already passed 
     *  the start date. Include identifying information in the form of block comments at the top 
     *  of each class in the project (team name, date, program description). Include adequate 
     *  comments throughout the program, utilize meaningful names for controls, variables, fields, 
     *  and forms. Include white space for readability purposes in the code. Refer to the 
     *  Programming Assignment grading form to view grading criteria
     *  
     */
    public partial class CourseRegistration : Form
    {
        /* This class represents the MDI Parent for the application. It provides the MenuBar from which all other
         * application forms are instantiated.
         */
        #region Constructors
        public CourseRegistration()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Event handlers
        private void CourseRegistration_Load(object sender, EventArgs e)
        {   //Display the splash window when the application starts
            frmSplash fSplash = new frmSplash();
            fSplash.MdiParent = this;
            fSplash.Show();
        }
        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {   //User clicked on Maintain->Faculty
            frmMaintainFaculty fMaintainFaculty = new frmMaintainFaculty();
            fMaintainFaculty.MdiParent = this;
            fMaintainFaculty.Show();
        }
        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {   //User clicked on Maintain->Course
            frmMaintainCourses fMaintainCourse = new frmMaintainCourses();
            fMaintainCourse.MdiParent = this;
            fMaintainCourse.Show();
        }
        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {   //User clicked on Maintain->Registration
            frmRegistration fRegistration = new frmRegistration();
            fRegistration.MdiParent = this;
            fRegistration.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {   //User clicked on Help->About
            frmAbout fAbout = new frmAbout();
            fAbout.ShowDialog();
        }
        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {   //User clicked on File->Exit
            this.Close();
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {   //User clicked on Maintain->Students
            frmMaintainStudents fMaintainStudent = new frmMaintainStudents();
            fMaintainStudent.MdiParent = this;
            fMaintainStudent.Show();
        }
        private void helpHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {   //User clicked on Help->Help
            MessageBox.Show("No HELP yet.");
        }
        #endregion Event handlers
    }
}
