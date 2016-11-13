using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration
{
    class CourseFaculty
    {
        Int16 _CourseID;
        public Int16 CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
        Int16 _FacultyID;
        public Int16 FacultyID
        {
            get { return _FacultyID; }
            set { _FacultyID = value; }
        }

        #region Constructors
        public CourseFaculty()
        { 
        }
        /// <summary>
        /// Create a CourseFaculty object from a string record in the CSV file
        /// </summary>
        /// <param name="StudentLine">A comman delimited string representing each attribute in a CourseFaculty object</param>
        public CourseFaculty(String CourseFacultyLine)
        {
            String[] szColumn = CourseFacultyLine.Split(',');
            if (szColumn.Length == 2)
            {
                this.CourseID = Convert.ToInt16(szColumn[0]);
                this.FacultyID = Convert.ToInt16(szColumn[1]);

            }
            else
            {
                throw new Exception("ERROR: CourseFaculty cannot be instantiated due to incorrect number of data elements. Expecting 2, found " + szColumn.Length.ToString());
            }
        }
        #endregion Constructors

        #region Helper functions
        /// <summary>
        /// Convert a CourseFaculty to a string record for the CSV file
        /// </summary>
        /// <returns>The record string</returns>
        public string ToRecord()
        {
            string szRecord = string.Empty;

            szRecord += this.CourseID.ToString() + ",";
            szRecord += this.FacultyID.ToString();
            return szRecord;
        }
        #endregion Helper functions
    }
}
