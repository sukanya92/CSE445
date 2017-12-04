using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WeatherInfo : System.Web.UI.Page
{ 
    protected void Page_Load(object sender, EventArgs e)
    {
    

    }

    public void button6_Click(object sender, EventArgs e)
    {

        // Label 7 to 12
        NewsReference.Service1Client myClient1 = new NewsReference.Service1Client(); // Connect to the service

        try
        {
            string[] res1 = myClient1.WeatherInfo(CityInput.Text);  // Call the weatherInfo method
                                                                    // Validate
            if (res1[0].Equals("error"))
            {
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;

                location.Visible = false;
                skytext.Visible = false;
                temperature.Visible = false;
                humidity.Visible = false;
                wind.Visible = false;
                DayDate.Visible = false;

                Error0.Visible = true;
                Error0.Text = "Information not found. Please provide correct input(City/State/Country Name)!";
            }
            else
            {
                Error0.Visible = false;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;
                Label11.Visible = true;
                Label12.Visible = true;

                location.Visible = true;
                skytext.Visible = true;
                temperature.Visible = true;
                humidity.Visible = true;
                wind.Visible = true;
                DayDate.Visible = true;

                location.Text = res1[0];
                skytext.Text = res1[1];
                temperature.Text = res1[2];
                humidity.Text = res1[3];
                wind.Text = res1[4];
                DayDate.Text = res1[5];

            }

        }

        catch (Exception e1)
        {
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label12.Visible = false;

            location.Visible = false;
            skytext.Visible = false;
            temperature.Visible = false;
            humidity.Visible = false;
            wind.Visible = false;
            DayDate.Visible = false;

            Error0.Visible = true;
            Error0.Text = e1.Message.ToString();
        }

    }




}