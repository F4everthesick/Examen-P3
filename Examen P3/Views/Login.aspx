<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Examen_P3.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hola</h1>
            <h3>Inicia sesión con tu usuario</h3>
            <p>
                <asp:Label Text="Usuario: " runat="server" />
                <asp:TextBox ID="UserTxtbx" runat="server" />
            </p>
            <p>
                <asp:Label Text="Contrasena: " runat="server" />
                <asp:TextBox ID="PasswordTxtbx" TextMode="Password" runat="server" />
            </p>

            <p><asp:Button Id="LoginBtn" Text="Iniciar Sesion" runat="server" OnClick="LoginBtn_Click"/></p>
        </div>
    </form>
</body>
</html>
