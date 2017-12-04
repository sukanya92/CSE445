using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }


    //Button display event fetches the XML file and XSL file available in personal host page and 
    //transforms the sml file with the help of XSL file and displays in the formatted table manner.
    protected void BtnDisplay_Click(object sender, EventArgs e)
    {
        string urlXML = "";
        urlXML = this.TextURLXML.Text;
        Boolean isURLCorrect = true;
        if (urlXML == string.Empty || (urlXML.Equals("http://")) || (urlXML.Equals("https://")))
        {
            this.LabelResult.Text = "Error!!! " + "Please enter valid URL";
            isURLCorrect = false;
        }
        try
        {
            if (isURLCorrect)
            {

                StringBuilder sb = new StringBuilder("");
                XmlWriterSettings xSet = new XmlWriterSettings();
                xSet.ConformanceLevel = ConformanceLevel.Auto;
                XmlWriter writer = XmlWriter.Create(sb, xSet);
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load("http://www.public.asu.edu/~spanda7/Movies.xsl");
                transform.Transform(urlXML, writer);
                this.LabelResult.Text = sb.ToString();
            }
        }
        catch (Exception exception)
        {
            this.LabelResult.Text = "Error!!! " + exception.Message;
        }

        //Call SAX Parser to display each and every element, attribute and their respective values
        displayElements(urlXML);
    }
    //This function is responsible for parsing the XML and displaying each tag, its type, attribute 
    //name and their respective values in a tabular manner.
    private void displayElements(string urlXML)
    {
        XmlTextReader reader = null;
        String result = "";
        try
        {
            result += "<table border='2'><tr bgcolor='yellow'><th>Tag Type</th><th>Tag Name</th><th>Text Content</th><th>Attribute Name</th><th>Attribute Value</th></tr>";
            reader = new XmlTextReader(urlXML);
            reader.WhitespaceHandling = WhitespaceHandling.None;
            Boolean isTextPrevious = true;
            while (reader.Read()){

                if (!(reader.NodeType.ToString() == "Text"))
                {

                    if (isTextPrevious == true) {
                        result += "<tr><td>" + reader.NodeType + "</td><td>" + reader.Name + "</td>";
                        isTextPrevious = false;
                    }
                    else
                    {
                        result += "<td></td><td></td><td></td></tr>" + "<tr><td>" + reader.NodeType + "</td><td>" + reader.Name + "</td>";
                        isTextPrevious = false;
                    }

                } 

                else
                {
                    result += "<td>" + reader.Value + "</td><td></td><td></td></tr>";
                    isTextPrevious = true;
                }

                //result += "<br>" + "Type=" + reader.NodeType + " " + "Name=" + reader.Name + " " + "Value=" + reader.Value.ToString();
                if (reader.AttributeCount > 0)
                {
                    if (isTextPrevious == false)
                    {
                        result += "<td></td><td></td><td></td></tr>";
                        isTextPrevious = true;

                    }
                    while (reader.MoveToNextAttribute()) {
                        result += "<tr><td>" + reader.NodeType + "</td><td></td><td></td>" + "<td>" + reader.Name + "</td><td>" + reader.Value + "</td></tr>";
                    }
                 }

            }
            if (isTextPrevious == false)
            {
                result += "<td></td><td></td><td></td></tr>";
                isTextPrevious = true;

            }
            result += "</table>";
            this.LabelParseResult.Text = result;
        }
        catch (Exception exception)
        {
            this.LabelParseResult.Text = "Error!!! " + exception.Message;
        }
    }
}