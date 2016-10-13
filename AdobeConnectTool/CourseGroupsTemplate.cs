using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdobeConnectTool
{
    /// 
    /// The CourseGroupsTemplate class controls the form that 
    /// downloads the template to create folders for courses.
    /// 
    public partial class CourseGroupsTemplate : Form
    {
        private bool _drag;
        private Point _firstPoint;

        public CourseGroupsTemplate()
        {
            InitializeComponent();
        }

        ///////////////
        // Move Form //
        ///////////////

        /// 
        /// ENABLE DRAG WHILE THE MOURSE IS DOWN AND GATHER MOUSE LOCATION DATA
        ///
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _drag = true;
            _firstPoint = e.Location;
        }

        /// 
        /// MOVE THE FORM WHILE THE MOUSE IS DOWN AND MOVING
        ///
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drag)
            {
                // Get the difference between the two points
                int xDiff = _firstPoint.X - e.Location.X;
                int yDiff = _firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        /// 
        /// STOP DRAG WHILE THE MOUSE IS UP
        ///
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _drag = false;
        }

        private void courseGroupsTemplateBackBtn_Click(object sender, EventArgs e)
        {
            Program._courseGroups.Show();
            this.Hide();
        }

        private void courseGroupsTemplateDownloadBtn_Click(object sender, EventArgs e)
        {
            Program._saveFileDialog.ShowDialog();

            string file = Program._saveFileDialog.FileName;
            if (file != "Course_Creation_Template.xlsx" && file != "")
            {
                File.Copy("Course_Creation_Template.xlsx", file);
                File.SetAttributes(file, FileAttributes.Normal);
                Program._courseGroups.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("For you!", "kudos", MessageBoxButtons.OK);
            }
        }

        private void courseGroupsTemplateCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void courseGroupsTemplateHomeBtn_Click(object sender, EventArgs e)
        {
            Program._mainMenu.Show();
            this.Hide();
        }
    }
}
