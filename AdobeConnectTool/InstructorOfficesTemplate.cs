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
    /// The InstructorOfficesTemplate class is the controller 
    /// for the form that allows the user to download the 
    /// template to process instructor offices.
    /// 
    public partial class InstructorOfficesTemplate : Form
    {
        private bool _drag;
        private Point _firstPoint;

        public InstructorOfficesTemplate()
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

        private void instructorOfficesTemplateBackBtn_Click(object sender, EventArgs e)
        {
            Program._instructorOffices.Show();
            this.Hide();
        }

        private void instructorOfficesTemplateDownloadBtn_Click(object sender, EventArgs e)
        {
            Program._saveFileDialog.ShowDialog();
            Program._instructorOffices.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program._mainMenu.Show();
            this.Hide();
        }
    }
}
