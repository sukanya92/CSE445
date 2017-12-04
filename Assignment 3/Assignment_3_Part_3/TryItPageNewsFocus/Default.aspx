<%@ Page Title="News Focus Try It Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
<h3>News Focus Service TryIt Page</h3>
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
   
   
</asp:Content>
