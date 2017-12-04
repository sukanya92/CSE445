using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   
    protected void btnGetIndex_Click(object sender, EventArgs e)
    {
       string baseURL = "http://webstrar37.fulton.asu.edu/page0/Service1.svc/";
        string operationName = "GetEarthquakeIndex?";
        string param1 = "latitude=";
        string param2 = "&longitude=";
        string finalURL = "";
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
            //Input Data validation
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
                finalURL = baseURL + operationName + param1 + lat + param2 + longi;
                string response = "";
                Int32 annualIndex = 0;
                using (WebClient client = new WebClient())
                {
                    response = client.DownloadString(finalURL);
                }
                RootObject root = JsonConvert.DeserializeObject<RootObject>(response);
                annualIndex = Convert.ToInt32(root.GetEarthquakeIndexResult);
                this.lblIncidenceCount.Text = annualIndex.ToString();
            }

        }
        catch (Exception exception)
        {
            //Clears fields and show error upon exception
            clearFields();
            MessageBox("Error!!! " + exception.Message);
        }

    }
    //To show pop up with any message content
    public void MessageBox(string message)
    {
        Page page = HttpContext.Current.Handler as Page;
        ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + message + "');", true);

    }

    //To clear fields 
    public void clearFields()
    {
        this.TextLat.Text = string.Empty;
        this.TextLong.Text = string.Empty;
        this.lblIncidenceCount.Text = string.Empty;
    }

    public class RootObject
    {
        public int GetEarthquakeIndexResult { get; set; }
    }



}