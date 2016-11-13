using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseRegistration
{
    public class Course
    {
        Int16 _ID;
        public Int16 ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        string _CourseNumber;
        public string CourseNumber
        {
            get { return _CourseNumber; }
            set { _CourseNumber = value; }
        }
        string _CourseDescription;
        public string CourseDescription
        {
            get { return _CourseDescription; }
            set { _CourseDescription = value; }
        }
        string _StartDate;
        public string StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        string _EndDate;
        public string EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        string _Location;
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        string _Credits;
        public string Credits
        {
            get { return _Credits; }
            set { _Credits = value; }
        }

        #region Constructors
        public Course()
        { 
        
        }
        /// <summary>
        /// Create a Course object from a string record in the CSV file
        /// </summary>
        /// <param name="CourseLine">A comman delimited string representing each attribute in a Course object</param>
        public Course(String CourseLine)
        {
            String[] szColumn = CourseLine.Split(',');
            if (szColumn.Length == 7)
            {
                this.ID = Convert.ToInt16(szColumn[0]);
                this.CourseNumber = szColumn[1];
                this.CourseDescription = szColumn[2];
                this.StartDate = szColumn[3];
                this.EndDate = szColumn[4];
                this.Location = szColumn[5];
                this.Credits = szColumn[6];
            }
            else
            {
                throw new Exception("ERROR: Course cannot be instantiated due to incorrect number of data elements. Expecting 7, found " + szColumn.Length.ToString());
            }
        }
        #endregion Constructors

        #region Overrides
        /// <summary>
        /// Represents a course as its name and its description
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return CourseNumber + ", " + _CourseDescription;
        }
        #endregion Overrides

        #region Helper functions
        /// <summary>
        /// Convert a Course to a string record for the CSV file
        /// </summary>
        /// <returns>The record string</returns>
        public string ToRecord()
        {
            string szRecord = string.Empty;

            szRecord += this.ID.ToString() + ",";
            szRecord += this.CourseNumber.Replace(",", "") + ",";
            szRecord += this.CourseDescription.Replace(",", "") + ",";
            szRecord += this.StartDate.Replace(",", "") + ",";
            szRecord += this.EndDate.Replace(",", "") + ",";
            szRecord += this.Location.Replace(",", "") + ",";
            szRecord += this.Credits.Replace(",", "");
            return szRecord;
        }
        #endregion Helper functions
    }
}