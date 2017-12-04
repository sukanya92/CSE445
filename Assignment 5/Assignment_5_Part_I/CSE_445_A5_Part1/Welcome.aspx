<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 
    <br />
    <br />
    
 <asp:Label font-size="20px" ID="Label11" runat="server" Forecolor="blue" Text="Welcome"  > </asp:Label>
     <asp:Label font-size="20px" ID="Label10" runat="server" Forecolor="blue" Text=""  ><b></b></asp:Label>  
    <br />
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

</asp:Content>
