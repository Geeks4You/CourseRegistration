using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration
{
    public class Student
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

        #region Constructors
        public Student()
        { 
        }
        /// <summary>
        /// Create a Student object from a string record in the CSV file
        /// </summary>
        /// <param name="StudentLine">A comman delimited string representing each attribute in a Student object</param>
        public Student(String StudentLine)
        {
            String[] szColumn = StudentLine.Split(',');
            if (szColumn.Length == 11)
            {
                this.ID = Convert.ToInt16(szColumn[0]);
                this.FirstName = szColumn[1];
                this.LastName = szColumn[2];
                this.Program = szColumn[3];
                this.AddressLine1 = szColumn[4];
                this.AddressLine2 = szColumn[5];
                this.City = szColumn[6];
                this.State = szColumn[7];
                this.Zip = szColumn[8];
                this.Phone = szColumn[9];
                this.Email = szColumn[10];
            }
            else
            {
                throw new Exception("ERROR: Student cannot be instantiated due to incorrect number of data elements. Expecting 11, found " + szColumn.Length.ToString());
            }
        }
        #endregion Constructors

        #region Overrides
        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
        #endregion Overrides

        #region Helper functions
        /// <summary>
        /// Convert a Student to a string record for the CSV file
        /// </summary>
        /// <returns>The record string</returns>
        public string ToRecord()
        {
            string szRecord = string.Empty;

            szRecord += this.ID.ToString() + ",";
            szRecord += this.FirstName.Replace(",", "") + ",";
            szRecord += this.LastName.Replace(",", "") + ",";
            szRecord += this.Program.Replace(",", "") + ",";
            szRecord += this.AddressLine1.Replace(",", "") + ",";
            szRecord += this.AddressLine2.Replace(",", "") + ",";
            szRecord += this.City.Replace(",", "") + ",";
            szRecord += this.State.Replace(",", "") + ",";
            szRecord += this.Zip.Replace(",", "") + ",";
            szRecord += this.Phone.Replace(",", "") + ",";
            szRecord += this.Email.Replace(",", "");
            return szRecord;
        }
        #endregion Helper functions
    }
}
