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

    protected void btnGenerateHTML_Click(object sender, EventArgs e)
    {
        serviceReferenceTransformation.Service1Client proxy = new serviceReferenceTransformation.Service1Client();
        string xmlURL = this.txtUrlXML.Text;
        string xslURL = this.txtUrlXSL.Text;
        try
        {
            Boolean isUrlvalid = (xmlURL.Trim() != string.Empty) && (xslURL.Trim() != string.Empty);
            if (isUrlvalid == true)
            {
                this.labelResult.Text = proxy.GetHTML(xmlURL, xslURL);
            }
            else
            {
                this.labelResult.Text = "Please enter valid URL";
            }

        }
        catch (Exception exception)
        {
            this.labelResult.Text = exception.Message;
        }
    }
}
