<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TryItDll.aspx.cs" Inherits="TryItDll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formDll" runat="server">
        <div>
<h2>TryIt Page for Encryption and Decryption</h2>
<br><br>
<asp:Label ID="Label1" runat="server">Enter the text to be Encrypted :  </asp:Label>
<asp:Textbox ID="TextEncrypt" runat="server" Width="300px"></asp:Textbox>
&nbsp;
<asp:Button ID="BtnEncrypt" runat="server" Text="Encrypt" OnClick="BtnEncrypt_Click"></asp:Button>
<br><br>
<asp:Label ID="LabelEncrypted" runat="server">Encrypted Text is :  </asp:Label>
<asp:Label ID="LabelEncryptedResult" runat="server"></asp:Label>
<br><br>
<asp:Label ID="Label2" runat="server">Enter the text to be Decrypted :  </asp:Label>
<asp:Textbox ID="TextDecrypt" runat="server" Width="300px"></asp:Textbox>
&nbsp;
<asp:Button ID="BtnDecrypt" runat="server" Text="Decrypt" OnClick="BtnDecrypt_Click"></asp:Button>
<br><br>
<asp:Label ID="LabelDecrypted" runat="server">Decrypted Text is :  </asp:Label>
<asp:Label ID="LabelDecryptedResult" runat="server"></asp:Label>


        </div>
    </form>
</body>
</html>
