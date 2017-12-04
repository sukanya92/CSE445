using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    

    }

    protected void GoButton_Click(object sender, EventArgs e)
    {
        try
        {

            HttpCookie mycookies = new HttpCookie("myCookieId");
            mycookies["Name"] = username_input.Text;            // Store username and password in cookies
            mycookies["Password"] = passsword_input.Text;
            mycookies.Expires = DateTime.Now.AddMonths(6);
            Response.Cookies.Add(mycookies);

            LoginReference.Service1Client client = new LoginReference.Service1Client();
            string response = client.searchUser(username_input.Text, passsword_input.Text,1);  // Check whether user and password are correct by searching in users.xml file
            if (response.Equals("success"))
            {
                Session["username"] = username_input.Text;   // Storing username is session so that it could be used in welcome page
                Response.Redirect("Welcome.aspx");
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