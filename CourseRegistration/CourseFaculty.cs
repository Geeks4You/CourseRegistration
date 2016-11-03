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
    }
}
