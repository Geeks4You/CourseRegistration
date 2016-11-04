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
    }
}
