<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Login1.aspx.cs" Inherits="Login1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color:blue;" align="center">Welcome!!</h1>
 <br />
 
  <strong style="color:blue;">Login</strong>   <br />  
    <br />

	   <asp:Label ID="Label1" runat="server" Text="Enter Name:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="username_input" runat="server" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>

                <br />
          <br />
		  
		     <asp:Label ID="Label2" runat="server" Text="Enter Password:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="passsword_input"  TextMode="Password" runat="server" Height="25px" width="100%" BorderColor="#999999" >
    
       </asp:TextBox>
                <br />
          <br />

		  
    	
	   <asp:Button ID="GoButton" runat="server" Text="Login" onclick="GoButton_Click" />
    
    <br />
           <br />

    <asp:Label ID="Error" runat="server" Forecolor="red" Text=""  ><b></b></asp:Label>&nbsp;
     
    <br />
     <br />


                

</asp:Content>
