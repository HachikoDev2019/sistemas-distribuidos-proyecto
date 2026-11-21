<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfMantenimientos.aspx.vb" Inherits="wfMantenimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Mantenimientos de maquinaria</td>
        </tr>
        <tr>
            <td class="estiloSubtitulo" colspan="4">Registre, busque, modifique o elimine los mantenimientos.</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">ID:</td>
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
            <td class="estiloEtiqueta">Máquina:</td>
            <td>
                <asp:DropDownList ID="ddlMaquina" runat="server" CssClass="estiloCaja">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnModificar" runat="server" CssClass="estiloBoton" Text="Modificar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Tipo:</td>
            <td>
                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="estiloCaja">
                    <asp:ListItem>Preventivo</asp:ListItem>
                    <asp:ListItem>Correctivo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" CssClass="estiloBotonRojo" Text="Eliminar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Fecha:</td>
            <td>
                <asp:TextBox ID="txtFecha" runat="server" CssClass="estiloCaja" TextMode="Date"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
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
            <td class="estiloEtiqueta">Costo S/:</td>
            <td>
                <asp:TextBox ID="txtCosto" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Responsable:</td>
            <td>
                <asp:TextBox ID="txtResponsable" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloSeccion" colspan="4">Listado de mantenimientos</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvMantenimientos" runat="server" AutoGenerateSelectButton="True" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" OnSelectedIndexChanged="grvMantenimientos_SelectedIndexChanged" SelectText="Seleccionar" Width="100%">
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
