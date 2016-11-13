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
    public partial class frmSplash : Form
    {   //This form displays the "Splash" content 
        Int16 nSeconds = 10;    // The number of seconds he Splash is displayed

        #region Constructors
        public frmSplash()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Event handlers
        private void timer1_Tick(object sender, EventArgs e)
        {   //For each second display the countdown to the end-of-life for the splash
            lblTick.Text = "This splash screen will disappear in " + nSeconds.ToString() + " seconds. Or you may click anywhere on this form to close it immediately.";
            nSeconds--;

            //All seconds have elapsed so close the splash
            if (nSeconds == 0)
                this.Close();
        }
        private void frmSplash_Click(object sender, EventArgs e)
        {   //User clicked on the form
            this.Close();
        }
        private void lblTick_Click(object sender, EventArgs e)
        {   //User clicked on the tick label
            this.Close();
        }
        private void lblDescription_Click(object sender, EventArgs e)
        {   //User clicked on the Description label
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {   //User clicked on the picture box
            this.Close();
        }
        #endregion Event handlers
    }
}
