using DllEncrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemberRegister : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Register_Click(object sender, EventArgs e)
    {
        try
        {
            LoginReference.Service1Client client = new LoginReference.Service1Client();
            if (!Session["generatedString"].Equals(textInput1.Text))    // Comparing input string and random string
            {
                Error.Text = "The string entered is incorrect so please try again!";
            }
            else
            {
               
                string response = client.addUser(UserInput.Text, Cryption.Encrypt(PasswordInput.Text), 3);  // Adding the user by manipulating XML file
                if (response.Equals("success") && Session["generatedString"].Equals(textInput1.Text))
                {
                    //  Error.Text = "User has been registered Successfully!";
                    Session["registration1"] = "success";
                    Response.Redirect("LoginStaff");
                }
                else if (response.Equals("exist"))
                {
                    Error.Text = "Username already exist! Provide a new username";
                }
                else if (!Session["generatedString"].Equals(textInput1.Text))    // Comparing input string and random string
                {

                    Error.Text = "The string entered is incorrect so please try again!";
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
}