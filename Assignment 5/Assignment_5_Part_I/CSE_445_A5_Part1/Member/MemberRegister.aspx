<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="MemberRegister.aspx.cs" Inherits="MemberRegister" %>
<%@ Register TagPrefix="myControl" TagName="ImgVerifier" src="ImgVerifierRegister.ascx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
 <br />
      <span><b><u>Register</u></b></span>
    <br />
        <br />

           <asp:Label ID="Label1" runat="server" Text="Enter UserName:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="UserInput" runat="server" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>
     <asp:RequiredFieldValidator ForeColor="red"  runat="server" id="RequiredFieldValidator1" controltovalidate="UserInput" errormessage="Please enter the Username!" />
            <br />
              
 
                              <br />
	   <asp:Label ID="Label2" runat="server" Text="Enter Password:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="PasswordInput" runat="server" TextMode="Password" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>
     <asp:RequiredFieldValidator ForeColor="red"  runat="server" id="RequiredFieldValidator2" controltovalidate="PasswordInput" errormessage="Please enter the Password!" />

    <br />



<myControl:ImgVerifier ID="Test" runat="Server">
</myControl:ImgVerifier>
   &nbsp;
      <asp:TextBox ID="textInput1" runat="server" Height="21px" Width="100px" BorderColor="#999999"></asp:TextBox> 
     <asp:RequiredFieldValidator ForeColor="red"  runat="server" id="RequiredFieldValidator3" controltovalidate="textInput1" errormessage="Please enter the String!" />
     <br />
       <br />
       <br />
      <asp:Button ID="GoButton" runat="server" Text="Register" onclick="Register_Click" />
        <br />
            <br />
    <asp:Label ID="Error" runat="server" Forecolor="red" Text=""  ><b></b></asp:Label>
     



</asp:Content>
