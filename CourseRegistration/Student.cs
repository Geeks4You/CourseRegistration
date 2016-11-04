using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration
{
    class Student
    {
        Int16 _ID;
        public Int16 ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        string _Program;
        public string Program
        {
            get { return _Program; }
            set { _Program = value; }
        }
        string _AddressLine1;
        public string AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }
        string _AddressLine2;
        public string AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }
        string _City;
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        string _State;
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        string _Zip;
        public string Zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }
        string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
    }
}
