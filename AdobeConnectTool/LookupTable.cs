using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdobeConnectTool
{
    /// 
    /// The LookupTable class retrieves, processes, and 
    /// updates the list of courses that need Adobe Groups
    /// 
    public class LookupTable
    {
        private bool _valid = true;
        private SLDocument _Excel_Document;
        private Dictionary<string, Course> _course_lookup;

        /// 
        /// CONSTRUCTOR FOR THE LOOKUP TABLE
        /// 
        public LookupTable(List<Course> courses)
        {
            _course_lookup = new Dictionary<string, Course>();
            foreach (Course course in courses)
            {
                _course_lookup.Add(course.GetName(), course);
            }
        }

        ///
        /// PARSE THE XML DOCUMENT AND RETURN A LIST OF COURSES
        ///
        public static List<Course> GetLookupTable()
        {
            List<Course> courses = new List<Course>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("CourseLookup.xml");
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("course");

            for (int i = 0; i < nodes.Count; i++)
            {
                string name = nodes[i].Attributes["name"].Value;
                int numberOfMeetings = Convert.ToInt32(nodes[i].Attributes["meetings"].Value);
                List<Section> sections = new List<Section>();
                Course course = new Course(name, sections, numberOfMeetings);
                courses.Add(course);
            }

            return courses;
        }

        public void Valid()
        {
            _valid = true;
        }

        public bool IsValid()
        {
            return _valid;
        }

        /// 
        /// SET THE EXCEL DOCUMENT
        /// 
        public void SetExcelDocument(string file)
        {
            if (file.IndexOf(".xlsx") < 0)
            {
                _valid = false;
                return;
            }
            _Excel_Document = new SLDocument(file);
        }

        /// 
        /// REMOVE COURSES THAT DO NOT NEED MEETINGS CREATED FOR THEM
        /// 
        public void CompareExcelDocumentAndLookupTable()
        {
            List<Course> newCourses = new List<Course>();
            SLWorksheetStatistics stats = _Excel_Document.GetWorksheetStatistics();
            int end = stats.EndRowIndex;

            if (_Excel_Document.GetCellValueAsString(1, 1).ToLower() != "course name" || _Excel_Document.GetCellValueAsString(1, 2).ToLower() != "number of meetings")
            {
                _valid = false;
                return;
            }

            for (int i = 2; i <= end; i++)
            {
                string current_course = _Excel_Document.GetCellValueAsString(i, 1).Replace(" ", "_").ToUpper();
                int current_number_of_meetings = _Excel_Document.GetCellValueAsInt32(i, 2);

                Course c = new Course(current_course, new List<Section>(), current_number_of_meetings);

                if (!newCourses.Contains(c) && current_course != "" && current_number_of_meetings != 0)
                {
                    newCourses.Add(c);
                }
            }

            _course_lookup.Clear();

            foreach (Course course in newCourses)
            {
                _course_lookup.Add(course.GetName(), course);
            }
        }

        /// 
        /// CONVERT THE EXCEL FILE INTO A XML FILE AND SAVE THE FILE WHILE BACKING UP TO OLD FILE
        /// 
        public void SaveAsXML()
        {
            // BACKUP FILE
            String dateStr = DateTime.Now.ToString("s").Replace(":", "-");
            File.Move("CourseLookup.xml", "Backup/CourseLookup-D" + dateStr + ".xml");

            // CREATE NEW COURSE LOOKUP.XML
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?><adobeconnect></adobeconnect>");

            foreach (string c in _course_lookup.Keys)
            {
                XmlNode node = xmlDocument.CreateNode("element", "course", "");
                XmlAttribute name = xmlDocument.CreateAttribute("name");
                name.Value = _course_lookup[c].GetName();
                XmlAttribute meetings = xmlDocument.CreateAttribute("meetings");
                meetings.Value = _course_lookup[c].GetNumberOfMeetings().ToString();
                node.Attributes.Append(name);
                node.Attributes.Append(meetings);

                xmlDocument.SelectSingleNode("adobeconnect").AppendChild(node);
            }

            xmlDocument.Save("CourseLookup.xml");
        }
    }
}
