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
    public partial class frmMaintainFaculty : Form
    {   //This form displays the "Faculty Maintenance" window 

        #region Constructors
        public frmMaintainFaculty()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Event Handlers
        /// <summary>
        /// When the form loads, load the state codes, initialize the Faculty listbox, Maximize the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaintainFaculty_Load(object sender, EventArgs e)
        {
            Globals.LoadStates(cboState);
            LoadFacultyFromFile();
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Set up the form to receive data for a new Faculty when the user clicks the New button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNew_Click(object sender, EventArgs e)
        {   //Set up the form and to receive data for a new Faculty
            lstFaculty.SelectedIndex = -1;
            cmdNew.Enabled = false;

            ClearForm();
            txtFirstName.Focus();
        }
        /// <summary>
        /// When the user clicks Save, validate the data, create a Faculty object, save the Faculty in the data file and set various button's disposition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {   //User clicked Save, so validate the fields and save the Faculty in the Faculty store if good data
            if (ValidInput())
            {
                SaveFaculty();
                SaveFacultyToFile();
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
        /// AddressLine12text changed so enable the Save button
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
        /// User clicked Delete. Confirm the user's intent, if the Faculty is not currently schedule, remove from the listbox, clear the form and update the Faculty CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDelete_Click(object sender, EventArgs e)
        {   //Delete the client from the ListBox
            if (MessageBox.Show("Are you sure you want to delete this Faculty member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                Faculty faculty = (Faculty) lstFaculty.SelectedItem;
                if (Globals.FacultyIsRegistered(faculty.ID))
                {
                    MessageBox.Show(faculty.FirstName + " " + faculty.LastName + " is currently registered to teach a course. Please DeLink the faculty from the course before attempting to delete him or her.", "Related Data Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    lstFaculty.Items.Remove(lstFaculty.SelectedItem);
                    ClearForm();
                    SaveFacultyToFile();
                }
            }
        }
        /// <summary>
        /// User clicked on a Faculty in the listbox, so populate the form from the Faculty and set various control's dispositions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lstFaculty.SelectedIndex > -1))
            {
                // When the user clicks on an existing user, populate the form from the faculty store
                Faculty faculty = FindFaculty(Convert.ToInt16(lstFaculty.SelectedIndex));
                PopulateFormFromFaculty(faculty);
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
        /// Format a Faculty object from the data enterable controls and save it in the ListBox
        /// </summary>
        private void SaveFaculty()
        {   //Format a Faculty object and save it in the ListBox
            Faculty faculty = new Faculty();
            if (lstFaculty.SelectedIndex > -1)
            {
                faculty = (Faculty) lstFaculty.Items[lstFaculty.SelectedIndex];
            }
            faculty.FirstName = txtFirstName.Text;
            faculty.LastName = txtLastName.Text;
            faculty.Program = cboProgram.Text;
            faculty.AddressLine1 = txtAddressLine1.Text;
            faculty.AddressLine2 = txtAddressLine2.Text;
            faculty.City = txtCity.Text;
            faculty.State = cboState.SelectedItem.ToString();
            faculty.Zip = mtbZip.Text;
            faculty.Phone = mtbPhone.Text;
            faculty.Email = txtEmail.Text;

            if (lstFaculty.SelectedIndex > -1)
            {
                lstFaculty.Items[lstFaculty.SelectedIndex] = faculty;
            }
            else
            {
                faculty.ID = GetNextID();
                lstFaculty.Items.Add(faculty);
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
            System.IO.StreamReader file = new System.IO.StreamReader("Faculty.csv");
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
        /// Locate a Faculty object in the ListBox Faculty store
        /// </summary>
        /// <param name="nIndex">The index of the Course listbox control</param>
        /// <returns>The Faculty object related to the nIndex</returns>
        private Faculty FindFaculty(Int16 nIndex)
        {   //Locate a Faculty object in the ListBox Faculty store
            Faculty faculty = new Faculty();

            faculty = (Faculty) lstFaculty.Items[nIndex];

            return faculty;
        }
        /// <summary>
        /// Populate the data enterable controls from a Faculty object
        /// </summary>
        /// <param name="faculty"></param>
        private void PopulateFormFromFaculty(Faculty faculty)
        {   // Populate the fields from the Faculty object
            txtFirstName.Text = faculty.FirstName;
            txtLastName.Text = faculty.LastName;
            cboProgram.Text = faculty.Program;
            txtAddressLine1.Text = faculty.AddressLine1;
            txtAddressLine2.Text = faculty.AddressLine2;
            txtCity.Text = faculty.City;
            foreach (string State in cboState.Items)
            {
                if (faculty.State.Equals(State))
                {
                    cboState.SelectedItem = State;
                    break;
                }

            }

            mtbZip.Text = faculty.Zip;
            mtbPhone.Text = faculty.Phone;
            txtEmail.Text = faculty.Email;
            txtID.Text = faculty.ID.ToString();
        }
        /// <summary>
        /// Write the contents of the items in the Faculty listbox to the Faculty CSV file
        /// </summary>
        private void LoadFacultyFromFile()
        {
            String line;
            System.IO.StreamReader file = new System.IO.StreamReader("Faculty.csv");
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    Faculty faculty = new Faculty(line);
                    if (faculty != null)
                    {
                        lstFaculty.Items.Add(faculty);
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
        /// Append a Faculty object to the Faculty CSV file
        /// </summary>
        private void SaveFacultyToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Faculty.csv"))
            {
                foreach (Faculty faculty in lstFaculty.Items)
                {
                    file.WriteLine(faculty.ToRecord());
                }
            }        
        }
        #endregion Helper Functions

    }
}
