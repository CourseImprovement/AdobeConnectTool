using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdobeConnectTool
{
    /// <summary>
    /// The ProcessCourseGroups class is the controller for 
    /// the form that starts the process of course group 
    /// creation.
    /// </summary>
    public partial class ProcessCourseGroups : Form
    {
        private bool _drag;
        private Point _firstPoint;

        public ProcessCourseGroups()
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

        private void processCourseGroupsBackBtn_Click(object sender, EventArgs e)
        {
            Program._courseGroups.Show();
            this.Hide();
        }

        private void processCourseGroupsStartBtn_Click(object sender, EventArgs e)
        {
            Program._openFileDialog.ShowDialog();

            string file = Program._openFileDialog.FileName;
            if (file != "File Not Found")
            {
                Program._process.Show();
                this.Hide();
                Program._process.SetFile(file);
                Program._process.StartMeetingCreation();
            }
        }

        private void processCourseGroupsHomeBtn_Click(object sender, EventArgs e)
        {
            Program._mainMenu.Show();
            this.Hide();
        }

        private void processCourseGroupsCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
