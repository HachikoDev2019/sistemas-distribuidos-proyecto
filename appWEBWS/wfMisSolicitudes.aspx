<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfMisSolicitudes.aspx.vb" Inherits="wfMisSolicitudes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Mis solicitudes</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Solicitante:</td>
            <td>
                <asp:Label ID="lblSolicitante" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnActualizar" runat="server" CssClass="estiloBoton" Text="Actualizar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloSeccion" colspan="4">Listado de solicitudes</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvMisSolicitudes" runat="server" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" Width="100%">
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
