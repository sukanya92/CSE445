using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["registration"] = "";
        Session["registration1"] = "";

        AccessRequest.Text = "The number of Access Requests : "+ (int)Application["accessrequest"];
        LabelStartTime.Text = "The Application was last accessed at : " + Application["ApplicationStartTime"];
    }




    protected void Memberpage_Click(object sender, EventArgs e)
    {
        // Response.Redirect("Member/MemberPage.aspx");


        try
        {

            HttpCookie myCookies = Request.Cookies["MemberCookieId"];
            if ((myCookies == null) || (Session["role"].ToString() != "2")/*(myCookies["Name"] == "") || (myCookies["Password"] == "")*/)  // Check whetehr cookie stores username and password, based on that re-direct
            {
                Response.Redirect("Member/LoginMember.aspx");
            }
            else if((Session["role"].ToString() == "2"))
            {
                //Session["username"] = myCookies["Name"];
                //Session["role"] = "2";
                Response.Redirect("Member/MemberPage.aspx");
            }

        }
        catch (Exception e1)
        {
            // Error.Text = e1.Message;
        }
    }

    protected void RegisterStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staff/StaffRegister.aspx");
    }

    protected void RegisterMember_Click(object sender, EventArgs e)
    {
        Response.Redirect("Member/MemberRegister.aspx");
    }

    protected void Staffpage_Click(object sender, EventArgs e)
    {
        try
        {

            HttpCookie myCookies = Request.Cookies["StaffCookieId"];
            if ((myCookies == null) || (Session["role"].ToString() != "3") /*|| (myCookies["Name"] == "") || (myCookies["Password"] == "")*/)  // Check whetehr cookie stores username and password, based on that re-direct
            {
                Response.Redirect("Staff/LoginStaff.aspx");
            }
            else if(Session["role"].ToString() == "3")
            {
                //Session["username"] = myCookies["Name"];
                //Session["role"] = "3";
                Response.Redirect("Staff/WelcomeStaff.aspx");
            }

        }
        catch (Exception e1)
        {
            // Error.Text = e1.Message;
        }
    }
}