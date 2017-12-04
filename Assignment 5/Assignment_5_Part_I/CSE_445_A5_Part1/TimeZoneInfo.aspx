<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="TimeZoneInfo.aspx.cs" Inherits="TimeZoneInfo" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  

       
                       <br />
           <br />
          
        

               <span style="color:blue; font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"><u>Method: TimeZoneInfo</u><span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        
            
               
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Input: ZipCode ( Type: Integer )   <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Output: Information about Timezone, City and State ( Type: Array of String )   <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        
            <div>

 <br />
          
  

	   <asp:Label ID="Label_enterzipcode" runat="server" Text="Enter the ZipCode" BorderStyle="Groove"></asp:Label> &nbsp;
       <asp:TextBox ID="ZipCodeInput" runat="server" Height="25px" Width="100px" BorderColor="#999999" ></asp:TextBox>  &nbsp; 
       <asp:Button ID="button1" runat="server" Width="80px" OnClick="button5_Click" Text="Submit" />

                </div> 
                
                 <asp:Label ID="Error" text-align="center"  ForeColor="red"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>                            


         <asp:Label ID="Label1" runat="server" Text="Timezone Identifier:" Width="130px" ></asp:Label>   &nbsp; 
        <asp:Label ID="Timezoneidentifier" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>   </p>


        <asp:Label ID="Label2" runat="server" Text="Timezone Abbr:" Width="130px" ></asp:Label>   &nbsp; 
        <asp:Label ID="timezone_abbr" text-align="center" ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>  </p>
                           
                           
        <asp:Label ID="Label3" runat="server" Text="UTC Offset Sec:" Width="130px"></asp:Label>   &nbsp; 
        <asp:Label ID="utc_offset_sec" text-align="center"  ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>

    
         <asp:Label ID="Label4" runat="server" Text="Is Dst:" Width="130px" ></asp:Label>   &nbsp;  
        <asp:Label ID="is_dst" text-align="center"    ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label> </p>


        <asp:Label ID="Label5" runat="server" Text="City:" Width="130px" ></asp:Label>   &nbsp; 
        <asp:Label ID="city" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>  </p>

      

        <asp:Label ID="Label6" runat="server" Text="State:" Width="130px" ></asp:Label>   &nbsp;  
        <asp:Label ID="state" text-align="center"    ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>   </p>
   <br />
                

</asp:Content>
