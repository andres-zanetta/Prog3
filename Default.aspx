<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormularioWebP3.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formulario Web</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:50px;">
    <asp:Label ID="lblMensaje" runat="server" Font-Size="Large" ForeColor="Blue"></asp:Label>
    <br /><br />
    <asp:Label ID="lblContadorUsuarios" runat="server" Font-Size="Medium" ForeColor="DarkGreen"></asp:Label>
    <br />
    <asp:Label ID="lblRecargas" runat="server" Font-Size="Medium" ForeColor="Purple"></asp:Label>
    <br /><br />
    <asp:Button ID="btnRecargar" runat="server" Text="Recargar página" OnClick="btnRecargar_Click" />
</div>

    </form>
</body>
</html>
