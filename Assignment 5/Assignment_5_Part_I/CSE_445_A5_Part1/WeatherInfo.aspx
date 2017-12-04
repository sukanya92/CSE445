<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="WeatherInfo.aspx.cs" Inherits="WeatherInfo" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <br />
      
    <br />



    

            <span style="color:blue; font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"><u>Method: WeatherInfo</u <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        
                <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">WeatherInfo: Displays Weather information based on City/State/Country name<span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
                       
         
               
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Input: City/State/Country ( Type: string ) <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Output: Information about Temperature, SkyText, Humidity and wind ( Type: Array of String ) <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        
            <br />
                       
            <div>

	   <asp:Label ID="Label_enter_cityname" runat="server" Text="Enter the CityName" BorderStyle="Groove"></asp:Label> &nbsp;
       <asp:TextBox ID="CityInput" runat="server" Height="25px" Width="100px" BorderColor="#999999" ></asp:TextBox>  &nbsp; 
        <asp:Button ID="button2" runat="server" Width="80px" OnClick="button6_Click" Text="Submit" />
   </div>
                <br />
        <asp:Label ID="Error0" text-align="center" ForeColor="red"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>  

            
       <asp:Label ID="Label7" runat="server" Text="Location:" Width="130px" ></asp:Label>&nbsp; 
        <asp:Label ID="location" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label><br /> </p>  

                                       <asp:Label ID="Label8" runat="server" Text="Temperature:" Width="130px" ></asp:Label>&nbsp; 
        <asp:Label ID="temperature" text-align="center"    ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>   </p>  

                                   <asp:Label ID="Label9" runat="server" Text="Sky Text:" Width="130px" ></asp:Label>&nbsp; 
        <asp:Label ID="skytext" text-align="center"    ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label> </p>  
    
         

                                    <asp:Label ID="Label10" runat="server" Text="Humidity:" Width="130px" ></asp:Label>&nbsp; 
        <asp:Label ID="humidity" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label> </p>  

            
         <asp:Label ID="Label11" runat="server" Text="Wind:" Width="130px" ></asp:Label>&nbsp; 
        <asp:Label ID="wind" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>  </p>  


                                <asp:Label ID="Label12" runat="server" Text="Date & Day:" Width="130px" ></asp:Label>&nbsp; 
        <asp:Label ID="DayDate" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>&nbsp;&nbsp;
                       </div>


                

</asp:Content>
