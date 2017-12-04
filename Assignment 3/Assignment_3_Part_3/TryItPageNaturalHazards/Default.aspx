<%@ Page Title="Natural Hazards TryIt Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h2>Try It Page for Natural Hazard Service</h2>
<p>----------------------------------------------------------------------------</p>
        
 
    <h3>Natural Hazards Service TryIt Page</h3>
    <p><u> Description </u></p>
        <p>This operation demonstrates the implementation of Natural Hazards(Earthquake) Index Service for a location(lat,long) which returns the number of incidences</p>
        <br>
        <p><u> URL </u></p>
        <p>Service URL : <a href="http://webstrar37.fulton.asu.edu/page0/Service1.svc">http://webstrar37.fulton.asu.edu/page0/Service1.svc</a> </p>
        <p>External API URL : <a href="https://earthquake.usgs.gov">https://earthquake.usgs.gov</a></p>
        <br>
        <p><u> Service Signature </u></p>

        <p>Method Name  : GetEarthquakeIndex</p>
        <p>Input  : [Int32, Int32]</p>
        <p>Output : Int32</p>
        <b>Note: </b>The data source file does not have record corresponding to decimal value of lattitide and longitude (ex. 87.5). Hence the input has to be only integer
        <br><br><p><u> Service Demonstration </u></p>
       <p>Please enter the lattitude(max: 89, min: -90) and longitude(max: 179, min: -180) below (Only integer value)</p>
       <br><asp:Label ID="labelLat" runat="server">Latitude</asp:Label>&nbsp;&nbsp;<asp:TextBox ID="TextLat" runat="server" Width="100px" ></asp:TextBox>
       <br><br>
       <asp:Label ID="labelLong" runat="server">Longitude</asp:Label>&nbsp;&nbsp;<asp:TextBox ID="TextLong" runat="server" Width="100px" ></asp:TextBox>
       <br><br>
       <asp:Button ID="btnGetIndex" runat="server" OnClick="btnGetIndex_Click" Text="Get Incidence Count"/><br>
       <br><br>
       <asp:Label ID="lblIncidence" runat="server">Number of incidence : </asp:Label>
       &nbsp; &nbsp;
       <asp:Label ID="lblIncidenceCount" runat="server"></asp:Label>

    
</asp:Content>
