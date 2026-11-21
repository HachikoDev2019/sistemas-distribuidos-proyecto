Imports System.Data
Imports capaDatos
Public Class clsBitacora
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    Private Function generarIdRegistro() As Integer
        strCon = "select isnull(max(idRegistro),0)+1 from bitacora_login"
        Try
            dt = objMan.listarComando(strCon)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de registro!")
        End Try
    End Function

    Public Sub registrar(idUsuario As Integer, accion As String, numIntentos As Integer)
        Dim fecha As String
        Dim hora As String
        Dim intentos As String
        fecha = Date.Now.ToString("yyyy-MM-dd")
        hora = Date.Now.ToString("HH:mm:ss")
        If numIntentos = 0 Then
            intentos = "null"
        Else
            intentos = numIntentos
        End If
        strCon = "insert into bitacora_login (idRegistro, fechaReg, horaReg, idUsuario, accion, numIntentos) values(" & generarIdRegistro() & ",'" & fecha & "','" & hora & "'," & idUsuario & ",'" & accion & "'," & intentos & ")"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar la bitácora!")
        End Try
    End Sub

    Public Function listar() As DataTable
        strCon = "select b.idRegistro as N, convert(varchar(10), b.fechaReg, 103) as Fecha, b.horaReg as Hora, isnull(p.nombres + ' ' + p.apellidos, 'No conectado') as Usuario, b.accion as Accion, b.numIntentos as Intentos from bitacora_login b left join personal p on b.idUsuario = p.id_personal order by b.idRegistro desc"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar la bitácora!")
        End Try
    End Function
End Class
