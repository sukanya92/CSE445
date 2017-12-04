using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label10.Text = Session["username"].ToString();   // Use the username stored in session to print welcome message
    }

   

    protected void Clear_cookie(object sender, EventArgs e)
    {
        try
        {
            HttpCookie mycookies = new HttpCookie("myCookieId");  // Clearing the cookies if required 
            mycookies["Name"] = "";
            mycookies["Password"] = "";
            Response.Cookies.Add(mycookies);
            Label5.Text = "Cookies have been cleared";
            Button5.Enabled = false;
        }

        catch (Exception e1)
        {
            Label5.Text = e1.Message;
        }
    }

}