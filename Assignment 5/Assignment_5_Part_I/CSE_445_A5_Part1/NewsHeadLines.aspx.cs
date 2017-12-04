using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewsHeadLines : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loadDropDown();
        }
    }

    private void loadDropDown()
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("XMLFile.xml"));
        DropDownList1.DataSource = ds;
        DropDownList1.DataTextField = "name";
        DropDownList1.DataValueField = "url";
        DropDownList1.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference.Service1Client client = new ServiceReference.Service1Client();
        string url = "";
        url = DropDownList1.Text;
        Boolean isInvalidURL = false;
        if ((url == "") || (url.Equals("http://")))
        {
            string script = "alert('Please enter a valid URL !!!');";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);
            isInvalidURL = true;
            clearFields();
        }
        if (!isInvalidURL)
        {
            try
            {
                string[] titles = client.GetNewsHeadlines(url);
                string newsList = "";

                for (Int32 i = 0; i < titles.Length; i++)
                {
                    newsList += "<br>" + (i + 1) + ". " + titles[i] + "<br>";
                }
                this.Label2.Text = newsList;
            }
            catch (Exception exception)
            {
                MessageBox("Error !!! " + exception.Message.Substring(0, 37));
                clearFields();
            }
        }
    }

    public void MessageBox(string msg)
    {
        Page page = HttpContext.Current.Handler as Page;
        ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + msg + "');", true);
    }

    public void clearFields()
    {
        this.Label2.Text = string.Empty;
    }



    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}