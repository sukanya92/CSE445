using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Web_Operation_Verification
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //This function validates the XML file against the XSD file
        //Input : urlXML - URL of XML file to be validated ;
        //Input : urlXSD - URL of XSD file to validate the XML file
        //Output: The validation result Message
        public string VerifyXml(string urlXML, string urlXSD)
        {
                XmlDocument xml = new XmlDocument();
                xml.Load(urlXML);
                xml.Schemas.Add(null, urlXSD);
                try
                {
                    xml.Validate(null);
                }
                catch (XmlSchemaValidationException exception)
                {

                    return "Error!!! " + exception.Message;
                }
                return "No Error!!!";
            }
        }

        
}
