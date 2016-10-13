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
    /// The Section class contains all the section data, methods to 
    /// mutate the data and create section folders in Adobe Connect.
    /// 
    public class Section
    {
        private BackgroundWorker _bgw;
        private string _section_indicator;
        private string _folder_id;
        private string _meeting_id;
        private int _number_of_meetings;

        /// 
        /// CONSTRUCTOR TO CREATE A NEW SECTION OBJECT
        /// 
        public Section(string name, int meetings)
        {
            _section_indicator = name;
            _number_of_meetings = meetings;
        }

        /////////////////////////////////
        // SECTION GETTERS AND SETTERS //
        /////////////////////////////////

        /// 
        /// SET A BACKGROUND WORKER TO MANIPULATE THE UI
        /// 
        public void SetBackgroundWorker(BackgroundWorker b)
        {
            _bgw = b;
        }

        /// 
        /// RETURN THE SECTION INDICATOR
        /// 
        public string GetSectionIndicator()
        {
            return _section_indicator;
        }

        /// 
        /// RETURN THE FOLDER ID OF THE SECTION FOLDER
        /// 
        public string GetFolderId()
        {
            return _folder_id;
        }

        /// 
        /// RETURN THE NUMBER OF MEETINGS FOR THIS SECTION
        /// 
        public int GetNumberOfMeetings()
        {
            return _number_of_meetings;
        }

        /// 
        /// SET THE NUMBER OF MEETINGS FOR THIS SECTION
        /// 
        public void SetNumberOfMeetings(int numberOfMeetings)
        {
            _number_of_meetings = numberOfMeetings;
        }

        /// 
        /// SET THE FOLDER ID FOR THIS SECTION FOLDER
        /// 
        public void SetFolderId(string folderId)
        {
            _folder_id = folderId;
        }

        /////////////////////////////
        // SECTION LEVEL FUNCTIONS //
        /////////////////////////////

        /// 
        /// SECTION MEETING CREATION
        /// 
        public void CreateSetMeetings(string course)
        {
            string set;

            if (_section_indicator.Length < 2)
                set = "G00" + _section_indicator;
            else if (_section_indicator.Length < 3)
                set = "G0" + _section_indicator;
            else
                set = "G" + _section_indicator;

            string name = course.Replace("_", "") + "_" + set + "_";

            for (int i = 1; i <= _number_of_meetings; i++)
            {
                string tag;

                if (i < 10)
                    tag = name + "00" + i;
                else if (i < 100)
                    tag = name + "0" + i;
                else
                    tag = name + i;

                string path = @"sco-update&type=meeting&name=" + tag.ToUpper() + "&folder-id="
                    + _folder_id + "&date-begin=" + DateTime.UtcNow.ToString("s") + "&date-end="
                    + DateTime.UtcNow.AddHours(1).ToString("s") + "&url-path=" + tag.ToLower()
                    + "&principal-id=public-access&permission-id=view-hidden";

                XmlDocument xmlDoc = API.GetXMLRequest(path);

                string attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

                if (attrVal != "ok")
                {
                    LogInformation.AddLineToLogInformation("Error", "Error returned from Adobe Connect when creating section meetings for " + _section_indicator + " in " + course);
                    AsyncTracker.EventDone();
                    return;
                }

                XmlNodeList item = xmlDoc.GetElementsByTagName("sco");
                _meeting_id = item[0].Attributes["sco-id"].Value;
                EnrollInstructor();
                _bgw.ReportProgress(1);
                AsyncTracker.EventDone();
            }
        }

        /// 
        /// ENROLL INSTRUCTORS INTO THE MEETING
        /// 
        public void EnrollInstructor()
        {
            string url1 = @"permissions-update&principal-id=" + Program._xDoc.SelectSingleNode("//*[@id='_7']").InnerText + "&acl-id=" + _meeting_id
                + "&permission-id=host";
            string url2 = @"permissions-update&acl-id=" + _meeting_id
                + "&principal-id=public-access&permission-id=view-hidden";

            API.GetXMLRequest(url1);
            API.GetXMLRequest(url2);
        }

        //////////////////////////////////////////////////
        // OVERLOADED OPERATORS AND OVERRIDED FUNCTIONS //
        //////////////////////////////////////////////////

        ///
        /// OVERLOADED EQUALS OPERATOR
        ///
        public static bool operator ==(Section x, Section y)
        {
            return x._section_indicator == y._section_indicator;
        }

        /// 
        /// OVERLOADED NOT EQUALS OPERATOR
        /// 
        public static bool operator !=(Section x, Section y)
        {
            return x._section_indicator != y._section_indicator;
        }

        /// 
        /// OVERRIDE EQUALS FUNCTION
        /// 
        public override bool Equals(object o)
        {
            try
            {
                return (bool)(this == (Section)o);
            }
            catch
            {
                return false;
            }
        }

        /// 
        /// OVERRIDE GETHASHCODE FUNCTION
        /// 
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
