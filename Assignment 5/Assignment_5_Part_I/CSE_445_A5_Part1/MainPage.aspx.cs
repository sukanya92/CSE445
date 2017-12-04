using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        try
        {

            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies == null) || (myCookies["Name"] == "") || (myCookies["Password"] == ""))  // Check whetehr cookie stores username and password, based on that re-direct
            {
                Response.Redirect("Login1.aspx");
            }
            else
            {
                Session["username"] = myCookies["Name"];
                Response.Redirect("Welcome.aspx");
            }

        }
        catch (Exception e1)
        {
           // Error.Text = e1.Message;
        }
    }
}