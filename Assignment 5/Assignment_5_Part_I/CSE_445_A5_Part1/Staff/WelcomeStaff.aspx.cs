using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class WelcomeStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (Session["role"] == null || Session["role"].Equals("2") || Request.Cookies["StaffCookieId"] == null)  // Role 1 for member, Role 2 for staff
            Response.Redirect("unauthorized.aspx");

        Label10.Text = Session["username"].ToString();
        string p = HostingEnvironment.ApplicationPhysicalPath;
        string filePath = Path.GetFullPath(Path.Combine(p, @"..\" + "Services\\App_Data", "members.xml"));
        XmlDataSource1.DataFile = filePath;

    }

    protected void Register_Click(object sender, EventArgs e)
    {
        try
        {

            LoginReference.Service1Client client = new LoginReference.Service1Client();
            if (PasswordInput.Text.Equals(""))
                Error.Text = "Password is Empty";
            else if (UserInput.Text.Equals(""))
                Error.Text = "Username is Empty";
            else
            {

                string response = client.addUser(UserInput.Text, PasswordInput.Text, 2);  // Adding the user by manipulating XML file
                if (response.Equals("success"))
                {
                    XmlDataSource1.XPath = "/users/user";
                    Error.Text = "User added Successfully!";
                }
                else if (response.Equals("exist"))
                {
                    Error.Text = "Username already exist! Provide a new username";
                }
                else
                {
                    //  Error.Text = "Username or password is incorrect!!";
                    Error.Text = response;
                }
            }
        }
        catch (Exception e1)
        {
            Error.Text = e1.Message;
        }
    }


    protected void Search_Click(object sender, EventArgs e)
    {
        try
        {
            LoginReference.Service1Client client = new LoginReference.Service1Client();
            if ((TextBox1.Text).Equals(""))
            {
                Label4.Text = "User name is Empty";
            }
            else
            {
                string result = client.search(TextBox1.Text, 2);   // Searching the user in XML file
                if (result.Equals("success"))
                {
                    Label4.Text = "User exists";
                }
                else if (result.Equals("unsuccess"))
                {
                    Label4.Text = "User doesn't exist";
                }
            }
        }

        catch (Exception e1)
        {
            Label4.Text = e1.Message;
        }
    }


    protected void Clear_cookie(object sender, EventArgs e)
    {
        try
        {
            HttpCookie mycookies = new HttpCookie("StaffCookieId");  // Clearing the cookies if required 
            //mycookies["Name"] = "";
            //mycookies["Password"] = "";
            mycookies.Expires = DateTime.Now.AddMonths(-6);
            Response.Cookies.Add(mycookies);
            Session["username"] = null;
            Session["role"] = null;
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
            HttpCookie mycookies = new HttpCookie("StaffCookieId");  // Clearing the cookies if required 
            mycookies.Expires = DateTime.Now.AddMonths(-6);
            Response.Cookies.Add(mycookies);
            Session["username"] = null;
            Session["role"] = null;
            Response.Redirect("LoginStaff.aspx");
        }

        catch (Exception e1)
        {
            Label5.Text = e1.Message;
        }
    }

}