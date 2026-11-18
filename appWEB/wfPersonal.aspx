<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfPersonal.aspx.vb" Inherits="wfPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Gestión de personal</td>
        </tr>
        <tr>
            <td class="estiloSubtitulo" colspan="4">Registre, busque, modifique o dé de baja al personal.</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">ID personal:</td>
            <td>
                <asp:TextBox ID="txtId" runat="server" CssClass="estiloCaja" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnNuevo" runat="server" CssClass="estiloBoton" Text="Nuevo" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">DNI:</td>
            <td>
                <asp:TextBox ID="txtDni" runat="server" CssClass="estiloCaja" MaxLength="8"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" CssClass="estiloBoton" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnModificar" runat="server" CssClass="estiloBoton" Text="Modificar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Nombres:</td>
            <td>
                <asp:TextBox ID="txtNombres" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" CssClass="estiloBotonRojo" Text="Eliminar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Apellidos:</td>
            <td>
                <asp:TextBox ID="txtApellidos" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnDarBaja" runat="server" CssClass="estiloBoton" Text="Dar de Baja" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Teléfono:</td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Correo:</td>
            <td>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloSeccion" colspan="4">Datos de usuario</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Contraseña:</td>
            <td>
                <asp:TextBox ID="txtContraseña" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Tipo de usuario:</td>
            <td>
                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="estiloCaja">
                    <asp:ListItem>Operario</asp:ListItem>
                    <asp:ListItem>Supervisor</asp:ListItem>
                    <asp:ListItem>Administrador</asp:ListItem>
                </asp:DropDownList>
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
            <td class="estiloEtiqueta">Vigencia:</td>
            <td>
                <asp:CheckBox ID="chkVigencia" runat="server" Text="(Vigente)" Checked="True" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloSeccion" colspan="4">Listado de personal</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvPersonal" runat="server" AutoGenerateSelectButton="True" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" OnSelectedIndexChanged="grvPersonal_SelectedIndexChanged" SelectText="Seleccionar" Width="100%">
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
