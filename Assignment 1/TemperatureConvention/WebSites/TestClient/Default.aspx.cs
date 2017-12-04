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

    protected void btnC2F_Click(object sender, EventArgs e)
    {
        AspProxyToWcfService.Service1Client myclient;

        try
        {
            myclient = new AspProxyToWcfService.Service1Client();
            int c = Convert.ToInt32(txtCelcius.Text);
            lblC2F.Text = myclient.c2f(c).ToString();
        }
        catch(Exception exception)
        {
            this.txtCelcius.Text = "";
            this.lblC2F.Text = "Prints temperature in Farenheit";
        }
    }

    protected void btnF2C_Click(object sender, EventArgs e)
    {
        AspProxyToWcfService.Service1Client myclient;

        try
        {
            myclient = new AspProxyToWcfService.Service1Client();
            int f = Convert.ToInt32(txtFarenheit.Text);
            lblF2C.Text = myclient.f2c(f).ToString();
        }
        catch (Exception exception)
        {
            this.txtFarenheit.Text = "";
            this.lblF2C.Text = "Prints temperature in celcius";
        }

    }


    protected void txtCelcius_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void txtFarenheit_TextChanged(object sender, EventArgs e)
    {
        
    }
}