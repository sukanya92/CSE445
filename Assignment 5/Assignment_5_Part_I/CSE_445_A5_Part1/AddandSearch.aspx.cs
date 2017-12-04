using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class AddandSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string p = HostingEnvironment.ApplicationPhysicalPath;
        string filePath = Path.GetFullPath(Path.Combine(p, @"..\" + "Services\\App_Data", "users.xml"));
        XmlDataSource1.DataFile = filePath;
    }

    protected void Register_Click(object sender, EventArgs e)
    {
        try
        {

            LoginReference.Service1Client client = new LoginReference.Service1Client();
          
            string response = client.addUser(UserInput.Text, PasswordInput.Text,1);  // Adding the user by manipulating XML file
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
            string result=client.search(TextBox1.Text,1);   // Searching the user in XML file
            if(result.Equals("success"))
            {
                Label4.Text = "User exists";
            }
            else if (result.Equals("unsuccess"))
            {
                Label4.Text = "User doesn't exist";
            }
        }

        catch (Exception e1)
        {
            Label4.Text = e1.Message;
        }
    }

}