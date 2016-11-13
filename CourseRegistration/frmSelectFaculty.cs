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
    public partial class frmSelectFaculty : Form
    {   //This form displays the "Select Faculty" popup window 

        #region Constructors
        public frmSelectFaculty()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Event handlers
        /// <summary>
        /// When form loads, populate the combo box with all existing Faculty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSelectFaculty_Load(object sender, EventArgs e)
        {
            Globals.LoadFaculty(cboFaculty);
        }
        /// <summary>
        /// When a Faculty is selected, enable the "Select" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdSelect.Enabled = (cboFaculty.SelectedIndex > -1);
        }
        #endregion Event handlers
    }
}
