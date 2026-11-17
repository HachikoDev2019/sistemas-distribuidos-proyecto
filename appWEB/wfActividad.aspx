<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfActividad.aspx.vb" Inherits="wfActividad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td class="estiloTitulo" colspan="4">Actividad de maquinaria</td>
        </tr>
        <tr>
            <td class="estiloSubtitulo" colspan="4">Registre, busque, modifique o finalice las jornadas de las máquinas.</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">ID actividad:</td>
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
            <td class="estiloEtiqueta">Código máquina:</td>
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
            <td class="estiloEtiqueta">Operador:</td>
            <td>
                <asp:DropDownList ID="ddlOperador" runat="server" CssClass="estiloCaja">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" CssClass="estiloBotonRojo" Text="Eliminar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Zona:</td>
            <td>
                <asp:DropDownList ID="ddlZona" runat="server" CssClass="estiloCaja">
                    <asp:ListItem>Anexo Pampagrande</asp:ListItem>
                    <asp:ListItem>Anexo Saltur</asp:ListItem>
                    <asp:ListItem>Sipán Lote 4</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnFinalizar" runat="server" CssClass="estiloBoton" Text="Finalizar" Width="140px" />
            </td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Combustible inicial:</td>
            <td>
                <asp:DropDownList ID="ddlCombustibleInicial" runat="server" CssClass="estiloCaja">
                    <asp:ListItem Value="100">100%</asp:ListItem>
                    <asp:ListItem Value="75">75%</asp:ListItem>
                    <asp:ListItem Value="50">50%</asp:ListItem>
                    <asp:ListItem Value="25">25%</asp:ListItem>
                    <asp:ListItem Value="10">Reserva</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Combustible final:</td>
            <td>
                <asp:DropDownList ID="ddlCombustibleFinal" runat="server" CssClass="estiloCaja">
                    <asp:ListItem Value="">(Sin registrar)</asp:ListItem>
                    <asp:ListItem Value="100">100%</asp:ListItem>
                    <asp:ListItem Value="75">75%</asp:ListItem>
                    <asp:ListItem Value="50">50%</asp:ListItem>
                    <asp:ListItem Value="25">25%</asp:ListItem>
                    <asp:ListItem Value="10">Reserva</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Horas estimadas:</td>
            <td>
                <asp:TextBox ID="txtHorasEstimadas" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Horas reales:</td>
            <td>
                <asp:TextBox ID="txtHorasReales" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Motivo retraso:</td>
            <td>
                <asp:TextBox ID="txtMotivoRetraso" runat="server" CssClass="estiloCaja"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Observación falla:</td>
            <td>
                <asp:TextBox ID="txtObservacionFalla" runat="server" CssClass="estiloCaja" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloEtiqueta">Estado:</td>
            <td>
                <asp:DropDownList ID="ddlEstado" runat="server" CssClass="estiloCaja">
                    <asp:ListItem>ACTIVO</asp:ListItem>
                    <asp:ListItem>FINALIZADO</asp:ListItem>
                    <asp:ListItem>AVERIADO</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="estiloSeccion" colspan="4">Listado de actividad</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvActividad" runat="server" AutoGenerateSelectButton="True" CssClass="estiloTabla" GridLines="Horizontal" HeaderStyle-CssClass="estiloCabeceraTabla" OnSelectedIndexChanged="grvActividad_SelectedIndexChanged" SelectText="Seleccionar" Width="100%">
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
