using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Top10Words : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["role"] == null || Session["role"].Equals("2"))  // Role 1 for member, Role 2 for staff
            Response.Redirect("unauthorized.aspx");
    }

    protected void BtnGetTop10Words_Click(object sender, EventArgs e)
    {
        ServiceReference.Service1Client proxy = new ServiceReference.Service1Client();
        string url = this.TextURL.Text;
        string[] result = new string[10];
        Boolean isValid = true;
        try
        {
            isValid = (url != string.Empty)
                  && (url.Contains("http://") || url.Contains("https://"));

            //Input Validation
            if (!isValid)
            {
                string script = "alert('Please enter a valid URL. Make sure http(s):// is included');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);
                clearFields();
            }
            else
            {
                //Fetches top 10 words as string array and converts to a string containing all words in formatted manner
                result = proxy.GetTop10Words(url);
                string resultString = "";
                foreach (string s in result)
                {
                    resultString += "<br>" + s + "<br>";
                }
                this.LabelResult.Text = resultString;

            }

        }
        catch (Exception exception)
        {
            //Clears all the fields and shows a error pop up upon any kind of exception
            clearFields();
            MessageBox("Error!!! " + exception.Message);
        }

    }
    //Function to handle pop up of any sort
    public void MessageBox(string message)
    {
        Page page = HttpContext.Current.Handler as Page;
        ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + message + "');", true);
    }

    //Function to clear the fields
    public void clearFields()
    {
        this.TextURL.Text = string.Empty;
        this.LabelResult.Text = string.Empty;

    }

}