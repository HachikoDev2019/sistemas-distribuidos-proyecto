Imports System.Data
Imports capaNegocio
Partial Class wfMisSolicitudes
    Inherits System.Web.UI.Page
    Dim objSolicitud As New clsSolicitud

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblSolicitante.Text = Session("nombre")
            listar()
        End If
    End Sub

    Private Sub listar()
        Dim dt As New DataTable
        Try
            dt = objSolicitud.listarMisSolicitudes(CInt(Session("id")))
            grvMisSolicitudes.DataSource = dt
            grvMisSolicitudes.DataBind()
            If dt.Rows.Count = 0 Then
                lblMensaje.Text = "Aún no ha registrado solicitudes."
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        listar()
    End Sub
End Class
