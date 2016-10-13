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
    /// 
    /// The CourseList class is the controller for the form 
    /// view that shows a list of all the courses that should 
    /// have groups in Adobe Connect.
    /// 
    public partial class CourseList : Form
    {
        private bool _drag;
        private Point _firstPoint;
        private List<Course> _courses;

        public CourseList()
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

        private void courseListNoBtn_Click(object sender, EventArgs e)
        {
            Program._replaceCourseList.Show();
            this.Hide();
        }

        private void courseListYesBtn_Click(object sender, EventArgs e)
        {
            Program._courseGroups.Show();
            this.Hide();
        }

        private void courseListHomeBtn_Click(object sender, EventArgs e)
        {
            Program._mainMenu.Show();
            this.Hide();
        }

        private void courseListCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetListOfCourses()
        {
            this.ListOfCourses.Text = "";
            _courses = LookupTable.GetLookupTable();
            CurrentLookupTable_Load();
        }

        /// 
        /// BUILD TREE OF THE COURSES AND THERE INFORMATION
        /// 
        private void CurrentLookupTable_Load()
        {
            foreach (Course course in _courses)
            {
                this.ListOfCourses.Text += course.GetName() + ":  " + course.GetNumberOfMeetings() + " meetings\r\n";
            }
        }

        private void CourseList_VisibleChanged(object sender, EventArgs e)
        {
            SetListOfCourses();
        }
    }
}
