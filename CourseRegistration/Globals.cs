using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    public static class Globals
    {   // This globally available static class contain methods that may be called by any object
        // for purposes of retrieving, updating and evaluating disk data
        #region Load Controls
        public static void LoadStates(ComboBox cboStates)
        {   //Load the state abbreviations into the combo box
            cboStates.Items.Add("AL");
            cboStates.Items.Add("AK");
            cboStates.Items.Add("AS");
            cboStates.Items.Add("AZ");
            cboStates.Items.Add("AR");
            cboStates.Items.Add("CA");
            cboStates.Items.Add("CO");
            cboStates.Items.Add("CT");
            cboStates.Items.Add("DE");
            cboStates.Items.Add("DC");
            cboStates.Items.Add("FL");
            cboStates.Items.Add("GA");
            cboStates.Items.Add("GU");
            cboStates.Items.Add("HI");
            cboStates.Items.Add("ID");
            cboStates.Items.Add("IL");
            cboStates.Items.Add("IN");
            cboStates.Items.Add("IA");
            cboStates.Items.Add("KS");
            cboStates.Items.Add("KY");
            cboStates.Items.Add("LA");
            cboStates.Items.Add("ME");
            cboStates.Items.Add("MD");
            cboStates.Items.Add("MH");
            cboStates.Items.Add("MA");
            cboStates.Items.Add("MI");
            cboStates.Items.Add("FM");
            cboStates.Items.Add("MN");
            cboStates.Items.Add("MS");
            cboStates.Items.Add("MO");
            cboStates.Items.Add("MT");
            cboStates.Items.Add("NE");
            cboStates.Items.Add("NV");
            cboStates.Items.Add("NH");
            cboStates.Items.Add("NJ");
            cboStates.Items.Add("NM");
            cboStates.Items.Add("NY");
            cboStates.Items.Add("NC");
            cboStates.Items.Add("ND");
            cboStates.Items.Add("MP");
            cboStates.Items.Add("OH");
            cboStates.Items.Add("OK");
            cboStates.Items.Add("OR");
            cboStates.Items.Add("PW");
            cboStates.Items.Add("PA");
            cboStates.Items.Add("PR");
            cboStates.Items.Add("RI");
            cboStates.Items.Add("SC");
            cboStates.Items.Add("SD");
            cboStates.Items.Add("TN");
            cboStates.Items.Add("TX");
            cboStates.Items.Add("UT");
            cboStates.Items.Add("VT");
            cboStates.Items.Add("VA");
            cboStates.Items.Add("VI");
            cboStates.Items.Add("WA");
            cboStates.Items.Add("WV");
            cboStates.Items.Add("WI");
            cboStates.Items.Add("WY");
        }
        public static void LoadStudents(ComboBox cboStudents)
        {   //Load the Students into the combo box
            String StudentLine;
            System.IO.StreamReader StudentFile = new System.IO.StreamReader("Student.csv");
            while ((StudentLine = StudentFile.ReadLine()) != null)
            {
                Student student = new Student(StudentLine);
                if (student != null)
                {
                    cboStudents.Items.Add(student);
                }
            }
            StudentFile.Close();
        }
        public static void LoadFaculty(ComboBox cboFaculty)
        {   //Load the Faculty into the combo box
            String FacultyLine;
            System.IO.StreamReader FacultyFile = new System.IO.StreamReader("Faculty.csv");
            while ((FacultyLine = FacultyFile.ReadLine()) != null)
            {
                Faculty faculty = new Faculty(FacultyLine);
                if (faculty != null)
                {
                    cboFaculty.Items.Add(faculty);
                }
            }
            FacultyFile.Close();
        }
        public static void LoadCourses(ComboBox cboCourses)
        {   //Load the Courses into the combo box
            String CourseLine;
            System.IO.StreamReader CourseFile = new System.IO.StreamReader("Course.csv");
            while ((CourseLine = CourseFile.ReadLine()) != null)
            {
                Course course = new Course(CourseLine);
                if (course != null)
                {
                    cboCourses.Items.Add(course);
                }
            }
            CourseFile.Close();
        }
        #endregion Load Controls

        #region Singleton Selects
        /// <summary>
        /// Retrieves a single Faculty object from the Faculty CSV file
        /// </summary>
        /// <param name="FacultyID">The unique Faculty ID to be retrieved</param>
        /// <returns>Faculty object</returns>
        public static Faculty GetFaculty(Int16 FacultyID)
        {
            Faculty faculty = null;

            String FacultyLine;
            System.IO.StreamReader FacultyFile = new System.IO.StreamReader("Faculty.csv");
            while ((FacultyLine = FacultyFile.ReadLine()) != null)
            {
                String[] szColumn = FacultyLine.Split(',');
                if (szColumn.Length == 11)
                {
                    if (Convert.ToInt16(szColumn[0]).Equals(FacultyID))
                    {
                        faculty = new Faculty(FacultyLine);
                    }
                }
            }
            FacultyFile.Close();

            return faculty;
        }
        /// <summary>
        /// Retrieves a single Course object from the Course CSV file
        /// </summary>
        /// <param name="CourseID">The unique Course ID to be retrieved</param>
        /// <returns>Course object</returns>
        public static Course GetCourse(Int16 CourseID)
        {
            Course course = null;

            String CourseLine;
            System.IO.StreamReader CourseFile = new System.IO.StreamReader("Course.csv");
            while ((CourseLine = CourseFile.ReadLine()) != null)
            {
                course = new Course(CourseLine);
                if (course.ID.Equals(CourseID))
                {
                    break;
                }
            }
            CourseFile.Close();

            return course;
        }
        /// <summary>
        /// Retrieves a single Student object from the Student CSV file
        /// </summary>
        /// <param name="StudentID">The unique Student ID to be retrieved</param>
        /// <returns>Course object</returns>
        public static Student GetStudent(Int16 StudentID)
        {
            Student student = null;

            String StudentLine;
            System.IO.StreamReader StudentFile = new System.IO.StreamReader("Student.csv");
            while ((StudentLine = StudentFile.ReadLine()) != null)
            {
                student = new Student(StudentLine);
                if (student.ID.Equals(StudentID))
                {
                    break;
                }
            }
            StudentFile.Close();

            return student;
        }
        #endregion Singleton selects

        #region Collection Selects
        /// <summary>
        /// Retrieves a collection of Faculty object from the CourseFaculty CSV file that are instructors for a particular Course
        /// </summary>
        /// <param name="CourseID">The unique Course ID to be searched</param>
        /// <returns>The arraylist of related Faculty objects</returns>
        public static ArrayList GetRelatedFacultyForCourse(Int16 CourseID)
        {
            ArrayList alFaculty = new ArrayList();
            String CourseFacultyLine;
            System.IO.StreamReader CourseFacultyFile = new System.IO.StreamReader("CourseFaculty.csv");
            while ((CourseFacultyLine = CourseFacultyFile.ReadLine()) != null)
            {
                String[] szColumn = CourseFacultyLine.Split(',');
                if (szColumn.Length == 2)
                {
                    if (Convert.ToInt16(szColumn[0]).Equals(CourseID))
                    {
                        Faculty faculty = GetFaculty(Convert.ToInt16(szColumn[1]));
                        if (faculty != null)
                        {
                            alFaculty.Add(faculty);
                        }
                    }
                }
            }
            CourseFacultyFile.Close();

            return alFaculty;
        }
        #endregion Collection Selects
        
        #region Deletes
        /// <summary>
        /// Performs validation of and disk data update routine to allow Student to UnRegister from a Course
        /// </summary>
        /// <param name="StudentID">The unique ID of the Student to be unregistered</param>
        /// <param name="CourseID">The unique ID of the Course the Student is to be unregistered from</param>
        public static void DeleteRegistration(Int16 StudentID, Int16 CourseID)
        {
            //Verify that Student exists
            Course course = Globals.GetCourse(CourseID);
            if (course == null)
            {
                throw new Exception("ERROR: Invalid Course ID (" + CourseID.ToString() + ")");
                //return;
            }
            //Verify that Course exists
            Student student = Globals.GetStudent(StudentID);
            if (student == null)
            {
                throw new Exception("ERROR: Invalid Student ID (" + StudentID.ToString() + ")");
                //return;
            }

            //Ask user to confirm the update
            if (MessageBox.Show("Are you sure you want to UnRegister course number " + course.CourseNumber + " from student named " + student.FirstName + " " + student.LastName + " ?", "Confirm UnRegister", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.No))
            {
                return;
            }

            ArrayList alOutput = new ArrayList();
            //Loop through the registry and output all registrations to an ArrayList except the Student to be UnRegistered
            String RegistrationLine;
            System.IO.StreamReader RegistrationFile = new System.IO.StreamReader("Registration.csv");
            while ((RegistrationLine = RegistrationFile.ReadLine()) != null)
            {
                Registration registration = new Registration(RegistrationLine);
                if ((registration.StudentID.Equals(StudentID)) && (registration.CourseID.Equals(CourseID)))
                {
                }
                else
                {
                    alOutput.Add(RegistrationLine);
                }
            }
            RegistrationFile.Close();

            //Write the ArrayList back to the Registration CSV file without Appending
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Registration.csv", false))
            {
                foreach (String s in alOutput)
                {
                    file.WriteLine(s);
                }
                file.Close();
            }
        }
        /// <summary>
        /// Performs validation of and disk data update routine to allow Faculty to Unlinked from a Course as an Instructor
        /// </summary>
        /// <param name="StudentID">The unique ID of the Faculty to be unlinked</param>
        /// <param name="CourseID">The unique ID of the Course the Student is to be unregistered from</param>
        public static void DeleteCourseFaculty(Int16 CourseID, Int16 FacultyID)
        {
            //Verify that Course exists
            Course course = Globals.GetCourse(CourseID);
            if (course == null)
            {
                throw new Exception("ERROR: Invalid Course ID (" + CourseID.ToString() + ")");
                //return;
            }
            //Verify that Faculty exists
            Faculty faculty = Globals.GetFaculty(FacultyID);
            if (faculty == null)
            {
                throw new Exception("ERROR: Invalid Student ID (" + FacultyID.ToString() + ")");
                //return;
            }

            //Ask user to confirm the update
            if (MessageBox.Show("Are you sure you want to remove the faculty member named " + faculty.FirstName + " " + faculty.LastName + " as an instructor of course number " + course.CourseNumber + " ?", "Confirm Remove Instructor", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.No))
            {
                return;
            }

            ArrayList alOutput = new ArrayList();
            //Loop through the registry and output all CourseFaculty to an ArrayList except the Faculty to be UnLinked
            String CourseFacultyLine;
            System.IO.StreamReader CourseFacultyFile = new System.IO.StreamReader("CourseFaculty.csv");
            while ((CourseFacultyLine = CourseFacultyFile.ReadLine()) != null)
            {
                CourseFaculty coursefaculty = new CourseFaculty(CourseFacultyLine);
                if (coursefaculty != null)
                {
                    if ((coursefaculty.FacultyID.Equals(FacultyID)) && (coursefaculty.CourseID.Equals(CourseID)))
                    {
                    }
                    else
                    {
                        alOutput.Add(CourseFacultyLine);
                    }
                }
            }
            CourseFacultyFile.Close();

            //Write the ArrayList back to the CourseFaculty CSV file without Appending
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("CourseFaculty.csv", false))
            {
                foreach (String s in alOutput)
                {
                    file.WriteLine(s);
                }
                file.Close();
            }
        }
        #endregion Deletes

        #region Referential Integrity checks
        /// <summary>
        /// Validates that a Student Registration exists in the Registration for any Course 
        /// </summary>
        /// <param name="StudentID">The unique ID of the Student to be verified</param>
        /// <returns>True if the Student is registered</returns>
        public static bool StudentIsRegistered(Int16 StudentID)
        {
            bool bResult = false;

            String RegistrationLine;
            System.IO.StreamReader RegistrationFile = new System.IO.StreamReader("Registration.csv");
            while ((RegistrationLine = RegistrationFile.ReadLine()) != null)
            {
                Registration registration = new Registration(RegistrationLine);
                if (registration.StudentID.Equals(StudentID)) 
                {
                    bResult = true;
                    break;
                }
            }
            RegistrationFile.Close();

            return bResult;
        }
        /// <summary>
        /// Validates that a Faculty Registration exists in the Registration for any Course 
        /// </summary>
        /// <param name="StudentID">The unique ID of the Faculty to be verified</param>
        /// <returns>True if the Faculty is registered</returns>
        public static bool FacultyIsRegistered(Int16 FacultyID)
        {
            bool bResult = false;

            String RegistrationLine;
            System.IO.StreamReader RegistrationFile = new System.IO.StreamReader("Registration.csv");
            while ((RegistrationLine = RegistrationFile.ReadLine()) != null)
            {
                Registration registration = new Registration(RegistrationLine);
                if (FacultyTeachesCourse(registration.CourseID, FacultyID))
                {
                    bResult = true;
                    break;
                }
            }
            RegistrationFile.Close();

            return bResult;
        }
        /// <summary>
        /// Validates that a Faculty teaches a Course as indicated in the CourseFaculty CSV file 
        /// </summary>
        /// <param name="FacultyID">The unique ID of the Faculty to be verified</param>
        /// <returns>True if the Faculty teaches the Course</returns>
        public static bool FacultyTeachesCourse(Int16 CourseID, Int16 FacultyID)
        {
            bool bResult = false;

            String CourseFacultyLine;
            System.IO.StreamReader CourseFacultyFile = new System.IO.StreamReader("CourseFaculty.csv");
            while ((CourseFacultyLine = CourseFacultyFile.ReadLine()) != null)
            {
                CourseFaculty coursefaculty = new CourseFaculty(CourseFacultyLine);
                if ((coursefaculty.CourseID.Equals(CourseID)) && (coursefaculty.FacultyID.Equals(FacultyID)))
                {
                    bResult = true;
                    break;
                }
            }
            CourseFacultyFile.Close();

            return bResult;
        }
        /// <summary>
        /// Validates that a Course is scheduled as indicated in the Registration CSV file 
        /// </summary>
        /// <param name="CourseID">The unique ID of the Course to be verified</param>
        /// <returns>True if the Course is scheduled</returns>
        public static bool CourseIsScheduled(Int16 CourseID)
        {
            bool bResult = false;

            String RegistrationLine;
            System.IO.StreamReader RegistrationFile = new System.IO.StreamReader("Registration.csv");
            while ((RegistrationLine = RegistrationFile.ReadLine()) != null)
            {
                Registration registration = new Registration(RegistrationLine);
                if (registration.CourseID.Equals(CourseID))
                {
                    bResult = true;
                    break;
                }
            }
            RegistrationFile.Close();

            return bResult;
        }
        #endregion Referential Integrity checks
    }
}
