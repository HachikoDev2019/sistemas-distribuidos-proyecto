Imports System.Data
Imports capaDatos
Public Class clsZona
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    Public Function generarIDZona() As Integer
        strCon = "select isnull(max(id_zona),0)+1 from zona"
        Try
            dt = objMan.listarComando(strCon)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de zona!")
        End Try
    End Function

    Public Sub registrarZona(nombre As String, descripcion As String, vigente As Boolean)
        strCon = "insert into zona (nombre, descripcion, estado) values('" & nombre & "','" & descripcion & "','" & IIf(vigente, "Activo", "Inactivo") & "')"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar zona!")
        End Try
    End Sub

    Public Sub modificarZona(id As Integer, nombre As String, descripcion As String, vigente As Boolean)
        strCon = "update zona set nombre='" & nombre & "', descripcion='" & descripcion & "', estado='" & IIf(vigente, "Activo", "Inactivo") & "' where id_zona=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al modificar zona!")
        End Try
    End Sub

    Public Sub eliminarZona(id As Integer)
        strCon = "delete from zona where id_zona=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("No se puede eliminar: la zona está en uso. Use Dar de Baja.")
        End Try
    End Sub

    Public Sub darBajaZona(id As Integer)
        strCon = "update zona set estado='Inactivo' where id_zona=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja la zona!")
        End Try
    End Sub

    Public Function buscarZona(nombre As String) As DataTable
        strCon = "select id_zona, nombre, descripcion, estado from zona where nombre='" & nombre & "'"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al buscar zona!")
        End Try
    End Function

    Public Function listarZonas() As DataTable
        strCon = "select id_zona as ID, nombre as Zona, descripcion as Descripcion, estado as Estado from zona"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las zonas!")
        End Try
    End Function

    Public Function listarZonasCombo() As DataTable
        strCon = "select nombre from zona where estado='Activo' order by nombre"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las zonas!")
        End Try
    End Function
End Class
