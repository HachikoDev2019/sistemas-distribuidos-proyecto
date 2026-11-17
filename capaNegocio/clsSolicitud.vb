Imports System.Data
Imports capaDatos
Public Class clsSolicitud
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    Public Function generarIDSolicitud() As Integer
        strCon = "select isnull(max(id_solicitud),0)+1 from solicitudes"
        Try
            dt = objMan.listarComando(strCon)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de solicitud!")
        End Try
    End Function

    Public Sub registrarSolicitud(idPersonal As Integer, descripcion As String, area As String, prioridad As String)
        strCon = "insert into solicitudes (id_personal, descripcion, area, prioridad, estado) values(" & idPersonal & ",'" & descripcion & "','" & area & "','" & prioridad & "','Pendiente')"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar solicitud!")
        End Try
    End Sub

    Public Sub modificarSolicitud(id As Integer, descripcion As String, area As String, prioridad As String, estado As String, comentario As String)
        strCon = "update solicitudes set descripcion='" & descripcion & "', area='" & area & "', prioridad='" & prioridad & "', estado='" & estado & "', comentario='" & comentario & "' where id_solicitud=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al modificar solicitud!")
        End Try
    End Sub

    Public Sub eliminarSolicitud(id As Integer)
        strCon = "delete from solicitudes where id_solicitud=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar solicitud!")
        End Try
    End Sub

    Public Function buscarSolicitud(id As Integer) As DataTable
        strCon = "select s.id_solicitud, s.id_personal, p.dni, p.nombres + ' ' + p.apellidos, s.descripcion, s.area, s.prioridad, s.estado, s.comentario from solicitudes s inner join personal p on s.id_personal = p.id_personal where s.id_solicitud=" & id
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al buscar solicitud!")
        End Try
    End Function

    Public Function listarSolicitudes() As DataTable
        strCon = "select s.id_solicitud as ID, p.nombres + ' ' + p.apellidos as Solicitante, s.descripcion as Descripcion, s.area as Area, s.prioridad as Prioridad, s.estado as Estado, convert(varchar(10), s.fecha_registro, 103) as Fecha from solicitudes s inner join personal p on s.id_personal = p.id_personal order by s.id_solicitud desc"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las solicitudes!")
        End Try
    End Function
End Class
