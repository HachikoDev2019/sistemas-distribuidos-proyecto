Imports System.Data
Imports capaNegocio
Partial Class wfMantenimientos
    Inherits System.Web.UI.Page
    Dim objMantenimiento As New clsMantenimientoMaquina
    Dim objMaquinaria As New clsMaquinaria

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("tipo") <> "Administrador" And Session("tipo") <> "Supervisor" Then
            Response.Redirect("wfInicio.aspx")
        End If
        If Not IsPostBack Then
            Try
                ddlMaquina.DataSource = objMaquinaria.listarMaquinasCombo
                ddlMaquina.DataTextField = "maquina"
                ddlMaquina.DataValueField = "id_maquinaria"
                ddlMaquina.DataBind()
            Catch ex As Exception
                lblMensaje.Text = ex.Message
            End Try
        End If
        listarMantenimientos
    End Sub

    Private Sub listarMantenimientos()
        Try
            grvMantenimientos.DataSource = objMantenimiento.listarMantenimientos
            grvMantenimientos.DataBind()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If btnNuevo.Text.Equals("Nuevo") Then
                limpiarControles()
                btnNuevo.Text = "Guardar"
                txtId.Text = objMantenimiento.generarIDMantenimiento
                ddlMaquina.Focus()
            Else
                If txtFecha.Text = "" Then
                    lblMensaje.Text = "Ingrese la fecha!"
                Else
                    btnNuevo.Text = "Nuevo"
                    objMantenimiento.registrarMantenimiento(CInt(ddlMaquina.SelectedValue), ddlTipo.Text, txtFecha.Text, txtDescripcion.Text, txtCosto.Text, txtResponsable.Text)
                    lblMensaje.Text = "Mantenimiento registrado correctamente!"
                    limpiarControles()
                    listarMantenimientos()
                End If
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub limpiarControles()
        txtId .Text =""
        txtFecha .Text =""
        txtDescripcion .Text =""
        txtCosto .Text =""
        txtResponsable.Text = ""
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If txtFecha.Text = "" Then
                lblMensaje.Text = "Ingrese la fecha!"
            Else
                objMantenimiento.modificarMantenimiento(CInt(txtId.Text), CInt(ddlMaquina.SelectedValue), ddlTipo.Text, txtFecha.Text, txtDescripcion.Text, txtCosto.Text, txtResponsable.Text)
                lblMensaje.Text = "Mantenimiento modificado correctamente!"
                limpiarControles()
                listarMantenimientos()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objMantenimiento.eliminarMantenimiento(CInt(txtId.Text))
            lblMensaje.Text = "Mantenimiento eliminado correctamente!"
            limpiarControles()
            listarMantenimientos()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub grvMantenimientos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grvMantenimientos.SelectedIndexChanged
        txtId.Text = grvMantenimientos.SelectedRow.Cells(1).Text
        btnBuscar_Click(sender, e)
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dtMan As New DataTable
        Try
            If txtId.Text <> "" Then
                dtMan = objMantenimiento.buscarMantenimiento(CInt(txtId.Text))
                If dtMan.Rows.Count > 0 Then
                    txtId.Text = dtMan.Rows(0).Item(0)
                    ddlMaquina.SelectedValue = dtMan.Rows(0).Item(1).ToString()
                    ddlTipo.Text = dtMan.Rows(0).Item(2)
                    txtFecha.Text = dtMan.Rows(0).Item(3)
                    txtDescripcion.Text = dtMan.Rows(0).Item(4)
                    txtCosto.Text = dtMan.Rows(0).Item(5).ToString()
                    txtResponsable.Text = dtMan.Rows(0).Item(6).ToString()
                Else
                    lblMensaje.Text = "ID no está registrado!"
                    limpiarControles()
                    txtId.Focus()
                End If
            Else
                lblMensaje.Text = "Ingrese ID a buscar!"
                limpiarControles()
                txtId.Focus()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
