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
    public partial class CourseRegistration : Form
    {
        public CourseRegistration()
        {
            InitializeComponent();
        }

        private void CourseRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainFaculty fMaintainFaculty = new frmMaintainFaculty();
            fMaintainFaculty.MdiParent = this;
            fMaintainFaculty.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainCourse fMaintainCourse = new frmMaintainCourse();
            fMaintainCourse.MdiParent = this;
            fMaintainCourse.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fAbout = new frmAbout();
            fAbout.ShowDialog();
        }

        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
