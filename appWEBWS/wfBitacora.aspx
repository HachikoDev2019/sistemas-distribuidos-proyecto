<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfBitacora.aspx.vb" Inherits="wfBitacora" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Bitácora de accesos</td>
        </tr>
        <tr>
            <td class="estiloSubtitulo" colspan="4">Registro de inicios y cierres de sesión, intentos fallidos y cambios de contraseña.</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnActualizar" runat="server" CssClass="estiloBoton" Text="Actualizar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvBitacora" runat="server" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" Width="100%">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblMensaje" runat="server" CssClass="estiloMensaje"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
