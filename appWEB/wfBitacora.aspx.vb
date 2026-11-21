Imports capaNegocio
Partial Class wfBitacora
    Inherits System.Web.UI.Page
    Dim objBitacora As New clsBitacora

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("tipo") <> "Administrador" Then
            Response.Redirect("wfInicio.aspx")
        End If
        listar
    End Sub

    Private Sub listar()
        Try
            grvBitacora.DataSource = objBitacora.listar
            grvBitacora.DataBind()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        listar
    End Sub
End Class
