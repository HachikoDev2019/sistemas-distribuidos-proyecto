Imports System.Data
Partial Class wfJornadasActivas
    Inherits System.Web.UI.Page
    Dim objActividad As New ServiceReferencePomalca.wsPomalcaSoapClient

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            listar()
        End If
    End Sub

    Private Sub listar()
        Dim dt As New DataTable
        Try
            dt = objActividad.listarJornadasActivas
            grvJornadas.DataSource = dt
            grvJornadas.DataBind()
            lblTotal.Text = "Máquinas trabajando ahora: " & dt.Rows.Count
            If dt.Rows.Count = 0 Then
                lblMensaje.Text = "No hay jornadas activas en este momento."
            Else
                lblMensaje.Text = ""
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        listar()
    End Sub

    Protected Sub grvJornadas_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grvJornadas.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.Cells(7).Text = "RETRASADA" Then
            e.Row.ForeColor = Drawing.Color.Red
        End If
    End Sub
End Class
