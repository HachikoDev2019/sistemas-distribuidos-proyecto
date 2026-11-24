<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfReporteHoras.aspx.vb" Inherits="wfReporteHoras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Reporte de horas por máquina</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Fecha inicio:</td>
            <td>
                <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="estiloCaja" TextMode="Date"></asp:TextBox>
            </td>
            <td class="estiloEtiqueta">Fecha fin:</td>
            <td>
                <asp:TextBox ID="txtFechaFin" runat="server" CssClass="estiloCaja" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnGenerar" runat="server" CssClass="estiloBoton" Text="Generar" Width="140px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvReporte" runat="server" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" Width="100%">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblResumen" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblMensaje" runat="server" CssClass="estiloMensaje"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
