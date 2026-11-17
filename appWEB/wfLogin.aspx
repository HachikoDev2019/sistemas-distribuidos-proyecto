<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfLogin.aspx.vb" Inherits="wfLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar sesión - Pomalca</title>
    <link href="css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" cellpadding="0" cellspacing="0" class="estiloLogin">
            <tr>
                <td style="text-align: center">
                    <img alt="Pomalca" src="recursos/POMALCA.jpg" width="150" />
                </td>
            </tr>
            <tr>
                <td class="estiloTitulo" style="text-align: center">Iniciar sesión</td>
            </tr>
            <tr>
                <td class="estiloSubtitulo" style="text-align: center">Portal de Personal Pomalca</td>
            </tr>
            <tr>
                <td class="estiloEtiqueta">DNI:</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtDni" runat="server" CssClass="estiloCaja" MaxLength="8" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="estiloEtiqueta">Contraseña:</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtContraseña" runat="server" CssClass="estiloCaja" TextMode="Password" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnIniciar" runat="server" CssClass="estiloBoton" Text="Ingresar" Width="100%" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMensaje" runat="server" CssClass="estiloMensaje"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
