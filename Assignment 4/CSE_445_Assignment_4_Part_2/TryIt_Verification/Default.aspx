<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br>

<asp:Label ID="labelXML" runat ="server" Text="XML URL"></asp:Label> &nbsp;&nbsp; <asp:TextBox ID="txtUrlXML" Width="700px" runat ="server"></asp:TextBox>
<br><br>
<asp:Label ID="labelXSD" runat ="server" Text="XSD URL"></asp:Label> &nbsp;&nbsp;
<asp:TextBox ID="txtUrlXSD" Width="700px" runat ="server"></asp:TextBox>
<br><br>
<asp:Button ID="btnVerify"  Text="verify" runat ="server" OnClick="btnVerify_Click"></asp:Button>
<br><br>
<asp:Label ID="labelResultHeader" runat ="server" Text="Verification Result : "></asp:Label> &nbsp;&nbsp;
<asp:Label ID="labelResult" runat ="server"></asp:Label>

</asp:Content>
