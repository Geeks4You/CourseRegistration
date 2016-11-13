using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    public partial class frmMaintainStudents : Form
    {   //This form displays the "Student Maintenance" window 

        #region Constructors
        public frmMaintainStudents()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Event Handlers
        /// <summary>
        /// When the form loads, load the state codes, initialize the Student listbox, Maximize the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaintainStudents_Load(object sender, EventArgs e)
        {
            Globals.LoadStates(cboState);
            LoadStudentFromFile();
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Set up the form to receive data for a new Student when the user clicks the New button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNew_Click(object sender, EventArgs e)
        {   //Set up the form and to receive data for a new client
            lstStudent.SelectedIndex = -1;
            cmdNew.Enabled = false;

            ClearForm();
            txtFirstName.Focus();
        }
        /// <summary>
        /// When the user clicks Save, validate the data, create a Student object, save the Faculty in the data file and set various button's disposition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {   //User clicked Save, so validate the fields and save the Client in the client store if good data
            if (ValidInput())
            {
                SaveStudent();
                SaveStudentsToFile();
                cmdNew.Enabled = true;
                cmdSave.Enabled = false;
            }
        }
        /// <summary>
        /// First Name text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Last Name text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Program text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProgram_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// AddressLine1 text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddressLine1_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// AddressLine2 text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddressLine2_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// City text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// State selected index changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Zip text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbZip_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Phone text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbPhone_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// Email text changed so enable the Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }
        /// <summary>
        /// User clicked Delete. Confirm the user's intent, if the Student is not currently schedule, remove from the listbox, clear the form and update the Student CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDelete_Click(object sender, EventArgs e)
        {   //Delete the client from the ListBox
            if (MessageBox.Show("Are you sure you want to delete this Students member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                Student student = (Student) lstStudent.SelectedItem;
                if (Globals.StudentIsRegistered(student.ID))
                {
                    MessageBox.Show(student.FirstName + " " + student.LastName + " is currently registered in a course. Please UnRegister the student before attempting to delete him or her.", "Related Data Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    lstStudent.Items.Remove(lstStudent.SelectedItem);
                    ClearForm();
                    SaveStudentsToFile();
                }
            }
        }
        /// <summary>
        /// User clicked on a Student in the listbox, so populate the form from the Student and set various control's dispositions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lstStudent.SelectedIndex > -1))
            {
                // When the user clicks on an existing user, populate the form from the Students store
                Student student = FindStudent(Convert.ToInt16(lstStudent.SelectedIndex));
                PopulateFormFromStudent(student);
                cmdDelete.Enabled = true;
            }
            else
            {
                // Nothing was selected, so clear the form
                ClearForm();
                cmdDelete.Enabled = false;
                cmdSave.Enabled = false;
            }
        }
        /// <summary>
        /// User clicked the Help button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but Help is not available yet.", "Help Clicked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// User clicked the Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Event Handlers

        #region Helper Functions
        /// <summary>
        /// Clears all the data enterable controls on the form
        /// </summary>
        private void ClearForm()
        {   //Clear out all the fields on the form
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            cboProgram.Text = String.Empty;
            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtCity.Text = String.Empty;
            cboState.SelectedIndex = -1;
            mtbZip.Text = String.Empty;
            mtbPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtID.Text = String.Empty;
        }
        /// <summary>
        /// Validates the data enterable controls for minimum validity
        /// </summary>
        /// <returns></returns>
        private Boolean ValidInput()
        {   //The only requirement is a first name, last name and state selection at this point in time
            if (txtFirstName.Text.Equals(String.Empty))
            {
                System.Windows.Forms.MessageBox.Show("You must provide a first name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLastName.Text.Equals(String.Empty))
            {
                System.Windows.Forms.MessageBox.Show("You must provide a last name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboState.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("You must select a state.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /// <summary>
        /// Format a Student object from the data enterable controls and save it in the ListBox
        /// </summary>
        private void SaveStudent()
        {   //Format a Students object and save it in the ListBox
            Student student = new Student();
            if (lstStudent.SelectedIndex > -1)
            {
                student = (Student)lstStudent.Items[lstStudent.SelectedIndex];
            }
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Program = cboProgram.Text;
            student.AddressLine1 = txtAddressLine1.Text;
            student.AddressLine2 = txtAddressLine2.Text;
            student.City = txtCity.Text;
            student.State = cboState.SelectedItem.ToString();
            student.Zip = mtbZip.Text;
            student.Phone = mtbPhone.Text;
            student.Email = txtEmail.Text;

            if (lstStudent.SelectedIndex > -1)
            {
                lstStudent.Items[lstStudent.SelectedIndex] = student;
            }
            else
            {
                student.ID = GetNextID();
                lstStudent.Items.Add(student);
            }
        }
        /// <summary>
        /// Read through the Faculty saving the maximum ID in use and increment by 1
        /// </summary>
        /// <returns></returns>
        private Int16 GetNextID()
        {
            Int16 nID = -1;

            String line;
            System.IO.StreamReader file = new System.IO.StreamReader("Student.csv");
            while ((line = file.ReadLine()) != null)
            {
                String[] szColumn = line.Split(',');
                if (Convert.ToInt16(szColumn[0]) > nID)
                {
                    nID = Convert.ToInt16(szColumn[0]);
                }
            }
            file.Close();
            
            nID++;
            return nID;
        }
        /// <summary>
        /// Locate a Student object in the ListBox Faculty store
        /// </summary>
        /// <param name="nIndex">The index of the Student listbox control</param>
        /// <returns>The Student object related to the nIndex</returns>
        private Student FindStudent(Int16 nIndex)
        {   //Locate a Students object in the ListBox Students store
            Student student = new Student();

            student = (Student)lstStudent.Items[nIndex];

            return student;
        }
        /// <summary>
        /// Populate the data enterable controls from a Student object
        /// </summary>
        /// <param name="student"></param>
        private void PopulateFormFromStudent(Student student)
        {   // Populate the fields from the Students object
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            cboProgram.Text = student.Program;
            txtAddressLine1.Text = student.AddressLine1;
            txtAddressLine2.Text = student.AddressLine2;
            txtCity.Text = student.City;
            foreach (string State in cboState.Items)
            {
                if (student.State.Equals(State))
                {
                    cboState.SelectedItem = State;
                    break;
                }

            }

            mtbZip.Text = student.Zip;
            mtbPhone.Text = student.Phone;
            txtEmail.Text = student.Email;
            txtID.Text = student.ID.ToString();
        }
        /// <summary>
        /// Write the contents of the items in the Student listbox to the Student CSV file
        /// </summary>
        private void LoadStudentFromFile()
        {
            String line;
            System.IO.StreamReader file = new System.IO.StreamReader("Student.csv");
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    Student student = new Student(line);
                    if (student != null)
                    {
                        lstStudent.Items.Add(student);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Exception Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            file.Close();
        }
        /// <summary>
        /// Append a Student object to the Faculty CSV file
        /// </summary>
        private void SaveStudentsToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Student.csv"))
            {
                foreach (Student student in lstStudent.Items)
                {
                    file.WriteLine(student.ToRecord());
                }
            }        
        }
        #endregion Helper Functions
    }
}
