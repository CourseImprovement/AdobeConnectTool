using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AdobeConnectTool
{
    /// 
    /// The Program class the main driver this application 
    /// and initializes all forms.
    /// 
    static class Program
    {
        /// 
        /// EVERY FORM IS CREATED INITIALLY AND IS VISIBLE OR HIDDEN
        /// 
        public static MainMenu _mainMenu;
        public static InstructorOffices _instructorOffices;
        public static InstructorOfficesTemplate _instructorOfficesTemplate;
        public static ProcessInstructorOffices _processInstructorOffices;
        public static CourseList _courseList;
        public static ReplaceCourseList _replaceCourseList;
        public static CourseListTemplate _courseListTemplate;
        public static ProcessCourseList _processCourseList;
        public static CourseGroups _courseGroups;
        public static CourseGroupsTemplate _courseGroupsTemplate;
        public static ProcessCourseGroups _processCourseGroups;
        public static Process _process;

        public static SaveFileDialog _saveFileDialog;
        public static OpenFileDialog _openFileDialog;
        public static LogInformation _logInformation;

        public static XmlDocument _xDoc;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GetLinksAndIds();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetForms();
            Application.Run(new Login());
        }

        private static void GetLinksAndIds()
        {
            string xmlString = new WebClient().DownloadString(@"\\idrive\OnlineLearning\AdobeConnect\LinksAndIds.xml");
            _xDoc = new XmlDocument();
            _xDoc.LoadXml(xmlString);
        }

        /// 
        /// SETUP UP ALL OF THE FORM INITIALLY 
        /// 
        private static void SetForms()
        {
            _mainMenu = new MainMenu();
            _instructorOffices = new InstructorOffices();
            _instructorOfficesTemplate = new InstructorOfficesTemplate();
            _processInstructorOffices = new ProcessInstructorOffices();
            _courseList = new CourseList();
            _replaceCourseList = new ReplaceCourseList();
            _courseListTemplate = new CourseListTemplate();
            _processCourseList = new ProcessCourseList();
            _courseGroups = new CourseGroups();
            _courseGroupsTemplate = new CourseGroupsTemplate();
            _processCourseGroups = new ProcessCourseGroups();
            _process = new Process();
            _saveFileDialog = new SaveFileDialog();
            _saveFileDialog.DefaultExt = "xlsx";
            _saveFileDialog.Filter = "Excel Workbook (.xlsx)|*.xlsx";
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.DefaultExt = "xlsx";
            _openFileDialog.Filter = "Excel Workbook (.xlsx)|*.xlsx";
            _logInformation = new LogInformation();
        }

        ///
        /// CREATE COURSE GROUP MEETINGS 
        /// 
        public static void AdobeConnectCourseGroupCreation(List<Course> courses, string file, BackgroundWorker b)
        {
            bool success = false;
            int total = 0;
            List<Course> finalCourseList = new List<Course>();
            if (file != "")
            {
                List<Course> currentCourses = Excel.GetCourseListFromExcelSpreadsheet(file);
                if (currentCourses != null)
                {
                    success = true;
                    foreach (Course c in currentCourses)
                    {
                        success = true;
                        if (courses.Contains(c))
                        {
                            foreach (Section s in c.GetSections())
                            {
                                success = true;
                                if (s.GetNumberOfMeetings() == 0)
                                {
                                    int idx = courses.IndexOf(c);
                                    if (idx > -1)
                                    {
                                        int meetings = courses[idx].GetNumberOfMeetings();
                                        if (meetings != 0)
                                        {
                                            int spot = c.GetSections().IndexOf(s);
                                            c.GetSections()[spot].SetNumberOfMeetings(meetings);
                                            c.SetBackgroundWorker(b);
                                            c.CourseFolderCreation();
                                            total += meetings;
                                        }
                                        else
                                        {
                                            LogInformation.AddLineToLogInformation("Error", c.GetName() + " does not have a value for the number of meetings to create.");
                                            success = false;
                                        }
                                    }
                                    else
                                    {
                                        LogInformation.AddLineToLogInformation("Error", c.GetName() + " does not exist in the lookup table and there is not a value for the number of meetings to create.");
                                        success = false;
                                    }
                                }
                                else
                                {
                                    c.SetBackgroundWorker(b);
                                    c.CourseFolderCreation();
                                    total += s.GetNumberOfMeetings();
                                }
                            }

                            if (success)
                            {
                                finalCourseList.Add(c);
                            }
                        }
                    }
                }
            }
            else
            {
                LogInformation.AddLineToLogInformation("Error", "No file was chosen.");
                return;
            }

            if (success)
            {
                LogInformation.AddLineToLogInformation("Success", "Excel file was successfully parsed.");
            }

            b.ReportProgress(total);

            AsyncTracker.SetEvents(total);

            foreach (Course c in finalCourseList)
            {
                ThreadPool.QueueUserWorkItem(o => c.SetFolderCreation());
            }

            AsyncTracker.ProceedWhenAllEventsAreComplete();

            Thread.Sleep(1000);      
        }

        /// 
        /// CREATE INSTRUCTOR OFFICE MEETINGS 
        ///
        public static void AdobeConnectInstructorOfficeCreation(string file, BackgroundWorker b)
        {
            List<Instructor> instructors = new List<Instructor>();
            int total = 0;

            if (file != "")
            {
                List<Instructor> currentInstructors = Excel.GetInstructorListFromExcelSpreadsheet(file);

                if (currentInstructors != null)
                {
                    for (int i = 0; i < currentInstructors.Count; i++)
                    {
                        Instructor inst = currentInstructors[i];
                        if (!inst.IsCreated())
                        {
                            total++;
                            inst.SetBackgroundWorker(b);
                            instructors.Add(inst);
                        }
                    }
                }
            }
            else
            {
                LogInformation.AddLineToLogInformation("Error", "No file was chosen.");
                return;
            }

            LogInformation.AddLineToLogInformation("Success", "Excel file was successfully parsed.");

            total = instructors.Count;

            b.ReportProgress(total);

            AsyncTracker.SetEvents(total);

            foreach (Instructor instructor in instructors)
            {
                ThreadPool.QueueUserWorkItem(o => instructor.CreateAccount());
            }

            AsyncTracker.ProceedWhenAllEventsAreComplete();

            Thread.Sleep(1000); 
        }
    }
}
