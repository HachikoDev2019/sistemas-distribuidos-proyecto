Imports System.Data
Imports capaNegocio
Partial Class wfZonas
    Inherits System.Web.UI.Page
    Dim objZona As New clsZona

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("tipo") <> "Administrador" And Session("tipo") <> "Supervisor" Then
            Response.Redirect("wfInicio.aspx")
        End If
        listarZonas
    End Sub

    Private Sub listarZonas()
        Try
            grvZonas.DataSource = objZona.listarZonas
            grvZonas.DataBind()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If btnNuevo.Text.Equals("Nuevo") Then
                limpiarControles()
                btnNuevo.Text = "Guardar"
                txtId.Text = objZona.generarIDZona
                txtNombre.Focus()
            Else
                btnNuevo.Text = "Nuevo"
                objZona.registrarZona(txtNombre.Text, txtDescripcion.Text, chkVigencia.Checked)
                lblMensaje.Text = "Zona registrada correctamente!"
                limpiarControles()
                listarZonas()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub limpiarControles()
        txtId .Text =""
        txtNombre .Text =""
        txtDescripcion.Text = ""
        chkVigencia.Checked = True
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objZona.modificarZona(CInt(txtId.Text), txtNombre.Text, txtDescripcion.Text, chkVigencia.Checked)
            lblMensaje.Text = "Zona modificada correctamente!"
            limpiarControles()
            listarZonas()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objZona.eliminarZona(CInt(txtId.Text))
            lblMensaje.Text = "Zona eliminada correctamente!"
            limpiarControles()
            listarZonas()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            objZona.darBajaZona(CInt(txtId.Text))
            lblMensaje.Text = "Zona dada de baja correctamente!"
            limpiarControles()
            listarZonas()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub grvZonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grvZonas.SelectedIndexChanged
        txtId.Text = grvZonas.SelectedRow.Cells(1).Text
        txtNombre.Text = grvZonas.SelectedRow.Cells(2).Text
        btnBuscar_Click(sender, e)
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dtZona As New DataTable
        Try
            If txtNombre.Text <> "" Then
                dtZona = objZona.buscarZona(txtNombre.Text)
                If dtZona.Rows.Count > 0 Then
                    txtId.Text = dtZona.Rows(0).Item(0)
                    txtDescripcion.Text = dtZona.Rows(0).Item(2).ToString()
                    chkVigencia.Checked = (dtZona.Rows(0).Item(3) = "Activo")
                Else
                    lblMensaje.Text = "Nombre no está registrado!"
                    limpiarControles()
                    txtNombre.Focus()
                End If
            Else
                lblMensaje.Text = "Ingrese nombre a buscar!"
                limpiarControles()
                txtNombre.Focus()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
