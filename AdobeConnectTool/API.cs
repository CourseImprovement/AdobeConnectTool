using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdobeConnectTool
{
    /// 
    /// The API class takes a query for Adobe Connect and 
    /// returns a XML document containing resopnse data.
    /// 
    public class API
    {
        private static string _baseURL = Program._xDoc.SelectSingleNode("//*[@id='_1']").InnerText;

        /// 
        /// MAKE A REQUEST WITH THE GIVEN QUERY
        /// 
        public static XmlDocument GetXMLRequest(string query)
        {
            WebResponse response = WebRequest.Create(_baseURL + query + Token.GetToken()).GetResponse();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(response.GetResponseStream());
            return xmlDoc;
        }
    }
}
