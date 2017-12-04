<%@ Page Title="XML Demo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>XML Demo</h3>
    <br><br>
    <asp:Label ID="LabelXML" runat="server">Please enter URL of XML file : </asp:Label> &nbsp;&nbsp;<asp:TextBox ID="TextURLXML" runat="server" Width="300px">http://www.public.asu.edu/~spanda7/Movies.xml</asp:TextBox>
    <br><br>
    <asp:Button ID="BtnDisplay" runat="server" Text="Show Formatted XML" OnClick="BtnDisplay_Click"/>
    <br><br>
    <asp:Label ID="LabelXMLDisplay" runat="server"><u>Formatted XML is shown below</u></asp:Label>
    <br><br>
    <asp:Label ID="LabelResult" runat="server"></asp:Label>
    <br><br>
    <asp:Label ID="LabelParse" runat="server">XML Parse results are displayed below</asp:Label>
    <br><br>
    <asp:Label ID="LabelParseResult" runat="server"></asp:Label>
</asp:Content>
