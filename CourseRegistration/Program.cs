using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    /*  Program Name:   CourseRegistration
        *  Programmer:     Learning Team C
        *  Date:           11-14-2016
        *  Description:    This program will be a Windows Forms application. Design an interface that is professional 
        *  looking and intuitive to use for the novice end user.
        *  The Main menu should offer choices including, but not limited to:
            •	Adding students
            •	Adding faculty members
            •	Adding courses
            •	Registering students to course(s)
            •	Printing a registration report 
            •	Exiting Program
        *  No code is necessary behind each menu option at this time. If you would like, when the user selects a given 
        *  option, you can display a messagebox such as "Adding Courses menu option selected".
        */
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CourseRegistration());
        }
    }
}
