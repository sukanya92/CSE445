<%@ Page Title="Wind Service TryIt Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
        <h2>Wind Intensity Service TryIt Page</h2>
        <br>
        <p><u> Service Description </u></p>
        <p>This TryIt Page demonstrates the implementation of Annual Wind Intensity Service for a specific location identified by a pair of Longitute and Lattitude</p>
        <br>
        <p><u> Service Signature </u></p>
        <p>Input  : [Int32 , Int32]</p>
        <p>Output : [double]</p>
        <br>
        <p><u> Service URL </u></p>
        <p>This part is hosted in localhost</p>
        <br>
        <p><u> Service Demonstration </u></p>
        <b>------------------------------------------------------------------------------------------</b>  
        <p> Please enter the lattitude and longitude below </p> 
        <br>
        <asp:Label ID="LabelLat" runat="server"> Lattitude  :  </asp:Label>&nbsp; &nbsp;<asp:TextBox ID="TextLat" runat="server" Width="100px"></asp:TextBox> 
        <br><br>
        <asp:Label ID="LabelLong" runat="server"> Longitude : </asp:Label>&nbsp; &nbsp;<asp:TextBox ID="TextLong" runat="server" Width="100px"></asp:TextBox> 
        <br><br>
        <asp:Button ID="BtnGetIndex" runat="server" Text="Get Annual Index" OnClick="BtnGetIndex_Click"></asp:Button>  
        <br><br>
        <asp:Label ID="LabelIndexHdr" runat="server"> The Annual Wind Intensity Index : </asp:Label>&nbsp; &nbsp;<asp:Label ID="LabelIndexVal" runat="server"></asp:Label>
       

   
</asp:Content>
