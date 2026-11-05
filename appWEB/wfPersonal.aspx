<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfPersonal.aspx.vb" Inherits="wfPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 50px;
            height: 35px;
        }
        .auto-style10 {
            height: 35px;
        }
        .auto-style11 {
            width: 400px;
            height: 35px;
        }
        
        .auto-style12 {
            width: 400px;
            height: 35px;
            font-size: large;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="estiloCuerpo">
         <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">&nbsp;</td>
            <td class="auto-style12" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; text-align: right;"><strong>ID personal: </strong></td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; text-align: center;">
                <asp:TextBox ID="txtId" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="100px" style="font-size: large"></asp:TextBox>
             </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">DNI:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:TextBox ID="txtDni" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="100px"></asp:TextBox>
            &nbsp;<asp:Button ID="btnBuscar" runat="server" BackColor="#072FCC" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Trebuchet MS" Font-Size="Medium" ForeColor="White" Height="35px" Text="..." Width="92px" />
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                        <asp:Button ID="btnNuevo" runat="server" BackColor="#072FCC" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Trebuchet MS" Font-Size="Medium" ForeColor="White" Height="35px" Text="Nuevo" Width="150px" />
                    </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">Nombres:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:TextBox ID="txtNombres" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                        <asp:Button ID="btnModificar" runat="server" BackColor="#072FCC" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Trebuchet MS" Font-Size="Medium" ForeColor="White" Height="35px" Text="Modificar" Width="150px" />
                    </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">Apellidos:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:TextBox ID="txtApellidos" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                        <asp:Button ID="btnEliminar" runat="server" BackColor="#072FCC" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Trebuchet MS" Font-Size="Medium" ForeColor="White" Height="35px" Text="Eliminar" Width="150px" />
                    </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">Teléfono:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:TextBox ID="txtTelefono" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                        <asp:Button ID="btnDarBaja" runat="server" BackColor="#072FCC" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Trebuchet MS" Font-Size="Medium" ForeColor="White" Height="35px" Text="Dar de Baja" Width="150px" />
                    </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">Correo:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:TextBox ID="txtCorreo" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; background-color: #072FCC; color: #FFFFFF; font-weight: bold;" colspan="3"> Datos de Usuario:</td>
           <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">Contraseña:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:TextBox ID="txtContraseña" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">&nbsp;</td>
           <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">Tipo de usuario:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:DropDownList ID="ddlTipo" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="150px">
                    <asp:ListItem>Operario</asp:ListItem>
                    <asp:ListItem>Supervisor</asp:ListItem>
                    <asp:ListItem>Administrador</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">&nbsp;</td>
           <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">Área:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:DropDownList ID="ddlArea" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Width="150px">
                    <asp:ListItem>Campo</asp:ListItem>
                    <asp:ListItem>Fábrica</asp:ListItem>
                    <asp:ListItem>Logística</asp:ListItem>
                    <asp:ListItem>Mantenimiento</asp:ListItem>
                    <asp:ListItem>Administración</asp:ListItem>
                    <asp:ListItem>Recursos humanos</asp:ListItem>
                    <asp:ListItem>Sistemas</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">&nbsp;</td>
           <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">Vigencia:</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">
                <asp:CheckBox ID="chkVigencia" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" Text="(Vigente)" />
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">&nbsp;</td>
           <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; background-color: #072FCC; color: #FFFFFF; font-weight: bold;" colspan="3"> &nbsp;Listado de Personal:</td>
           <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; text-align: center;" colspan="3">
                <asp:GridView ID="grvPersonal" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" AutoGenerateSelectButton="True" OnSelectedIndexChanged="grvPersonal_SelectedIndexChanged"  >
                </asp:GridView>
            </td>
           <td class="auto-style9">&nbsp;</td>
        </tr>
       <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">&nbsp;</td>
            <td class="auto-style11" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium; text-align: center;">
            <asp:Label ID="lblMensaje" runat="server" Font-Names="Trebuchet MS" Font-Size="Medium" ForeColor="#072FCC"></asp:Label>
            </td>
            <td class="auto-style10" style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif; font-size: medium">&nbsp;</td>
           <td class="auto-style9">&nbsp;</td>
        </tr>



</table>
</asp:Content>
