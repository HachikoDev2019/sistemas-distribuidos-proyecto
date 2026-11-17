<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfMaquinaria.aspx.vb" Inherits="wfMaquinaria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Gestión de maquinaria</td>
        </tr>
        <tr>
            <td class="estiloSubtitulo" colspan="4">Registre, busque, modifique o dé de baja la maquinaria.</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">ID maquinaria:</td>
            <td>
                <asp:TextBox ID="txtId" runat="server" CssClass="estiloCaja" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnNuevo" runat="server" CssClass="estiloBoton" Text="Nuevo" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Código:</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="estiloCaja"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" CssClass="estiloBoton" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnModificar" runat="server" CssClass="estiloBoton" Text="Modificar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Tipo:</td>
            <td>
                <asp:TextBox ID="txtTipo" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" CssClass="estiloBotonRojo" Text="Eliminar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Marca:</td>
            <td>
                <asp:TextBox ID="txtMarca" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnDarBaja" runat="server" CssClass="estiloBoton" Text="Dar de Baja" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Modelo:</td>
            <td>
                <asp:TextBox ID="txtModelo" runat="server" CssClass="estiloCaja"></asp:TextBox>
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
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Estado:</td>
            <td>
                <asp:DropDownList ID="ddlEstado" runat="server" CssClass="estiloCaja">
                    <asp:ListItem>Operativo</asp:ListItem>
                    <asp:ListItem>En Mantenimiento</asp:ListItem>
                    <asp:ListItem>Inactivo</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Observaciones:</td>
            <td>
                <asp:TextBox ID="txtObservaciones" runat="server" CssClass="estiloCaja" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloSeccion" colspan="4">Listado de maquinaria</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvMaquinaria" runat="server" AutoGenerateSelectButton="True" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" OnSelectedIndexChanged="grvMaquinaria_SelectedIndexChanged" SelectText="Seleccionar" Width="100%">
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
