using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CountryInfo: System.Web.UI.Page
{ 
    protected void Page_Load(object sender, EventArgs e)
    {
    

    }

    public void button3_Click(object sender, EventArgs e)
    {
        NewsReference.Service1Client myClient = new NewsReference.Service1Client();  // Create a client proxy

        try
        {
            string[] answer = myClient.GetCountryInfo(Country.Text);  // Call the GetCountryInfo method

            if (answer[0].Equals("error"))
            {


                Error1.Visible = true;
                Alpha2Code.Visible = false;
                Alpha3Code.Visible = false;

                CurrencyCode.Visible = false;
                CurrencyName.Visible = false;
                Region.Visible = false;
                SubRegion.Visible = false;
                Latitude.Visible = false;
                Longitude.Visible = false;
                NativeLanguage.Visible = false;
                Flag.Visible = false;
                // FlagPng.Visible = false;

                Error1.Text = answer[1];

            }
            else
            {


                Error1.Visible = false;
                Alpha2Code.Visible = true;
                Alpha3Code.Visible = true;
                CurrencyCode.Visible = true;
                CurrencyName.Visible = true;
                Region.Visible = true;
                SubRegion.Visible = true;
                Latitude.Visible = true;
                Longitude.Visible = true;
                NativeLanguage.Visible = true;
                Flag.Visible = true;
                //FlagPng.Visible = true;


                Alpha2Code.Text = answer[0];
                Alpha3Code.Text = answer[1];
                Region.Text = answer[2];
                SubRegion.Text = answer[3];
                Latitude.Text = answer[4];
                Longitude.Text = answer[5];


                NativeLanguage.Text = answer[7];
                CurrencyCode.Text = answer[8];
                CurrencyName.Text = answer[9];

                Flag.Text = answer[10];
                //  FlagPng.Text = answer[11];

            }
        }
        catch (Exception e1)
        {
            Error1.Visible = true;
            Alpha2Code.Visible = false;
            Alpha3Code.Visible = false;

            CurrencyCode.Visible = false;
            CurrencyName.Visible = false;
            Region.Visible = false;
            SubRegion.Visible = false;
            Latitude.Visible = false;
            Longitude.Visible = false;
            NativeLanguage.Visible = false;
            Flag.Visible = false;
            //  FlagPng.Visible = false;

            Error1.Text = e1.Message.ToString();
        }

    }


}