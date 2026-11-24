<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfCambiarContrasena.aspx.vb" Inherits="wfCambiarContrasena" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Cambiar contraseña</td>
        </tr>
        <tr>
            <td class="estiloSubtitulo" colspan="4">Cambie la contraseña de su cuenta.</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Contraseña actual:</td>
            <td>
                <asp:TextBox ID="txtActual" runat="server" CssClass="estiloCaja" TextMode="Password"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnCambiar" runat="server" CssClass="estiloBoton" Text="Cambiar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Nueva contraseña:</td>
            <td>
                <asp:TextBox ID="txtNueva" runat="server" CssClass="estiloCaja" TextMode="Password"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Confirmar contraseña:</td>
            <td>
                <asp:TextBox ID="txtConfirmar" runat="server" CssClass="estiloCaja" TextMode="Password"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblMensaje" runat="server" CssClass="estiloMensaje"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
