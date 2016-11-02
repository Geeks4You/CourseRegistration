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
    {
        public frmMaintainFaculty()
        {
            InitializeComponent();
        }

        private void frmMaintainFaculty_Load(object sender, EventArgs e)
        {
            Globals.LoadStates(cboState);
            LoadFacultyFromFile();
        }

        private void ClearForm()
        {   //Clear out all the fields on the form
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtProgram.Text = String.Empty;
            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtCity.Text = String.Empty;
            cboState.SelectedIndex = -1;
            mtbZip.Text = String.Empty;
            mtbPhone.Text = String.Empty;
        }

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

        private void SaveFaculty()
        {   //Format a Faculty object and save it in the ListBox
            Faculty faculty = new Faculty();
            faculty.FirstName = txtFirstName.Text;
            faculty.LastName = txtLastName.Text;
            faculty.Program = txtProgram.Text;
            faculty.AddressLine1 = txtAddressLine1.Text;
            faculty.AddressLine2 = txtAddressLine2.Text;
            faculty.City = txtCity.Text;
            faculty.State = cboState.SelectedItem.ToString();
            faculty.Zip = mtbZip.Text;
            faculty.Phone = mtbPhone.Text;
            faculty.Email = txtEmail.Text;

            if (lstFaculty.SelectedIndex > -1)
            {
                faculty.ID = -1;
                lstFaculty.Items[lstFaculty.SelectedIndex] = faculty;
            }
            else
            {
                faculty.ID = lstFaculty.Items.Count + 1;
                lstFaculty.Items.Add(faculty);
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {   //Set up the form and to receive data for a new client
            lstFaculty.SelectedIndex = -1;
            cmdNew.Enabled = false;

            ClearForm();
            txtFirstName.Focus();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {   //User clicked Save, so validate the fields and save the Client in the client store if good data
            if (ValidInput())
            {
                SaveFaculty();
                SaveFacultyToFile();
                cmdNew.Enabled = true;
                cmdSave.Enabled = false;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtProgram_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtAddressLine1_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtAddressLine2_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void mtbZip_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void mtbPhone_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {   //Delete the client from the ListBox
            if (MessageBox.Show("Are you sure you want to delete this Faculty member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                lstFaculty.Items.Remove(lstFaculty.SelectedItem);
                ClearForm();
                SaveFacultyToFile();
            }
        }

        private void lstFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lstFaculty.SelectedIndex > -1))
            {
                // When the user clicks on an existing user, populate the form from the faculty store
                Faculty faculty = FindFaculty(lstFaculty.SelectedIndex);
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

        private Faculty FindFaculty(Int32 nIndex)
        {   //Locate a Faculty object in the ListBox Faculty store
            Faculty faculty = new Faculty();

            faculty = (Faculty) lstFaculty.Items[nIndex];

            return faculty;
        }

        private void PopulateFormFromFaculty(Faculty faculty)
        {   // Populate the fields from the Faculty object
            txtFirstName.Text = faculty.FirstName;
            txtLastName.Text = faculty.LastName;
            txtProgram.Text = faculty.Program;
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
        }

        private void LoadFacultyFromFile()
        {

            String line;
            System.IO.StreamReader file = new System.IO.StreamReader("Faculty.csv");
            while ((line = file.ReadLine()) != null)
            {
                String[] szColumn = line.Split(',');
                Faculty faculty = new Faculty();
                faculty.ID = Convert.ToInt16(szColumn[0]);
                faculty.FirstName = szColumn[1];
                faculty.LastName = szColumn[2];
                faculty.Program = szColumn[3];
                faculty.AddressLine1 = szColumn[4];
                faculty.AddressLine2 = szColumn[5];
                faculty.City = szColumn[6];
                faculty.State = szColumn[7];
                faculty.Zip = szColumn[8];
                faculty.Phone = szColumn[9];
                faculty.Email = szColumn[10];
                lstFaculty.Items.Add(faculty);
            }
            file.Close();
        }

        private void SaveFacultyToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Faculty.csv"))
            {
                foreach (Faculty faculty in lstFaculty.Items)
                {
                    String line = String.Empty;
                    line += faculty.ID.ToString() + ",";
                    line += faculty.FirstName + ",";
                    line += faculty.LastName + ",";
                    line += faculty.Program + ",";
                    line += faculty.AddressLine1 + ",";
                    line += faculty.AddressLine2 + ",";
                    line += faculty.City + ",";
                    line += faculty.State + ",";
                    line += faculty.Zip + ",";
                    line += faculty.Phone + ",";
                    line += faculty.Email;

                    file.WriteLine(line);
                }
            }        
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but Help is not available yet.", "Help Clicked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
