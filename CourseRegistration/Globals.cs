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
    {
        public static void LoadStates(ComboBox cboStates)
        {   //Loado the state abbreviations into the combo box
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

        public static Faculty FindFaculty(Int16 FacultyID)
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
                        faculty = new Faculty();
                        faculty.ID = Convert.ToInt16(szColumn[0]);
                        faculty.FirstName = szColumn[1];
                        faculty.LastName = szColumn[2];
                        faculty.Program = szColumn[3];
                        faculty.AddressLine1 = szColumn[4];
                        faculty.AddressLine2 = szColumn[5];
                        faculty.City = szColumn[6];
                        faculty.State = szColumn[7];
                        faculty.Zip = szColumn[8];
                        faculty.Phone = szColumn[9];
                        faculty.Email = szColumn[10];
                    }
                }
            }
            FacultyFile.Close();

            return faculty;
        }

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
                        Faculty faculty = FindFaculty(Convert.ToInt16(szColumn[1]));
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

        public static void LoadStudents(ComboBox cboStudents)
        {
            String StudentLine;
            System.IO.StreamReader StudentFile = new System.IO.StreamReader("Student.csv");
            while ((StudentLine = StudentFile.ReadLine()) != null)
            {
                String[] szColumn = StudentLine.Split(',');
                if (szColumn.Length == 11)
                {
                    Student student = new Student();
                    student.ID = Convert.ToInt16(szColumn[0]);
                    student.FirstName = szColumn[1];
                    student.LastName = szColumn[2];
                    student.Program = szColumn[3];
                    student.AddressLine1 = szColumn[4];
                    student.AddressLine2 = szColumn[5];
                    student.City = szColumn[6];
                    student.State = szColumn[7];
                    student.Zip = szColumn[8];
                    student.Phone = szColumn[9];
                    student.Email = szColumn[10];
                    cboStudents.Items.Add(student);
                }
            }
            StudentFile.Close();
        }

        public static void LoadFaculty(ComboBox cboFaculty)
        {
            String FacultyLine;
            System.IO.StreamReader FacultyFile = new System.IO.StreamReader("Faculty.csv");
            while ((FacultyLine = FacultyFile.ReadLine()) != null)
            {
                String[] szColumn = FacultyLine.Split(',');
                if (szColumn.Length == 11)
                {
                    Faculty faculty = new Faculty();
                    faculty.ID = Convert.ToInt16(szColumn[0]);
                    faculty.FirstName = szColumn[1];
                    faculty.LastName = szColumn[2];
                    faculty.Program = szColumn[3];
                    faculty.AddressLine1 = szColumn[4];
                    faculty.AddressLine2 = szColumn[5];
                    faculty.City = szColumn[6];
                    faculty.State = szColumn[7];
                    faculty.Zip = szColumn[8];
                    faculty.Phone = szColumn[9];
                    faculty.Email = szColumn[10];
                    cboFaculty.Items.Add(faculty);
                }
            }
            FacultyFile.Close();
        }

        public static void LoadCourses(ComboBox cboCourses)
        {
            String CourseLine;
            System.IO.StreamReader CourseFile = new System.IO.StreamReader("Course.csv");
            while ((CourseLine = CourseFile.ReadLine()) != null)
            {
                String[] szColumn = CourseLine.Split(',');
                if (szColumn.Length == 7)
                {
                    Course course = new Course();
                    course.ID = Convert.ToInt16(szColumn[0]);
                    course.CourseNumber = szColumn[1];
                    course.CourseDescription = szColumn[2];
                    course.StartDate = szColumn[3];
                    course.EndDate = szColumn[4];
                    course.Location = szColumn[5];
                    course.Credits = szColumn[6];
                    cboCourses.Items.Add(course);
                }
            }
            CourseFile.Close();
        }

        public static Course GetCourse(Int16 CourseID)
        {
            Course course = null;

            String CourseLine;
            System.IO.StreamReader CourseFile = new System.IO.StreamReader("Course.csv");
            while ((CourseLine = CourseFile.ReadLine()) != null)
            {
                String[] szColumn = CourseLine.Split(',');
                if (szColumn.Length == 7)
                {
                    if (Convert.ToInt16(szColumn[0]).Equals(CourseID))
                    {
                        course = new Course();
                        course.ID = Convert.ToInt16(szColumn[0]);
                        course.CourseNumber = szColumn[1];
                        course.CourseDescription = szColumn[2];
                        course.StartDate = szColumn[3];
                        course.EndDate = szColumn[4];
                        course.Location = szColumn[5];
                        course.Credits = szColumn[6];
                    }
                }
            }
            CourseFile.Close();

            return course;
        }

        public static void DeleteRegistration(Int16 StudentID, Int16 CourseID)
        {
            ArrayList alOutput = new ArrayList();

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
                    if ((registration.StudentID.Equals(StudentID)) && (registration.CourseID.Equals(CourseID)))
                    {
                    }
                    else
                    {
                        alOutput.Add(RegistrationLine);
                    }
                }
            }
            RegistrationFile.Close();

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Registration.csv", false))
            {
                foreach (String s in alOutput)
                {
                    file.WriteLine(s);
                }
                file.Close();
            }
        }
    }
}
