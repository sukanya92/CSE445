﻿using System;
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

    protected void btnGetNewsList_Click(object sender, EventArgs e)
    {
        NewsFocusServiceRef.Service1Client client = new NewsFocusServiceRef.Service1Client();
        string searchTerm = this.txtSearch.Text;
        Boolean isInvalidSearch = false;
        if (searchTerm == "")
        {
            string script = "alert('Please enter a valid search term !!!');";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);
            isInvalidSearch = true;
            this.lblNewsList.Text = string.Empty;
            this.txtSearch.Text = string.Empty;
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
                this.lblNewsList.Text = string.Empty;
                this.txtSearch.Text = string.Empty;
            }
        }
    }
    public void MessageBox(string msg)
    {
        Page page = HttpContext.Current.Handler as Page;
        ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + msg + "');", true);
    }


}