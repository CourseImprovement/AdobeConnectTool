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
    /// The ProcessCourseList class is the controller for 
    /// the form that loads a spreadsheet, which updates 
    /// the courselist.
    /// 
    public partial class ProcessCourseList : Form
    {
        private bool _drag;
        private Point _firstPoint;

        public ProcessCourseList()
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

        private void processCourseListBackBtn_Click(object sender, EventArgs e)
        {
            Program._replaceCourseList.Show();
            this.Hide();
        }

        private void processCourseListStartBtn_Click(object sender, EventArgs e)
        {
            List<Course> courses = LookupTable.GetLookupTable();
            Program._openFileDialog.ShowDialog();
            string file = Program._openFileDialog.FileName;
            if (file != "File Not Found")
            {
                LookupTable lt = new LookupTable(courses);
                
                lt.SetExcelDocument(file);
                if (!lt.IsValid())
                {
                    lt.Valid();
                    MessageBox.Show("Please use an Excel file with the .xlsx extension.", "Error", MessageBoxButtons.OK);
                    return;
                }
                
                lt.CompareExcelDocumentAndLookupTable();
                if (!lt.IsValid())
                {
                    lt.Valid();
                    MessageBox.Show("Please use an Excel file with the following columns:\r\nCourse Name | Number of Meetings", "Error", MessageBoxButtons.OK);
                    return;
                }
                
                lt.SaveAsXML();
                courses = LookupTable.GetLookupTable();
                MessageBox.Show("The Course Lookup Table has been updated.", "Update Complete", MessageBoxButtons.OK);
            }
            Program._courseList.Show();
            this.Hide();
        }

        private void processCourseListCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void processCoruseListHomeBtn_Click(object sender, EventArgs e)
        {
            Program._mainMenu.Show();
            this.Hide();
        }
    }
}
