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

    }

    protected void BtnGetIndex_Click(object sender, EventArgs e)
    {
        WindServiceReference.Service1Client proxy = new WindServiceReference.Service1Client();
        string lat = this.TextLat.Text;
        string longi = this.TextLong.Text;
        Boolean isValid = true;
            try
            {
                 isValid = (lat != string.Empty)
                       && (longi != string.Empty)
                       && (Convert.ToInt32(this.TextLat.Text) >= -90)
                       && (Convert.ToInt32(this.TextLat.Text) < 90)
                       && (Convert.ToInt32(this.TextLong.Text) >= -180)
                       && (Convert.ToInt32(this.TextLong.Text) < 180);

                if (!isValid)
                {
                    string script = "alert('Please enter valid lattitude and longitude');";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);
                    clearFields();
                }
                else
                {
                    Int32 lattitude = Convert.ToInt32(this.TextLat.Text);
                    Int32 longitude = Convert.ToInt32(this.TextLong.Text);
                    double annualIndex = proxy.GetWindEnergyIndex(lattitude, longitude);
                    this.LabelIndexVal.Text = annualIndex.ToString();
                }

            }
            catch (Exception exception)
            {
                clearFields();
                MessageBox("Error!!! " + exception.Message);
            }
            
    }
    public void MessageBox(string message)
    {
        Page page = HttpContext.Current.Handler as Page;
        ScriptManager.RegisterStartupScript(page,page.GetType(),"err_msg","alert('" + message + "');",true);

    }

    public void clearFields()
    {
        this.TextLat.Text = string.Empty;
        this.TextLong.Text = string.Empty;
        this.LabelIndexVal.Text = string.Empty;
    }

}