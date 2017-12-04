<%@ Page Title="Wind Service TryIt Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="WindEnergyIndex.aspx.cs" Inherits="WindEnergyIndex" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
        <h2>Wind Intensity Service TryIt Page</h2>
        <br>
        <p><u> Description </u></p>
        <p>This operation demonstrates the implementation of Annual Wind Intensity Service for a specific location identified by a pair of Longitute and Lattitude</p>
        <br>
        <p><u> URL </u></p>
        <p><b>Note: </b> The data source size is very large. Hence from the above API URL, the data source file was downloaded and kept in APP_Data folder for fetching purpose</p>
        <br>
        <p><u> Service Signature </u></p>
        <p>Method Name  : GetWindEnergyIndex</p>
        <p>Input  : [Int32 , Int32]</p>
        <p>Output : [double]</p>
        <p><b>Note: </b> The data source file does not have record corresponding to decimal value of lattitide and longitude (ex. 87.5). Hence the input has to be only integer</p>
        <br>
        

        <p><u> Service Demonstration </u></p>
        <b>------------------------------------------------------------------------------------------</b>  
        <p> Please enter the lattitude(max: 89, min: -90) and longitude(max: 179, min: -180) below (Only integer value) </p> 
        <br>
        <asp:Label ID="LabelLat" runat="server"> Lattitude  :  </asp:Label>&nbsp; &nbsp;<asp:TextBox ID="TextLat" runat="server" Width="100px"></asp:TextBox> 
        <br><br>
        <asp:Label ID="LabelLong" runat="server"> Longitude : </asp:Label>&nbsp; &nbsp;<asp:TextBox ID="TextLong" runat="server" Width="100px"></asp:TextBox> 
        <br><br>
        <asp:Button ID="BtnGetIndex" runat="server" Text="Get Annual Index" OnClick="BtnGetIndex_Click"></asp:Button>  
        <br><br>
        <asp:Label ID="LabelIndexHdr" runat="server"> The Annual Wind Intensity Index : </asp:Label>&nbsp; &nbsp;<asp:Label ID="LabelIndexVal" runat="server"></asp:Label>
       

   
</asp:Content>
