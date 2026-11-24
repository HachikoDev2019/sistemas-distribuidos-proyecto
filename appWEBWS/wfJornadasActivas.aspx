<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfJornadasActivas.aspx.vb" Inherits="wfJornadasActivas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Jornadas activas</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta" colspan="3">
                <asp:Label ID="lblTotal" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnActualizar" runat="server" CssClass="estiloBoton" Text="Actualizar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvJornadas" runat="server" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" Width="100%">
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
