<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<br>

<asp:Label ID="labelXML" runat ="server" Text="XML URL"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="txtUrlXML" Width="700px" runat ="server"></asp:TextBox>
<br><br>
<asp:Label ID="labelXSL" runat ="server" Text="XSL URL"></asp:Label> &nbsp;&nbsp;
<asp:TextBox ID="txtUrlXSL" Width="700px" runat ="server"></asp:TextBox>
<br><br>
<asp:Button ID="btnGenerateHTML"  Text="Generate HTML" runat ="server" OnClick="btnGenerateHTML_Click"></asp:Button>
<br><br>
<asp:Label ID="labelResultHeader" runat ="server" Text="Generated HTML"></asp:Label> 
<br><br>
<asp:Label ID="labelResult" runat ="server"></asp:Label>


</asp:Content>
