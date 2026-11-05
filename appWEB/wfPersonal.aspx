<%@ Page Title="" Language="VB" MasterPageFile="~/plantilla.master" AutoEventWireup="false" CodeFile="wfPersonal.aspx.vb" Inherits="wfPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="page-header">
        <h1>Gestión de usuarios</h1>
        <p>Registre, busque, modifique o dé de baja al personal.</p>
    </section>

    <section class="content-card">
        <div class="form-section-title">Datos personales</div>
        <div class="form-grid-2">
            <div class="form-group-vertical">
                <label for="txtId">ID personal</label>
                <asp:TextBox ID="txtId" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="form-group-vertical">
                <label for="txtDni">DNI</label>
                <div style="display:flex; gap:8px; align-items:center;">
                    <asp:TextBox ID="txtDni" runat="server" MaxLength="8"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" CssClass="btn-small" Text="Buscar" />
                </div>
            </div>
            <div class="form-group-vertical">
                <label for="txtNombres">Nombres</label>
                <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
            </div>
            <div class="form-group-vertical">
                <label for="txtApellidos">Apellidos</label>
                <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            </div>
            <div class="form-group-vertical">
                <label for="txtTelefono">Teléfono</label>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </div>
            <div class="form-group-vertical">
                <label for="txtCorreo">Correo</label>
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-section-title">Datos de usuario</div>
        <div class="form-grid-2">
            <div class="form-group-vertical">
                <label for="txtContraseña">Contraseña</label>
                <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
            </div>
            <div class="form-group-vertical">
                <label for="ddlTipo">Tipo de usuario</label>
                <asp:DropDownList ID="ddlTipo" runat="server">
                    <asp:ListItem>Operario</asp:ListItem>
                    <asp:ListItem>Supervisor</asp:ListItem>
                    <asp:ListItem>Administrador</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group-vertical">
                <label for="ddlArea">Área</label>
                <asp:DropDownList ID="ddlArea" runat="server">
                    <asp:ListItem>Campo</asp:ListItem>
                    <asp:ListItem>Fábrica</asp:ListItem>
                    <asp:ListItem>Logística</asp:ListItem>
                    <asp:ListItem>Mantenimiento</asp:ListItem>
                    <asp:ListItem>Administración</asp:ListItem>
                    <asp:ListItem>Recursos humanos</asp:ListItem>
                    <asp:ListItem>Sistemas</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group-vertical">
                <label>Vigencia</label>
                <asp:CheckBox ID="chkVigencia" runat="server" Text="(Vigente)" />
            </div>
        </div>

        <div class="section-actions">
            <asp:Button ID="btnNuevo" runat="server" CssClass="btn-primary" Text="Nuevo" />
            <asp:Button ID="btnModificar" runat="server" CssClass="btn-secondary" Text="Modificar" />
            <asp:Button ID="btnEliminar" runat="server" CssClass="btn-danger" Text="Eliminar" />
            <asp:Button ID="btnDarBaja" runat="server" CssClass="btn-small" Text="Dar de Baja" />
        </div>
        <asp:Label ID="lblMensaje" runat="server" CssClass="mensaje"></asp:Label>
    </section>

    <section class="content-card">
        <div class="section-actions">
            <h2>Listado de personal</h2>
        </div>
        <div class="table-container">
            <asp:GridView ID="grvPersonal" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="grvPersonal_SelectedIndexChanged" GridLines="None" SelectText="Seleccionar">
            </asp:GridView>
        </div>
    </section>
</asp:Content>
