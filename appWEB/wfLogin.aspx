<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfLogin.aspx.vb" Inherits="wfLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            background-image: url('recursos/fondoLogin1.jpg');
        }
        .auto-style2 {
            width: 75px;
        }
        .auto-style3 {
            width: 75px;
            height: 50px;
        }
        .auto-style4 {
            height: 50px;
            text-align: center;
        }
        .auto-style5 {
            width: 128px;
            height: 128px;
        }
        .auto-style6 {
            width: 150px;
        }
        .auto-style7 {
            width: 75px;
            height: 35px;
        }
        .auto-style8 {
            width: 148px;
            height: 35px;
        }
        .auto-style9 {
            height: 35px;
            text-align: left;
        }
        .auto-style11 {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table align="center" cellpadding="0" cellspacing="0" class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4" colspan="2"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="2" style="text-align: center">
                        <img alt="Login" class="auto-style5" src="recursos/login.png" /></td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; font-weight: bold; color: #072FCC; text-align: right;">DNI :</td>
                    <td class="auto-style9" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; font-weight: bold; color: #072FCC; ">
                        <asp:TextBox ID="txtDni" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="120px" MaxLength="8"></asp:TextBox>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; font-weight: bold; color: #072FCC; text-align: right;">Contraseña :</td>
                    <td class="auto-style9" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; font-weight: bold; color: #072FCC; ">
                        <asp:TextBox ID="txtContraseña" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="120px" TextMode="Password"></asp:TextBox>
                    </td>
                   <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td colspan="2" class="auto-style11" style="text-align: center">
                        <asp:Button ID="btnIniciar" runat="server" BackColor="#072FCC" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Trebuchet MS" Font-Size="Medium" ForeColor="White" Height="35px" Text="Iniciar Sesión" Width="150px" />
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="2" aria-autocomplete="inline" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: small; color: #072FCC">© 2026 Sistema Pomalca - Grupo 2 - USAT</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
        </div>
    <p>
        &nbsp;</p>
        <p style="text-align: center">
            <asp:Label ID="lblMensaje" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" ForeColor="#072FCC"></asp:Label>
        </p>
    </form>
    </body>
</html>
