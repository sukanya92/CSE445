<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ImgVerifier.ascx.cs" Inherits="ImgVerifier" %>



    <h1>Image Verifier!!</h1>
    <p class="lead">
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">This ASP .Net application allows you to test an image Verifier.<span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">The service offers two operations in URIs:<span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">(1) string GetVerifierString(string myLength) : which returns a random string of the given length ( At maximum, length can be 10 ) <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">(2) Stream GetImage(string myString) : which returns the URI of the image containing the input string<span>&nbsp;</span></span></p>


    <asp:Label ID="Label2" runat="server" Text="Enter the string length" BorderStyle="Groove"></asp:Label>
    <asp:TextBox ID="textInput" runat="server" Height="21px" Width="40px" BorderColor="#999999"></asp:TextBox>
    <asp:Button ID="button1" runat="server" OnClick="button1_Click" Text="Show me the Image String" />

    <br />

    <asp:Image ID="Image1" runat="server" Visible="true" ImageAlign="Left" />
    &nbsp;
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Enter the string here" BorderStyle="Groove"></asp:Label>
    <asp:TextBox ID="textInput1" runat="server" Height="21px" Width="100px" BorderColor="#999999"></asp:TextBox>
    <asp:Button ID="button2" runat="server" OnClick="Submit_Click" Text="Submit" />

    <br />
    <br />
    <asp:Label ID="Label1" runat="server" forecolor="Blue" Text="" Visible="false"></asp:Label>





