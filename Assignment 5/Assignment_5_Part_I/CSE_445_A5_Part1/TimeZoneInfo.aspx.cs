using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TimeZoneInfo: System.Web.UI.Page
{ 
    protected void Page_Load(object sender, EventArgs e)
    {
    

    }

    public void button5_Click(object sender, EventArgs e)
    {
        NewsReference.Service1Client myClient = new NewsReference.Service1Client();  // Create a client prox
        try
        {
            //Label 1 to 6
            // Convert to int and check whether zipcode is 5 digits
            int zip = Convert.ToInt32(ZipCodeInput.Text);
            if (zip < 9999 || zip >= 100000)
            {


                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;

                city.Visible = false;
                state.Visible = false;
                Timezoneidentifier.Visible = false;
                timezone_abbr.Visible = false;
                utc_offset_sec.Visible = false;
                is_dst.Visible = false;

                Error.Visible = true;
                Error.Text = "ZipCode is invalid";
            }
            else
            {
                string[] res = myClient.TimeZoneInfo(zip);  // Call the crimedata method
                // Validate
                if (res[0].Equals("error"))
                {
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;

                    city.Visible = false;
                    state.Visible = false;
                    Timezoneidentifier.Visible = false;
                    timezone_abbr.Visible = false;
                    utc_offset_sec.Visible = false;
                    is_dst.Visible = false;

                    Error.Visible = true;

                    Error.Text = "Information not found. Please check whether zipcode is correct!";
                }
                else
                {
                    Error.Visible = false;
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;

                    city.Visible = true;
                    state.Visible = true;
                    Timezoneidentifier.Visible = true;
                    timezone_abbr.Visible = true;
                    utc_offset_sec.Visible = true;
                    is_dst.Visible = true;

                    city.Text = res[0];
                    state.Text = res[1];
                    Timezoneidentifier.Text = res[2];
                    timezone_abbr.Text = res[3];
                    utc_offset_sec.Text = res[4];
                    is_dst.Text = res[5];

                }

            }
        }
        catch (Exception e1)
        {

            Label5.Visible = false;
            Label6.Visible = false;
            Label4.Visible = false;
            Label2.Visible = false;
            Label1.Visible = false;
            Label3.Visible = false;

            city.Visible = false;
            state.Visible = false;
            Timezoneidentifier.Visible = false;
            timezone_abbr.Visible = false;
            utc_offset_sec.Visible = false;
            is_dst.Visible = false;

            Error.Visible = true;
            Error.Text = e1.Message.ToString();
        }

    }


}