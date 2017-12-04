<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="MemberPage.aspx.cs" Inherits="MemberPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 
    <br />
    <br />
    
  <asp:Label font-size="20px" ID="Label11" runat="server" Forecolor="blue" Text="Welcome"  > </asp:Label>
     <asp:Label font-size="20px" ID="Label10" runat="server" Forecolor="blue" Text=""  ><b></b></asp:Label>  
    <br />
     <br />

              <ol>
<li><h4><a href="WindEnergyIndex.aspx"> Wind Intensity Service</a></h4></li>
Wind Intensity Service provides the Annual Wind Intensity for a specific geographic location
<li><h4><a href="Solarintensity.aspx">Solar Intensity Service</a></h4></li>
Solar Intensity Service provides the Annual Solar Intensity for a specific geographic location


<li><h4><a href="NewsHeadLines.aspx">News Headlines Service</a></h4></li>
This service provides top 10 news headlines from multiple news agencies 
<li><h4><a href="NewsFocus.aspx">News Focus Service</a></h4></li>
This service provides news about any particular topic/keywords from across news sources

<li><h4><a href="WeatherInfo.aspx">Weather Information</a></h4></li>
Weather information for for a specific geographic location
<li><h4><a href="TimeZoneInfo.aspx">TimeZone Information</a></h4></li>
Information about Timezone, City and State for a specific geographic location

<li><h4><a href="CountryInfo.aspx">Country Information</a></h4></li>
This Service provides details of a particular Country like Region, Flag and Other related information
<li><h4><a href="Top10Words.aspx">Top 10 Words Service</a></h4></li>
This service provides top 10 frequently occuring words for a particular website


</ol>
<br />
    <span>--------------------------------------------------------------------------------------------</span>

   <br />
     <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">If you clear the cookies then it re-directs you to the login page when you login next time<span>&nbsp;</span></span></p>


    <span><b><u>Click the below button to clear the cookies</u></b></span>
       <br />
          <br />

      <asp:Button ID="Button5" runat="server" Text="Clear cookies" onclick="Clear_cookie" />       
    
       <br />

       
    <br />
    <asp:Label ID="Label5" runat="server" Forecolor="red" Text=""  ><b></b></asp:Label>

    <br />
      <asp:Button ID="Button1" runat="server" Text="Logout" onclick="logout_onclick" />      
     
    <br />




</asp:Content>
