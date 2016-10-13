using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdobeConnectTool
{
    /// 
    /// The Course class contains all course data, methods to mutate the 
    /// data and course folder creation.
    /// 
    public class Course
    {
        private string _name;
        private List<Section> _sections;
        private int _number_of_meetings;
        private string _sco_id;
        private string _set_url;

        /// 
        /// CONSTRUCTOR FOR A NEW COURSE OBJECT
        /// 
        public Course(string name, List<Section> sections, int numberofmeetings)
        {
            _name = name.Replace(" ", "_");
            _sections = sections;
            _number_of_meetings = numberofmeetings;
        }

        ////////////////////////////////
        // COURSE GETTERS AND SETTERS //
        ////////////////////////////////

        /// 
        /// SET A BACKGROUND WORKER TO MANIPULATE THE UI
        /// 
        public void SetBackgroundWorker(BackgroundWorker b)
        {
            for (int i = 0; i < _sections.Count; i++)
            {
                _sections[i].SetBackgroundWorker(b);
            }
        }

        /// 
        /// RETURN THE NAME OF THE COURSE
        /// 
        public string GetName()
        {
            return _name;
        }

        /// 
        /// SET THE NAME OF THE COURSE
        /// 
        public void SetName(string name)
        {
            _name = name.Replace(" ", "_");
        }

        /// 
        /// GET THE LIST OF SECTIONS FROM THIS COURSE
        /// 
        public List<Section> GetSections()
        {
            return _sections;
        }

        /// 
        /// GET THE NUMBER OF SECTIONS THIS COURSE HAS
        /// 
        public int GetNumberOfSections()
        {
            return _sections.Count;
        }

        /// 
        /// GET THE NUMBER OF MEETINGS FOR GROUPS WITHIN THIS COURSE
        /// 
        public int GetNumberOfMeetings()
        {
            return _number_of_meetings;
        }

        /// 
        /// SET THE NUMBER OF MEETINGS FOR THIS COURSE AND ITS SECTIONS
        /// 
        public void SetNumberOfMeetings(int numberofmeetings)
        {
            _number_of_meetings = numberofmeetings;

            foreach (Section s in _sections)
            {
                s.SetNumberOfMeetings(numberofmeetings);
            }
        }

        /// 
        /// GET THE TOTAL NUMBER OF MEETINGS FOR ALL SECTIONS
        /// 
        public int GetTotalMeetingCount()
        {
            return _sections.Count * _number_of_meetings;
        }

        //////////////////////
        // COURSE FUNCTIONS //
        //////////////////////

        /// 
        /// ADD AN UNIQUE SECTION TO THE COURSE
        /// 
        public void AddSections(List<Section> sections)
        {
            for (int i = 0; i < sections.Count; i++)
            {
                if (!_sections.Contains(sections[i]))
                {
                    _sections.Add(sections[i]);
                }
            }
        }

        /// 
        /// CREATE THE COURSE FOLDER IF IT IS NOT ALREADY ON ADOBE CONNECT
        /// 
        public void CourseFolderCreation()
        {
            bool found = false;
            string path = @"sco-contents&sco-id=" + Program._xDoc.SelectSingleNode("//*[@id='_2']").InnerText + "&sort-name=asc";

            XmlDocument xmlDoc = API.GetXMLRequest(path);

            // parse xml for course name
            XmlNodeList itemRefList = xmlDoc.GetElementsByTagName("sco");
            foreach (XmlNode xn in itemRefList)
            {
                if (xn.FirstChild.InnerText == _name.ToUpper())
                {
                    _sco_id = xn.Attributes["sco-id"].Value;
                    found = true;
                }
            }

            if (!found)
            {
                string url = @"sco-update&type=folder&folder-id=" + Program._xDoc.SelectSingleNode("//*[@id='_3']").InnerText + "&depth=1&name="
                    + _name.ToUpper();

                XmlDocument xmlDoc2 = API.GetXMLRequest(url);

                XmlNodeList item = xmlDoc2.GetElementsByTagName("sco");
                _sco_id = item[0].Attributes["sco-id"].Value;
            }

            _set_url = @"sco-contents&sco-id=" + _sco_id + "&sort-name=asc";
        }

        /// 
        /// CREATE THE SECTION FOLDERS WITHIN THE COURSE FOLDER
        /// 
        public void SetFolderCreation()
        {
            XmlDocument xmlDoc = API.GetXMLRequest(_set_url);

            string attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

            if (attrVal != "ok")
            {
                LogInformation.AddLineToLogInformation("Error", "Error returned from Adobe Connect when creating a section folder for the course: " + _name);
                AsyncTracker.EventDone();
                return;
            }

            for (int i = 0; i < _sections.Count; i++)
            {
                bool valid = true;
                Section section = _sections[i];
                string set = (section.GetSectionIndicator().Length < 2 ? "SET_0" : "SET_") + section.GetSectionIndicator();

                XmlNodeList itemRefList = xmlDoc.GetElementsByTagName("sco");
                foreach (XmlNode xn in itemRefList)
                {
                    if (xn.FirstChild.InnerText == set)
                    {
                        LogInformation.AddLineToLogInformation("Error", "Section " + _sections[i].GetSectionIndicator() +" for " + _name + " already exists and was skipped.");
                        for (int k = 0; k < _sections[i].GetNumberOfMeetings(); k++)
                        {
                            AsyncTracker.EventDone();
                        }
                        valid = false;
                    }
                }

                if (valid)
                {
                    string path2 = @"sco-update&type=folder&name=" + (section.GetSectionIndicator().Length < 2 ? "SET_0" : "SET_")
                    + section.GetSectionIndicator() + "&folder-id=" + _sco_id + "&depth=1";

                    xmlDoc = API.GetXMLRequest(path2);

                    attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

                    if (attrVal != "ok")
                    {
                        LogInformation.AddLineToLogInformation("Error", "Error returned from Adobe Connect when creating an section folder for the course: " + _name);
                        AsyncTracker.EventDone();
                        return;
                    }

                    XmlNodeList item2 = xmlDoc.GetElementsByTagName("sco");
                    string folderId = item2[0].Attributes["sco-id"].Value;
                    _sections[i].SetFolderId(folderId);
                    _sections[i].CreateSetMeetings(_name);
                }
            }
        }

        /////////////////////////////////////////
        // OVERLOADED AND OVERRIDDEN OPERATORS //
        /////////////////////////////////////////

        ///
        /// OVERLOAD THE EQUALS OPERATOR
        ///
        public static bool operator ==(Course x, Course y)
        {
            return x._name == y._name;
        }

        /// 
        /// OVERLOAD THE NOT EQUALS OPERATOR
        /// 
        public static bool operator !=(Course x, Course y)
        {
            return x._name != y._name;
        }

        /// 
        /// OVERRIDE THE EQUALS FUNCTION
        /// 
        public override bool Equals(object o)
        {
            try
            {
                return (bool)(this == (Course)o);
            }
            catch
            {
                return false;
            }
        }

        /// 
        /// OVERRIDE THE GETHASHCODE FUNCTION
        /// 
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
