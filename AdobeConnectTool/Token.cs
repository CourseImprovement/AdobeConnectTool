using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdobeConnectTool
{
    /// 
    /// The Token class holds the token that is 
    /// needed to validate each call made.
    /// 
    public class Token
    {
        private static string _breeze_token;

        /// 
        /// SET THE SESSION TOKEN
        /// 
        public static void SetToken()
        {
            XmlDocument xmlDoc = API.GetXMLRequest("common-info");
            _breeze_token = "&session=" + xmlDoc.SelectSingleNode("/results/common/cookie").InnerXml;
        }

        /// 
        /// RETURN THE TOKEN OR AN EMPTY STRING
        /// 
        public static string GetToken()
        {
            if (_breeze_token != null)
            {
                return _breeze_token;
            }
            else
            {
                return "";
            }
        }
    }
}
