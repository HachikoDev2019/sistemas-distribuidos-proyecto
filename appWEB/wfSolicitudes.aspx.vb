Imports System.Data
Imports capaNegocio
Partial Class wfSolicitudes
    Inherits System.Web.UI.Page
    Dim objSolicitud As New clsSolicitud
    Dim objPersonal As New clsPersonal

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        listarSolicitudes
    End Sub

    Private Sub listarSolicitudes()
        Try
            grvSolicitudes.DataSource = objSolicitud.listarSolicitudes
            grvSolicitudes.DataBind()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim dtPer As New DataTable
        Try
            If btnNuevo.Text.Equals("Nuevo") Then
                limpiarControles()
                btnNuevo.Text = "Guardar"
                txtId.Text = objSolicitud.generarIDSolicitud
                txtDni.Focus()
            Else
                btnNuevo.Text = "Nuevo"
                If txtDni.Text <> "" Then
                    dtPer = objPersonal.buscarPersonal(txtDni.Text)
                    If dtPer.Rows.Count > 0 Then
                        objSolicitud.registrarSolicitud(CInt(dtPer.Rows(0).Item(0)), txtDescripcion.Text, ddlArea.Text, ddlPrioridad.Text)
                        lblMensaje.Text = "Solicitud registrada correctamente!"
                        limpiarControles()
                        listarSolicitudes()
                    Else
                        lblMensaje.Text = "DNI no está registrado!"
                        txtDni.Focus()
                    End If
                Else
                    lblMensaje.Text = "Ingrese DNI del solicitante!"
                    txtDni.Focus()
                End If
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub limpiarControles()
        txtId .Text =""
        txtDni .Text =""
        txtSolicitante .Text =""
        txtDescripcion .Text =""
        txtComentario.Text = ""
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objSolicitud.modificarSolicitud(CInt(txtId.Text), txtDescripcion.Text, ddlArea.Text, ddlPrioridad.Text, ddlEstado.Text, txtComentario.Text)
            lblMensaje.Text = "Solicitud modificada correctamente!"
            limpiarControles()
            listarSolicitudes()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objSolicitud.eliminarSolicitud(CInt(txtId.Text))
            lblMensaje.Text = "Solicitud eliminada correctamente!"
            limpiarControles()
            listarSolicitudes()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub grvSolicitudes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grvSolicitudes.SelectedIndexChanged
        txtId.Text = grvSolicitudes.SelectedRow.Cells(1).Text
        btnBuscar_Click(sender, e)
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dtSol As New DataTable
        Try
            If txtId.Text <> "" Then
                dtSol = objSolicitud.buscarSolicitud(CInt(txtId.Text))
                If dtSol.Rows.Count > 0 Then
                    txtId.Text = dtSol.Rows(0).Item(0)
                    txtDni.Text = dtSol.Rows(0).Item(2)
                    txtSolicitante.Text = dtSol.Rows(0).Item(3)
                    txtDescripcion.Text = dtSol.Rows(0).Item(4)
                    ddlArea.Text = dtSol.Rows(0).Item(5)
                    ddlPrioridad.Text = dtSol.Rows(0).Item(6)
                    ddlEstado.Text = dtSol.Rows(0).Item(7)
                    txtComentario.Text = dtSol.Rows(0).Item(8).ToString()
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
