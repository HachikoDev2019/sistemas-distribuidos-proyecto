<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfSolicitudes.aspx.vb" Inherits="wfSolicitudes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Solicitudes de mantenimiento</td>
        </tr>
        <tr>
            <td class="estiloSubtitulo" colspan="4">Registre, busque, modifique o elimine las solicitudes.</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">ID solicitud:</td>
            <td>
                <asp:TextBox ID="txtId" runat="server" CssClass="estiloCaja"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" CssClass="estiloBoton" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnNuevo" runat="server" CssClass="estiloBoton" Text="Nuevo" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Solicitante:</td>
            <td>
                <asp:DropDownList ID="ddlSolicitante" runat="server" CssClass="estiloCaja">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnModificar" runat="server" CssClass="estiloBoton" Text="Modificar" Width="140px" />
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
                <asp:Button ID="btnEliminar" runat="server" CssClass="estiloBotonRojo" Text="Eliminar" Width="140px" />
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
            <td class="estiloEtiqueta">Estado:</td>
            <td>
                <asp:DropDownList ID="ddlEstado" runat="server" CssClass="estiloCaja">
                    <asp:ListItem>Pendiente</asp:ListItem>
                    <asp:ListItem>En revisión</asp:ListItem>
                    <asp:ListItem>Aprobado</asp:ListItem>
                    <asp:ListItem>Rechazado</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Comentario:</td>
            <td>
                <asp:TextBox ID="txtComentario" runat="server" CssClass="estiloCaja" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloSeccion" colspan="4">Listado de solicitudes</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvSolicitudes" runat="server" AutoGenerateSelectButton="True" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" OnSelectedIndexChanged="grvSolicitudes_SelectedIndexChanged" SelectText="Seleccionar" Width="100%">
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
