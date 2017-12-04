<%@ Page Title="Top 10 Words TryIt Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Top10Words.aspx.cs" Inherits="Top10Words" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h2>Top 10 Words Service TryIt Page</h2>
        <br>
        <p><u>Description </u></p>
        <p>This operation demonstrates the implementation of Top 10 Words Service for a specific website which returns the 10 most frquent words from the website source page</p>
        <br>
        <p><u> Service Signature </u></p>
        <p>Method Name  : GetTop10Words</p>
        <p>Input  : string</p>
        <p>Output : string[]</p>
        <br>
        
        <p><u> Service Demonstration </u></p>
        <b>------------------------------------------------------------------------------------------</b>  
        <p> Please enter the URL below </p> 
        <br>
        <asp:Label ID="LabelURL" runat="server"> URL(include http://)  :  </asp:Label>&nbsp; &nbsp;<asp:TextBox ID="TextURL" runat="server" Width="700px"></asp:TextBox> 
        <br><br>
        <asp:Button ID="BtnGetTop10Words" runat="server" Text="Get Top 10 Words" OnClick="BtnGetTop10Words_Click"></asp:Button>  
        <br><br>
        <asp:Label ID="LabelListHdr" runat="server"> The Top 10 Words are : </asp:Label>
        <br><asp:Label ID="LabelResult" runat="server"></asp:Label> 
</asp:Content>
