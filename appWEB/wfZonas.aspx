<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfZonas.aspx.vb" Inherits="wfZonas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Zonas de trabajo</td>
        </tr>
        <tr>
            <td class="estiloSubtitulo" colspan="4">Registre, busque, modifique o dé de baja las zonas.</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">ID zona:</td>
            <td>
                <asp:TextBox ID="txtId" runat="server" CssClass="estiloCaja" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnNuevo" runat="server" CssClass="estiloBoton" Text="Nuevo" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Nombre:</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="estiloCaja"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" CssClass="estiloBoton" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnModificar" runat="server" CssClass="estiloBoton" Text="Modificar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Descripción:</td>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="estiloCaja" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" CssClass="estiloBotonRojo" Text="Eliminar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Vigencia:</td>
            <td>
                <asp:CheckBox ID="chkVigencia" runat="server" Text="(Vigente)" Checked="True" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnDarBaja" runat="server" CssClass="estiloBoton" Text="Dar de Baja" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloSeccion" colspan="4">Listado de zonas</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvZonas" runat="server" AutoGenerateSelectButton="True" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" OnSelectedIndexChanged="grvZonas_SelectedIndexChanged" SelectText="Seleccionar" Width="100%">
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
