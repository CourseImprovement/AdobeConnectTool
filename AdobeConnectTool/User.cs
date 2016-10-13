using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdobeConnectTool
{
    /// <summary>
    /// The User class holds the users credentials and validates that the login is successful.
    /// </summary>
    public class User
    {
        private string _username;
        private string _password;

        /// 
        /// CONSTRUCTOR TO CREATE A NEW USER OBJECT
        /// 
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }

        /// 
        /// LOGIN FOR ADOBE CONNECT
        /// 
        public bool Login()
        {
            Token.SetToken();
            XmlDocument xmlDoc = API.GetXMLRequest("login&login=" + _username + "&password=" + _password);
            string attrVal = xmlDoc.SelectSingleNode("/results/status/@code").Value;

            if (attrVal != "ok")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
