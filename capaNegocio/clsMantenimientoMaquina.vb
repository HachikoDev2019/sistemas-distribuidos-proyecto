Imports System.Data
Imports capaDatos
Public Class clsMantenimientoMaquina
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    Public Function generarIDMantenimiento() As Integer
        strCon = "select isnull(max(id_mantenimiento),0)+1 from mantenimiento"
        Try
            dt = objMan.listarComando(strCon)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de mantenimiento!")
        End Try
    End Function

    Public Sub registrarMantenimiento(idMaquinaria As Integer, tipo As String, fecha As String, descripcion As String, costo As String, responsable As String)
        If costo = "" Then
            costo = "null"
        Else
            costo = costo.Replace(",", ".")
        End If
        strCon = "insert into mantenimiento (id_maquinaria, tipo, fecha, descripcion, costo, responsable) values(" & idMaquinaria & ",'" & tipo & "','" & fecha & "','" & descripcion & "'," & costo & ",'" & responsable & "')"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar mantenimiento!")
        End Try
    End Sub

    Public Sub modificarMantenimiento(id As Integer, idMaquinaria As Integer, tipo As String, fecha As String, descripcion As String, costo As String, responsable As String)
        If costo = "" Then
            costo = "null"
        Else
            costo = costo.Replace(",", ".")
        End If
        strCon = "update mantenimiento set id_maquinaria=" & idMaquinaria & ", tipo='" & tipo & "', fecha='" & fecha & "', descripcion='" & descripcion & "', costo=" & costo & ", responsable='" & responsable & "' where id_mantenimiento=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al modificar mantenimiento!")
        End Try
    End Sub

    Public Sub eliminarMantenimiento(id As Integer)
        strCon = "delete from mantenimiento where id_mantenimiento=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar mantenimiento!")
        End Try
    End Sub

    Public Function buscarMantenimiento(id As Integer) As DataTable
        strCon = "select m.id_mantenimiento, m.id_maquinaria, m.tipo, convert(varchar(10), m.fecha, 23), m.descripcion, m.costo, m.responsable from mantenimiento m where m.id_mantenimiento=" & id
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al buscar mantenimiento!")
        End Try
    End Function

    Public Function listarMantenimientos() As DataTable
        strCon = "select m.id_mantenimiento as ID, q.nombre_codigo as Maquina, m.tipo as Tipo, convert(varchar(10), m.fecha, 103) as Fecha, m.descripcion as Descripcion, m.costo as Costo, m.responsable as Responsable from mantenimiento m inner join maquinaria q on m.id_maquinaria = q.id_maquinaria order by m.fecha desc"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar los mantenimientos!")
        End Try
    End Function
End Class
