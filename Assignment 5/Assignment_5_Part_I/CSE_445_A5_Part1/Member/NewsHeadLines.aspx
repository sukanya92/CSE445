<%@ Page Title="News Headlines Try It Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="NewsHeadLines.aspx.cs" Inherits="NewsHeadLines" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h3>News Headlines Service TryIt Page</h3>
        <p><u>Description </u></p>
        <p>This operation demonstrates the implementation of News Headlines Service for a specific News website URL which is taken as input and returns the top 10 headlines(News title) as string array</p>
        <br>
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
