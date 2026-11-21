
Imports capaNegocio
Partial Class plantilla
    Inherits System.Web.UI.MasterPage
    Dim objBitacora As New clsBitacora

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("tipo") Is Nothing Then
            Response.Redirect("wfLogin.aspx")
        End If
        lblUsuario.Text = Session("nombre") & " (" & Session("tipo") & ")"
        aplicarPermisos()
    End Sub

    Private Sub aplicarPermisos()
        Dim tipo As String = Session("tipo")
        btnMPersonal.Visible = (tipo = "Administrador")
        btnMMaquinaria.Visible = (tipo = "Administrador" Or tipo = "Supervisor")
        btnMSolicitudes.Visible = True
        btnMActividad.Visible = True
        btnMIniciarSesion.Visible = False
        btnMBitacora.Visible = (tipo = "Administrador")
        btnMCambiarContrasena.Visible = True
        lblModMaquinaria.Visible = btnMMaquinaria.Visible
    End Sub

    Protected Sub btnMInicio_Click(sender As Object, e As EventArgs) Handles btnMInicio.Click
        Response.Redirect("wfInicio.aspx")
    End Sub

    Protected Sub btnMIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnMIniciarSesion.Click
        Response.Redirect("wfLogin.aspx")
    End Sub

    Protected Sub btnMCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnMCerrarSesion.Click
        Try
            objBitacora.registrar(CInt(Session("id")), "logout", 0)
        Catch ex As Exception
        End Try
        Session.Abandon()
        Response.Redirect("wfLogin.aspx")
    End Sub

    Protected Sub btnMPersonal_Click(sender As Object, e As EventArgs) Handles btnMPersonal.Click
        Response.Redirect("wfPersonal.aspx")
    End Sub

    Protected Sub btnMMaquinaria_Click(sender As Object, e As EventArgs) Handles btnMMaquinaria.Click
        Response.Redirect("wfMaquinaria.aspx")
    End Sub

    Protected Sub btnMSolicitudes_Click(sender As Object, e As EventArgs) Handles btnMSolicitudes.Click
        Response.Redirect("wfSolicitudes.aspx")
    End Sub

    Protected Sub btnMActividad_Click(sender As Object, e As EventArgs) Handles btnMActividad.Click
        Response.Redirect("wfActividad.aspx")
    End Sub

    Protected Sub btnMCambiarContrasena_Click(sender As Object, e As EventArgs) Handles btnMCambiarContrasena.Click
        Response.Redirect("wfCambiarContrasena.aspx")
    End Sub

    Protected Sub btnMBitacora_Click(sender As Object, e As EventArgs) Handles btnMBitacora.Click
        Response.Redirect("wfBitacora.aspx")
    End Sub
End Class
