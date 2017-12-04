using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using DllEncrypt;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie myCookies = new HttpCookie("myKeyie");
        string fLocation1 = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Member.xml");
        bool redirect = false;

        if (File.Exists(fLocation1))
        {
            FileStream fS = new FileStream(fLocation1, FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlDocument xd = new XmlDocument();
            xd.Load(fS);
            XmlNode node = xd;
            XmlNodeList children = node.ChildNodes;
            foreach (XmlNode child in children.Item(1))
            {
                if (TextBox1.Text == child.FirstChild.InnerText)
                {
                    string decryptedPassword = Cryption.Decrypt(child.LastChild.InnerText);
                    if (TextBox2.Text == decryptedPassword)
                    {
                        FormsAuthentication.SetAuthCookie(TextBox1.Text, createPersistentCookie: false);
                        Session["Username"] = TextBox1.Text;
                        Session["Password"] = TextBox2.Text;
                        myCookies["Username"] = TextBox1.Text;
                        myCookies["Password"] = TextBox2.Text;
                        myCookies.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Add(myCookies);
                        Result.Text = "Successful";
                        Response.Redirect("Member/MemberPage.aspx");

                        redirect = true;
                        break;
                    }
                }
            }

            if (redirect == false)
                Result.Text = "Fail";
            fS.Close();
        }

    }
}