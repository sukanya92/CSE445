using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
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

    protected void btnGetNewsList_Click(object sender, EventArgs e)
    {
        NewsServiceRef.Service1Client client = new NewsServiceRef.Service1Client();
        string searchTerm = this.txtSearch.Text;
        Boolean isInvalidSearch = false;
        if (searchTerm == "")
        {
            string script = "alert('Please enter a valid search term !!!');";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);
            isInvalidSearch = true;
            clearFields();
            
        }
        if (!isInvalidSearch)
        {
            try
            {
                Char delimiter = ' ';
                string[] keywords = searchTerm.Split(delimiter);
                string[] URLs = client.GetNewsFocus(keywords);
                string newsList = "";

                for (Int32 i = 0; i < URLs.Length; i++)
                {
                    newsList += "<br>" + (i + 1) + ". " + "<u><b>" + URLs[i] + "</b></u>" + "<br>";
                }
                this.lblNewsList.Text = newsList;
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        NewsServiceRef.Service1Client client = new NewsServiceRef.Service1Client();
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

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
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
            MessageBox("Error!!! " + exception.Message);
            clearFields();
        }
    }

    public void clearFields()
    {
        this.TextLat.Text = string.Empty;
        this.TextLong.Text = string.Empty;
        this.lblIncidenceCount.Text = string.Empty;
        this.lblNewsList.Text = string.Empty;
        this.txtSearch.Text = string.Empty;
        this.Label2.Text = string.Empty;
    }

    public class RootObject
    {
        public int GetEarthquakeIndexResult { get; set; }
    }

}