using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

namespace Web_Operation_Transformation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //This function transforms an XML to HTML with the help of XSL file
        //Input : urlXML - URL of XML file to be transformed ;
        //Input : urlXSL - URL of XSL file to make transformation
        //Output: The generated HTML file 
        public string GetHTML(string urlXML, string urlXSL)
        {
            StringBuilder sb = new StringBuilder("");
            XmlWriterSettings xSet = new XmlWriterSettings();
            xSet.ConformanceLevel = ConformanceLevel.Auto;
            XmlWriter writer = XmlWriter.Create(sb, xSet);
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(urlXSL);
            transform.Transform(urlXML, writer);
            string res = sb.ToString();
            string path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Movies.html");
            System.IO.File.WriteAllText(path, string.Empty);
            System.IO.File.WriteAllText(path,res);
            return res;
        }

        
    }
}
