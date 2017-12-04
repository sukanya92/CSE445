<%@ Page Title="Try It page for elected Services" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h2>Try It Page for Elected Service</h2> 
<p>--------------------------------------------------------------------------------</p>
        
 <a href="#NewsFocus"><u>Click for News Focus</u></a>&nbsp;&nbsp;<a href="#NewsHeadline"><u>Click for News Headlines</u></a>&nbsp;&nbsp;<a href="#NaturalHazards"><u>Click for Natural Hazards</u></a>&nbsp;&nbsp;<a href="http://webstrar37.fulton.asu.edu/index.html"><u>Main Page</u></a>   
    <h3><a name="NaturalHazards">Natural Hazards Service TryIt Page</a></h3>
    <p><u> Description </u></p>
        <p>This operation demonstrates the implementation of Natural Hazards(Earthquake) Index Service for a location(lat,long) which returns the number of incidences</p>
        <br>
        <p><u> URL </u></p>
        <p>Service URL : <a href="http://webstrar37.fulton.asu.edu/page0/Service1.svc">http://webstrar37.fulton.asu.edu/page0/Service1.svc</a> </p>
        <p>External API URL : <a href="https://earthquake.usgs.gov">https://earthquake.usgs.gov</a></p>
        <br>
        <p><u> Service Signature </u></p>

        <p>Method Name  : GetEarthquakeIndex</p>
        <p>Input  : [Int32, Int32]</p>
        <p>Output : Int32</p>
        <b>Note: </b>The data source file does not have record corresponding to decimal value of lattitide and longitude (ex. 87.5). Hence the input has to be only integer
        <br><br><p><u> Service Demonstration </u></p>
       <p>Please enter the lattitude(max: 89, min: -90) and longitude(max: 179, min: -180) below (Only integer value)</p>
       <br><asp:Label ID="labelLat" runat="server">Latitude</asp:Label>&nbsp;&nbsp;<asp:TextBox ID="TextLat" runat="server" Width="100px" ></asp:TextBox>
       <br><br>
       <asp:Label ID="labelLong" runat="server">Longitude</asp:Label>&nbsp;&nbsp;<asp:TextBox ID="TextLong" runat="server" Width="100px" ></asp:TextBox>
       <br><br>
       <asp:Button ID="btnGetIndex" runat="server" OnClick="btnGetIndex_Click" Text="Get Incidence Count"/><br>
       <br><br>
       <asp:Label ID="lblIncidence" runat="server">Number of incidence : </asp:Label>
       &nbsp; &nbsp;
       <asp:Label ID="lblIncidenceCount" runat="server"></asp:Label>
    

    
    <h3><a name="NewsFocus">News Focus Service TryIt Page</a></h3>
    <p><u> Description </u></p>
        <p>This operation demonstrates the implementation of News focus Service for single/ combination of keywords which appear in news across the world</p>
        <br>
        <p><u> URL </u></p>
        <p>Service URL : <a href="http://webstrar37.fulton.asu.edu/page1/Service1.svc">http://webstrar37.fulton.asu.edu/page1/Service1.svc</a> </p>
        <p>External API URL : <a href="https://api.cognitive.microsoft.com/bing/v7.0/news/search">https://api.cognitive.microsoft.com/bing/v7.0/news/search</a> </p>
        <br>
        <p><u> Service Signature </u></p>

        <p>Method Name  : GetNewsFocus</p>
        <p>Input  : string[]</p>
        <p>Output : string[]</p>
        
        <p><u> Service Demonstration </u></p>
        <p>Plese enter the Search Term </p>
        <asp:TextBox ID="txtSearch" runat="server" Width="300px" ></asp:TextBox>
         &nbsp; &nbsp; &nbsp;<asp:Button ID="btnGetNewsList" runat="server" OnClick="btnGetNewsList_Click" Text="Get News Focus"/><br>
        <br><br>
        <asp:Label ID="lblNewsListHeader" runat="server"><u> URLs where above search term appears </u></asp:Label>
        <br><br>
        <asp:Label ID="lblNewsList" runat="server"></asp:Label>
    <br><br>
    <h3><a name="NewsHeadline">News Headlines Service TryIt Page</a></h3>
        <p><u>Description </u></p>
        <p>This operation demonstrates the implementation of News Headlines Service for a specific News website URL which is taken as input and returns the top 10 headlines(News title) as string array</p>
        <br>
        <p><u> URL </u></p>
        <p>Service URL :  <a href = "http://webstrar37.fulton.asu.edu/page1/Service1.svc"> http://webstrar37.fulton.asu.edu/page1/Service1.svc </a> </p>
        <p>External API URL : <a href="https://newsapi.org/">https://newsapi.org/</a> </p>
        <br>
        <p><u> Service Signature </u></p>
        <p>Method Name  : GetNewsHeadlines</p>
        <p>Input  : string</p>
        <p>Output : string[]</p>
        <b><u>Note: </u></b>The value from dropdown has a corresponding URL which is sent as input to the service
        <br><br><p><u> Service Demonstration </u></p> 
        <p>Plese select the News source from the following Dropdown</p>
        <br>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
        
        <br><br>
        <asp:Button ID="Button1" runat="server" Text="Get News Headlines" OnClick="Button1_Click"/><br>
        <br><br>
        <asp:Label ID="Label1" runat="server"><u> News Headlines </u></asp:Label>
        <br><br>
        <asp:Label ID="Label2" runat="server"></asp:Label>
</asp:Content>
