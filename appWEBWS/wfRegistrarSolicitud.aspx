<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfRegistrarSolicitud.aspx.vb" Inherits="wfRegistrarSolicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Registrar solicitud de mantenimiento</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Solicitante:</td>
            <td>
                <asp:Label ID="lblSolicitante" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnRegistrar" runat="server" CssClass="estiloBoton" Text="Registrar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Máquina:</td>
            <td>
                <asp:DropDownList ID="ddlMaquina" runat="server" CssClass="estiloCaja">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnLimpiar" runat="server" CssClass="estiloBoton" Text="Limpiar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Descripción:</td>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="estiloCaja" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Área:</td>
            <td>
                <asp:DropDownList ID="ddlArea" runat="server" CssClass="estiloCaja">
                    <asp:ListItem>Campo</asp:ListItem>
                    <asp:ListItem>Fábrica</asp:ListItem>
                    <asp:ListItem>Logística</asp:ListItem>
                    <asp:ListItem>Mantenimiento</asp:ListItem>
                    <asp:ListItem>Administración</asp:ListItem>
                    <asp:ListItem>Recursos humanos</asp:ListItem>
                    <asp:ListItem>Sistemas</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Prioridad:</td>
            <td>
                <asp:DropDownList ID="ddlPrioridad" runat="server" CssClass="estiloCaja">
                    <asp:ListItem>Alta</asp:ListItem>
                    <asp:ListItem>Media</asp:ListItem>
                    <asp:ListItem>Baja</asp:ListItem>
                </asp:DropDownList>
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
