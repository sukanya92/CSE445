<%@ Application Language="C#" %>
<%@ Import Namespace="CSE_445_A5_Part1" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>


<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        Application["accessrequest"] = 0;
        Application["ApplicationStartTime"] = DateTime.Now.ToString();
        // Response.Write("Welcome!!");
    }
    void Application_BeginRequest(object sender, EventArgs e)
    {
        Application.Lock();
        Application["accessrequest"] = (int)Application["accessrequest"]+1;
        Application.UnLock();
    }
    void Application_End(object sender, EventArgs e)
    {
       // Response.Write("<hr />This page was last accessed at " + DateTime.Now.ToString());
        Application.Lock();
        Application["accessrequest"] = (int)Application["accessrequest"]-1;
        Application.UnLock();
    }

</script>
