Imports System.Data
Partial Class wfMaquinaria
    Inherits System.Web.UI.Page
    Dim objMaquinaria As New ServiceReferencePomalca.wsPomalcaSoapClient

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("tipo") <> "Administrador" And Session("tipo") <> "Supervisor" Then
            Response.Redirect("wfInicio.aspx")
        End If
        listarMaquinaria
    End Sub

    Private Sub listarMaquinaria()
        Try
            grvMaquinaria.DataSource = objMaquinaria.listarMaquinaria
            grvMaquinaria.DataBind()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If btnNuevo.Text.Equals("Nuevo") Then
                limpiarControles()
                btnNuevo.Text = "Guardar"
                txtId.Text = objMaquinaria.generarIDMaquinaria
                txtCodigo.Focus()
            Else
                btnNuevo.Text = "Nuevo"
                objMaquinaria.registrarMaquinaria(txtCodigo.Text, txtTipo.Text, txtMarca.Text, txtModelo.Text, ddlArea.Text, ddlEstado.Text, txtObservaciones.Text)
                lblMensaje.Text = "Maquinaria registrada correctamente!"
                limpiarControles()
                listarMaquinaria()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub limpiarControles()
        txtId .Text =""
        txtCodigo .Text =""
        txtTipo .Text =""
        txtMarca .Text =""
        txtModelo .Text =""
        txtObservaciones.Text = ""
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objMaquinaria.modificarMaquinaria(CInt(txtId.Text), txtCodigo.Text, txtTipo.Text, txtMarca.Text, txtModelo.Text, ddlArea.Text, ddlEstado.Text, txtObservaciones.Text)
            lblMensaje.Text = "Maquinaria modificada correctamente!"
            limpiarControles()
            listarMaquinaria()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objMaquinaria.eliminarMaquinaria(CInt(txtId.Text))
            lblMensaje.Text = "Maquinaria eliminada correctamente!"
            limpiarControles()
            listarMaquinaria()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            objMaquinaria.darBajaMaquinaria(CInt(txtId.Text))
            lblMensaje.Text = "Maquinaria dada de baja correctamente!"
            limpiarControles()
            listarMaquinaria()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub grvMaquinaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grvMaquinaria.SelectedIndexChanged
        txtId.Text = grvMaquinaria.SelectedRow.Cells(1).Text
        txtCodigo.Text = grvMaquinaria.SelectedRow.Cells(2).Text
        btnBuscar_Click(sender, e)
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dtMaq As New DataTable
        Try
            If txtCodigo.Text <> "" Then
                dtMaq = objMaquinaria.buscarMaquinaria(txtCodigo.Text)
                If dtMaq.Rows.Count > 0 Then
                    txtId.Text = dtMaq.Rows(0).Item(0)
                    txtTipo.Text = dtMaq.Rows(0).Item(2)
                    txtMarca.Text = dtMaq.Rows(0).Item(3)
                    txtModelo.Text = dtMaq.Rows(0).Item(4)
                    ddlArea.Text = dtMaq.Rows(0).Item(5)
                    ddlEstado.Text = dtMaq.Rows(0).Item(6)
                    txtObservaciones.Text = dtMaq.Rows(0).Item(7).ToString()
                Else
                    lblMensaje.Text = "Código no está registrado!"
                    limpiarControles()
                    txtCodigo.Focus()
                End If
            Else
                lblMensaje.Text = "Ingrese código a buscar!"
                limpiarControles()
                txtCodigo.Focus()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
