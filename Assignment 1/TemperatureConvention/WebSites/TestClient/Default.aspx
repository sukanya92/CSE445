<%@ Page Title="Temperature Convention" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Temperature Conversion Test Client</h2>
        <p>Plese enter the temperature in degree celcius</p>
        <asp:TextBox ID="txtCelcius" runat="server" Width="100px" OnTextChanged="txtCelcius_TextChanged"></asp:TextBox>
         &nbsp;<asp:Button ID="btnC2F" runat="server" OnClick="btnC2F_Click" Text="Convert C2F"/><br>
        <asp:Label ID="lblC2F" runat="server"> Prints the temperature in Farenheit scale </asp:Label>
        </p>
        
        <p>Plese enter the temperature in degree farenheit</p>
        <asp:TextBox ID="txtFarenheit" runat="server" Width="100px" OnTextChanged="txtFarenheit_TextChanged"></asp:TextBox>
         &nbsp;<asp:Button ID="btnF2C" runat="server" OnClick="btnF2C_Click" Text="Convert F2C"/><br>
        <asp:Label ID="lblF2C" runat="server"> Prints the temperature in Celcius scale </asp:Label>
    </p>
</asp:Content>
