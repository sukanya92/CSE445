<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TryItGlobal.aspx.cs" Inherits="TryItGlobal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<h1>Try It Page for Global.asax</h1>
<br><br>
<asp:Label ID="Label1" runat="server">Click the button to get Access Request Count after a new request is made : </asp:Label>
<asp:Button ID="Btn1" runat="server" Text="Access Request Count" OnClick="Btn1_Click"></asp:Button>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label2" runat="server"></asp:Label>
<br><br>
<asp:Label ID="Label3" runat="server">The Application was started at : </asp:Label>
<asp:Label ID="Label4" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
