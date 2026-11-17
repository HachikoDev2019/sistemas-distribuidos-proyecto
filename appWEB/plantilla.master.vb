
Partial Class plantilla
    Inherits System.Web.UI.MasterPage

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
    End Sub

    Protected Sub btnMInicio_Click(sender As Object, e As EventArgs) Handles btnMInicio.Click
        Response.Redirect("wfInicio.aspx")
    End Sub

    Protected Sub btnMIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnMIniciarSesion.Click
        Response.Redirect("wfLogin.aspx")
    End Sub

    Protected Sub btnMCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnMCerrarSesion.Click
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
End Class
