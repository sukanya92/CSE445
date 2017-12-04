using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;

public partial class imageProcess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Response.Clear();
            ImageReference.ServiceClient test1 = new ImageReference.ServiceClient();
            string mystr, userLen;
            if (Session["generatedString"] == null)
            {
                if (Session["userLength"] == null)
                    userLen = "6";                       // Assigning userLen to 3, when page is loaded/accessed for the first time
                else
                    userLen = Session["userLength"].ToString();
                mystr = test1.GetVerifierString(userLen);   // Retreiving a random string
                Session["generatedString"] = mystr;        // Storing in the session variable
            }
            else
            {
                mystr = Session["generatedString"].ToString();
            }
            Stream mystream = test1.GetImage(mystr);
            System.Drawing.Image myImage = System.Drawing.Image.FromStream(mystream);  // Draw the image
            Response.ContentType = "image/jpeg";
            myImage.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
        catch(Exception e1)
        {

        }

    }
}