using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration
{
    public static class Globals
    {
        public static void LoadStates(System.Windows.Forms.ComboBox cboStates)
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
    }
}
