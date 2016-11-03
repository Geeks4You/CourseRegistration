using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseRegistration
{
    class Course
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

        public override string ToString()
        {
            return CourseNumber + ", " + _CourseDescription;
        }
    }
}