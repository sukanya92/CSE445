<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="UserControlDemo.aspx.cs" Inherits="UserControlDemo" %>
<%@ Register TagPrefix="myControl" TagName="ImgVerifier" src="ImgVerifier.ascx"%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<myControl:ImgVerifier ID="Test" runat="Server">
</myControl:ImgVerifier>
</asp:Content>
