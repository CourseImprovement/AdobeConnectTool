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
    /// The Process class is the controller for the form that runs the proper methods to create course groups or instructor offices.
    /// 
    public partial class Process : Form
    {
        private bool _drag;
        private Point _firstPoint;
        BackgroundWorker _meeting_worker;
        BackgroundWorker _office_worker;
        string _file;
        List<Course> _courses;

        public Process()
        {
            InitializeComponent();

            _meeting_worker = new BackgroundWorker();
            _meeting_worker.DoWork += new DoWorkEventHandler(meeting_worker_DoWork);
            _meeting_worker.ProgressChanged += new ProgressChangedEventHandler
                    (meeting_worker_ProgressChanged);
            _meeting_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (meeting_worker_RunWorkerCompleted);
            _meeting_worker.WorkerReportsProgress = true;
            _meeting_worker.WorkerSupportsCancellation = true;

            _office_worker = new BackgroundWorker();
            _office_worker.DoWork += new DoWorkEventHandler(office_worker_DoWork);
            _office_worker.ProgressChanged += new ProgressChangedEventHandler
                    (office_worker_ProgressChanged);
            _office_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (office_worker_RunWorkerCompleted);
            _office_worker.WorkerReportsProgress = true;
            _office_worker.WorkerSupportsCancellation = true;
        }

        ///////////////////////////////////////////////
        // BACKGROUND WORKER - COURSE GROUP CREATION //
        ///////////////////////////////////////////////

        ///
        /// THE BACKGROUND WORKERS PROCESS TO COMPLETE
        ///
        void meeting_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.AdobeConnectCourseGroupCreation(_courses, _file, _meeting_worker);
        }

        ///
        /// UPDATE THE PROGRESS BAR IN THE UI
        ///
        void meeting_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 1)
            {
                progressBar.Maximum = e.ProgressPercentage;
            }
            else
            {
                progressBar.Value++;
                progressBar.Refresh();
            }
        }

        ///
        /// EABLE BUTTONS AND RESET PROGRESS BAR WHEN THE BACKGROUND WORKER FINISHES
        ///
        void meeting_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Refresh();

            AsyncTracker.ResetTracker();

            Program._process.Hide();
            Program._logInformation.Show();
        }

        public void SetFile(string file)
        {
            _file = file;
        }

        public void StartMeetingCreation()
        {
            _courses = LookupTable.GetLookupTable();
            _meeting_worker.RunWorkerAsync();
        }

        /////////////////////////////////////////
        // BACKGROUND WORKER - OFFICE CREATION //
        /////////////////////////////////////////

        ///
        /// THE BACKGROUND WORKERS PROCESS TO COMPLETE
        ///
        void office_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.AdobeConnectInstructorOfficeCreation(_file, _office_worker);
        }

        ///
        /// UPDATE THE PROGRESS BAR IN THE UI
        ///
        void office_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 1)
            {
                progressBar.Maximum = e.ProgressPercentage;
            }
            else
            {
                progressBar.Value++;
                progressBar.Refresh();
            }
        }

        ///
        /// EABLE BUTTONS AND RESET PROGRESS BAR WHEN THE BACKGROUND WORKER FINISHES
        ///
        void office_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Refresh();

            AsyncTracker.ResetTracker();

            Program._process.Hide();
            Program._logInformation.Show();
        }

        public void StartOfficeCreation()
        {
            _office_worker.RunWorkerAsync();
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

        private void processCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
