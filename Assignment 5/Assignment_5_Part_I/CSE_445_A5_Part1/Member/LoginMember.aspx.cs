using DllEncrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginMember : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["registration"].Equals("success"))
        {
            Label3.Text = "Registration Successful! Please login and start using the NEWS services";
            Session["registration"] = "";
        }

    }

    protected void GoButton_Click(object sender, EventArgs e)
    {
        try
        {

   

            LoginReference.Service1Client client = new LoginReference.Service1Client();
            string response = client.searchUser(username_input.Text, Cryption.Encrypt(passsword_input.Text),2);  // Check whether user and password are correct by searching in users.xml file
            if (response.Equals("success"))
            {
                HttpCookie mycookies = new HttpCookie("StaffCookieId");  // Clearing the cookies if required 
                mycookies.Expires = DateTime.Now.AddMonths(-6);
                Response.Cookies.Add(mycookies);

                //HttpCookie mycookies = new HttpCookie("MemberCookieId");
                mycookies = new HttpCookie("MemberCookieId");
                mycookies["Name"] = username_input.Text;            // Store username and password in cookies
                mycookies["Password"] = Cryption.Encrypt(passsword_input.Text);
                mycookies.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(mycookies);
                Session["username"] = username_input.Text;   // Storing username is session so that it could be used in welcome page
                Session["role"] = "2";
                Response.Redirect("MemberPage.aspx");
            }
            else if(response.Equals("unsuccess"))
            {
            Error.Text = "Username or password is incorrect!!";    
            }
            else
            {
                Error.Text = response;
            }
        }
        catch(Exception e1)
        {
            Error.Text = e1.Message;
        }
    }

}