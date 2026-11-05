<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfLogin.aspx.vb" Inherits="wfLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Iniciar Sesión - Azucarera Pomalca</title>
    <link href="css/styles.css" rel="stylesheet" />
</head>
<body class="login-body">
    <form id="form1" runat="server">
        <div class="login-card">
            <div style="text-align: center; margin-bottom: 28px;">
                <div class="logo-login">POMALCA</div>
                <h1 style="font-size: 22px; font-weight: 800; margin-bottom: 6px; color: #1e2a3a;">Portal de Personal</h1>
                <p style="font-size: 13.5px; color: #7a8fa6;">Gestión de Solicitudes e Ingresos</p>
            </div>

            <div class="form-group-vertical">
                <label for="txtDni">Número de DNI</label>
                <div class="input-wrap">
                    <span class="input-prefix">#</span>
                    <asp:TextBox ID="txtDni" runat="server" MaxLength="8" placeholder="Ej. 45678912"></asp:TextBox>
                </div>
            </div>

            <div class="form-group-vertical">
                <label for="txtContraseña">Contraseña de Acceso</label>
                <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" placeholder="••••••••"></asp:TextBox>
            </div>

            <asp:Button ID="btnIniciar" runat="server" CssClass="btn-submit-block" Text="Iniciar Sesión" />

            <asp:Label ID="lblMensaje" runat="server" CssClass="mensaje"></asp:Label>
        </div>
    </form>
</body>
</html>
