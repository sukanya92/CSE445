using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnVerify_Click(object sender, EventArgs e)
    {
        serviceXmlVerification.Service1Client proxy = new serviceXmlVerification.Service1Client();
        string xmlURL = this.txtUrlXML.Text;
        string xsdURL = this.txtUrlXSD.Text;
        try
        {
            Boolean isUrlvalid = (xmlURL.Trim() != string.Empty) && (xsdURL.Trim() != string.Empty);
            if(isUrlvalid == true)
            {
                this.labelResult.Text = proxy.VerifyXml(xmlURL, xsdURL);
            }
            else
            {
                this.labelResult.Text = "Please enter valid URL";
            }
            
        }
        catch(Exception exception)
        {
            this.labelResult.Text = exception.Message;
        }
    }
}