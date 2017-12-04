using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class MemberPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["role"] == null || Session["role"].Equals("3") || Request.Cookies["MemberCookieId"]==null)  // Role 1 for member, Role 2 for staff
            Response.Redirect("unauthorized.aspx");

        Label10.Text = Session["username"].ToString();
    }

    protected void Clear_cookie(object sender, EventArgs e)
    {
        try
        {
            HttpCookie mycookies = new HttpCookie("MemberCookieId");  // Clearing the cookies if required 
            mycookies.Expires = DateTime.Now.AddMonths(-6);
            Response.Cookies.Add(mycookies);
            Session["username"] = null;
            Session["role"] = null;
            //mycookies["Name"] = "";
            //mycookies["Password"] = ""; 
            Label5.Text = "Cookies have been cleared";
            Button5.Enabled = false;
            Response.Redirect("unauthorized.aspx");
        }

        catch (Exception e1)
        {
            Label5.Text = e1.Message;
        }
    }
    
    protected void logout_onclick(object sender, EventArgs e)
    {
        try
        {
            HttpCookie mycookies = new HttpCookie("MemberCookieId");  // Clearing the cookies if required 
            mycookies.Expires = DateTime.Now.AddMonths(-6);
            Response.Cookies.Add(mycookies);

            Session["username"] = null;
            Session["role"] = null;
            Response.Redirect("LoginMember.aspx");
        }

        catch (Exception e1)
        {
            Label5.Text = e1.Message;
        }
    }

}