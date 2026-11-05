Imports System.Data
Imports capaNegocio
Partial Class wfPersonal
    Inherits System.Web.UI.Page
    Dim objPersonal As New clsPersonal

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        listarPersonal
    End Sub

    Private Sub listarPersonal()
        Try
            grvPersonal.DataSource = objPersonal.listarPersonal
            grvPersonal.DataBind()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If btnNuevo.Text.Equals("Nuevo") Then
                limpiarControles()
                btnNuevo.Text = "Guardar"
                txtId.Text = objPersonal.generarIDPersonal
                txtDni.Focus()
            Else
                btnNuevo.Text = "Nuevo"
                objPersonal.registrarPersonal(txtDni.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text, ddlTipo.Text, ddlArea.Text, chkVigencia.Checked)
                lblMensaje.Text = "Personal registrado correctamente!"
                limpiarControles()
                listarPersonal()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub limpiarControles()
        txtContraseña.Text = ""
        txtCorreo.Text = ""
        txtDni .Text =""
        txtId .Text =""
        txtNombres .Text =""
        txtApellidos .Text =""
        txtTelefono.Text = ""
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objPersonal.modificarPersonal(CInt(txtId.Text), txtDni.Text, txtNombres.Text, txtApellidos.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text, ddlTipo.Text, ddlArea.Text, chkVigencia.Checked)
            lblMensaje.Text = "Personal modificado correctamente!"
            limpiarControles()
            listarPersonal()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objPersonal.eliminarPersonal(CInt(txtId.Text))
            lblMensaje.Text = "Personal eliminado correctamente!"
            limpiarControles()
            listarPersonal()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            objPersonal.darBajaPersonal(CInt(txtId.Text))
            lblMensaje.Text = "Personal dado de baja correctamente!"
            limpiarControles()
            listarPersonal()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub grvPersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grvPersonal.SelectedIndexChanged
        txtId.Text = grvPersonal.SelectedRow.Cells(1).Text
        txtDni.Text = grvPersonal.SelectedRow.Cells(2).Text
        btnBuscar_Click(sender, e)
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dtEmp As New DataTable
        Try
            If txtDni.Text <> "" Then
                dtEmp = objPersonal.buscarPersonal(txtDni.Text)
                If dtEmp.Rows.Count > 0 Then
                    txtId.Text = dtEmp.Rows(0).Item(0)
                    txtNombres.Text = dtEmp.Rows(0).Item(2)
                    txtApellidos.Text = dtEmp.Rows(0).Item(3)
                    txtTelefono.Text = dtEmp.Rows(0).Item(4).ToString()
                    txtCorreo.Text = dtEmp.Rows(0).Item(5).ToString()
                    txtContraseña.Text = dtEmp.Rows(0).Item(6)
                    ddlTipo.Text = dtEmp.Rows(0).Item(7)
                    ddlArea.Text = dtEmp.Rows(0).Item(8)
                    chkVigencia.Checked = (dtEmp.Rows(0).Item(9) = "Activo")
                Else
                    lblMensaje.Text = "DNI no está registrado!"
                    limpiarControles()
                    txtDni.Focus()
                End If
            Else
                lblMensaje.Text = "Ingrese DNI a buscar!"
                limpiarControles()
                txtDni.Focus()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
