<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="WelcomeStaff.aspx.cs" Inherits="WelcomeStaff" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
     <asp:Label font-size="20px" ID="Label11" runat="server" Forecolor="blue" Text="Welcome"  > </asp:Label>
     <asp:Label font-size="20px" ID="Label10" runat="server" Forecolor="blue" Text=""  ><b></b></asp:Label>  

      <br />

     <br />
      <span><b><u>Add the user by providing username and password</u></b></span>
    <br />
        <br />

           <asp:Label ID="Label1" runat="server" Text="Enter UserName:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="UserInput" runat="server" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>
            <br />
              
 
                              <br />
	   <asp:Label ID="Label2" runat="server" Text="Enter Password:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="PasswordInput" runat="server" TextMode="Password" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>


       <br />
           <br />

      <asp:Button ID="GoButton" runat="server" Text="Add User" onclick="Register_Click" />
    
    <br />

       
    <br />
    <asp:Label ID="Error" runat="server" Forecolor="blue" Text=""  ><b></b></asp:Label>
     

    <br />
    <br />

     <span>----------------------------------------------------------------------------------------------------------</span>
    <br />
      <span><b>List of UserNames</b></span>
    <br />
    
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" ></asp:XmlDataSource>
&nbsp;

    <asp:GridView ID="GridView1" runat="server" XPath="/users/user" DataSourceID="XmlDataSource1"
    AutoGenerateColumns="false" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White">
    <Columns>
        <asp:TemplateField HeaderText="UserNames" HeaderStyle-Width="50">
            <ItemTemplate>
                <%# XPath("username") %>
            </ItemTemplate>
        </asp:TemplateField>


           

    </Columns>
</asp:GridView>


    <br />
     <span>----------------------------------------------------------------------------------------------------------</span>

     <br />
      <span><b><u>Search whether user exists by providing username</u></b></span>
    <br />
        <br />

           <asp:Label ID="Label3" runat="server" Text="Enter UserName:" Width="150px" ></asp:Label>&nbsp;
       <asp:TextBox ID="TextBox1" runat="server" Height="25px" width="100%" BorderColor="#999999" ></asp:TextBox>
            <br />
              
 
                              <br />

      <asp:Button ID="Button1" runat="server" Text="Search User" onclick="Search_Click" />
    
    <br />

       
    <br />
    <asp:Label ID="Label4" runat="server" Forecolor="blue" Text=""  ><b></b></asp:Label>
     
    <br />

       <span>----------------------------------------------------------------------------------------------------------</span>

       

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

      <br />
      <asp:Button ID="Button2" runat="server" Text="Logout" onclick="logout_onclick" />      
     
    <br />


</asp:Content>
