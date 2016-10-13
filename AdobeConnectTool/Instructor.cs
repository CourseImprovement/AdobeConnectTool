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
    /// The Instructor class has instructor data, methods 
    /// to mutate data, and methods to create offices for 
    /// Adobe Connect.
    /// 
    public class Instructor
    {
        private BackgroundWorker _bgw;
        private string _first_name;
        private string _last_name;
        private string _office_name;
        private string _email;
        private string _sco_id;

        /// 
        /// CONSTRUCTOR TO CREATE A NEW INSTRUCTOR OBJECT
        /// 
        public Instructor(string first, string last, string email)
        {
            _first_name = first;
            _last_name = last;
            _email = email;
            _office_name = email.Split('@')[0].ToUpper();
        }


        ////////////////////////////////////
        // INSTRUCTOR GETTERS AND SETTERS //
        ////////////////////////////////////

        /// 
        /// SET A BACKGROUND WORKER TO MANIPULATE THE UI
        /// 
        public void SetBackgroundWorker(BackgroundWorker b)
        {
            _bgw = b;
        }

        /// 
        /// RETURN THE EMAIL
        /// 
        public string GetEmail()
        {
            return _email;
        }

        public string GetFirst()
        {
            return this._first_name;
        }

        public string GetLast()
        {
            return this._last_name;
        }

        //////////////////////////
        // INSTRUCTOR FUNCTIONS //
        //////////////////////////

        /// 
        /// CHECK TO SEE IF THE INSTRUCTOR ALREADY HAS AN ACCOUNT IN ADOBE CONNECT
        /// 
        public bool IsCreated()
        {
            string url = @"sco-by-url&url-path=/" + _office_name;

            XmlDocument xmlDoc = API.GetXMLRequest(url);

            string attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

            if (attrVal == "ok")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// 
        /// CREATE AN ACCOUNT FOR THIS INSTRUCTOR
        /// 
        public void CreateAccount()
        {
            string url = @"principal-update&first-name=" + _first_name
                + "&last-name=" + _last_name + "&login=" + _email
                + "&password=byuitemp123&type=user&send-email=true&has-children=0&email="
                + _email;
            string pid = "";
            string url2 = @"group-membership-update&group-id=" + Program._xDoc.SelectSingleNode("//*[@id='_6']").InnerText + "&is-member=true&principal-id=";

            XmlDocument xmlDoc = API.GetXMLRequest(url);

            string attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

            if (attrVal != "ok")
            {
                LogInformation.AddLineToLogInformation("Error", "Error returned from Adobe Connect when creating an instructor account for " + _last_name + ", " + _first_name);
                AsyncTracker.EventDone();
                return;
            }

            pid = xmlDoc.SelectSingleNode("/results/principal/@principal-id").Value;

            xmlDoc = API.GetXMLRequest(url2 + pid);

            CreateOffice();
        }

        /// 
        /// CREATE AN OFFICE FOR THIS INSTRUCTOR
        /// 
        public void CreateOffice()
        {
            string officePath = _office_name.ToLower();
            string url = @"sco-update&type=meeting&name=" + _office_name
                + "&folder-id=" + Program._xDoc.SelectSingleNode("//*[@id='_5']").InnerText + "&date-begin=" + DateTime.UtcNow.ToString("s") + "Z"
                + "&date-end=" + DateTime.UtcNow.AddHours(1).ToString("s") + "Z"
                + "&url-path=" + officePath
                + "&principal-id=public-access&permission-id=view-hidden";

            XmlDocument xmlDoc = API.GetXMLRequest(url);

            string attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

            if (attrVal != "ok")
            {
                LogInformation.AddLineToLogInformation("Error", "Error returned from Adobe Connect when creating an instructor office for " + _last_name + ", " + _first_name);
                AsyncTracker.EventDone();
                return;
            }

            _sco_id = xmlDoc.SelectSingleNode("results/sco/@sco-id").Value;

            SetPermissions();
        }

        /// 
        /// PLACE PERMISSIONS ON THE MEETING AND THE INSTRUCTOR
        /// 
        public void SetPermissions()
        {
            string url = @"permissions-update&principal-id=" + Program._xDoc.SelectSingleNode("//*[@id='_4']").InnerText + "&acl-id=" + _sco_id
                + "&permission-id=host";
            string url2 = @"permissions-update&acl-id=" + _sco_id
                + "&principal-id=public-access&permission-id=view-hidden";

            XmlDocument xmlDoc = API.GetXMLRequest(url);

            string attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

            if (attrVal != "ok")
            {
                LogInformation.AddLineToLogInformation("Error", "Error returned from Adobe Connect when setting the first permission (meeting host) for the instructor: " + _last_name + ", " + _first_name);
                AsyncTracker.EventDone();
                return;
            }

            xmlDoc = API.GetXMLRequest(url2);

            attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

            AsyncTracker.EventDone();

            if (attrVal != "ok")
            {
                LogInformation.AddLineToLogInformation("Error", "Error returned from Adobe Connect when setting the second permission (public access) for the instructor: " + _last_name + ", " + _first_name);
                return;
            }

            _bgw.ReportProgress(1);
            AsyncTracker.EventDone();
        }
    }
}
