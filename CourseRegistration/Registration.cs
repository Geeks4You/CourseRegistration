using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration
{
    class Registration
    {
        Int16 _StudentID;
        public Int16 StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        Int16 _CourseID;
        public Int16 CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }

        #region Constructors
        public Registration()
        {  
        }
        /// <summary>
        /// Create a Registration object from a string record in the CSV file
        /// </summary>
        /// <param name="StudentLine">A comman delimited string representing each attribute in a Student object</param>
        public Registration(String RegistrationLine)
        {
            String[] szColumn = RegistrationLine.Split(',');
            if (szColumn.Length == 2)
            {
                this.StudentID = Convert.ToInt16(szColumn[0]);
                this.CourseID = Convert.ToInt16(szColumn[1]);
            }
            else
            {
                throw new Exception("ERROR: Registration cannot be instantiated due to incorrect number of data elements. Expecting 2, found " + szColumn.Length.ToString());
            }
        }
        #endregion Constructors

        #region Helper functions
        /// <summary>
        /// Convert a Registration to a string record for the CSV file
        /// </summary>
        /// <returns>The record string</returns>
        public string ToRecord()
        {
            string szRecord = string.Empty;

            szRecord += this.StudentID.ToString() + ",";
            szRecord += this.CourseID.ToString();
            return szRecord;
        }
        #endregion Helper functions
    }
}
