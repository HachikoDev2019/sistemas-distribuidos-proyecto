Partial Class wfCambiarContrasena
    Inherits System.Web.UI.Page
    Dim objPersonal As New ServiceReferencePomalca.wsPomalcaSoapClient
    Dim objBitacora As New ServiceReferencePomalca.wsPomalcaSoapClient

    Protected Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Try
            If txtActual.Text = "" Or txtNueva.Text = "" Or txtConfirmar.Text = "" Then
                lblMensaje.Text = "Complete todos los campos!"
            Else
                If Not objPersonal.iniciarSesion(Session("dni"), txtActual.Text) Then
                    lblMensaje.Text = "La contraseña actual es incorrecta!"
                Else
                    If txtNueva.Text <> txtConfirmar.Text Then
                        lblMensaje.Text = "Las contraseñas no coinciden!"
                    Else
                        objPersonal.cambiarContrasena(Session("dni"), txtNueva.Text)
                        Try
                            objBitacora.registrarBitacora(CInt(Session("id")), "updatePassword", 0)
                        Catch ex As Exception
                        End Try
                        lblMensaje.Text = "Contraseña cambiada correctamente!"
                        txtActual.Text = ""
                        txtNueva.Text = ""
                        txtConfirmar.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
