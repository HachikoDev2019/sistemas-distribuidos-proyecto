Imports System.Data
Imports capaDatos
Public Class clsPersonal
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    Public Function validarDNI(dni As String) As Boolean
        strCon = "select * from personal where dni='" & dni & "'"
        Try
            dt = objMan.listarComando(strCon)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error al validar el DNI!")
        End Try
    End Function

    Public Function iniciarSesion(dni As String, contraseña As String) As Boolean
        strCon = "select * from personal where dni='" & dni & "' and password='" & contraseña & "' and estado='Activo'"
        Try
            dt = objMan.listarComando(strCon)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error al iniciar sesión!")
        End Try
    End Function

    Public Function generarIDPersonal() As Integer
        strCon = "select isnull(max(id_personal),0)+1 from personal"
        Try
            dt = objMan.listarComando(strCon)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de personal!")
        End Try
    End Function

    Public Sub registrarPersonal(dni As String, nombres As String, apellidos As String, telefono As String, correo As String, contraseña As String, tipo_usuario As String, area As String, vigente As Boolean)
        strCon = "insert into personal (dni, nombres, apellidos, telefono, correo, password, tipo_usuario, area, estado) values('" & dni & "','" & nombres & "','" & apellidos & "','" & telefono & "','" & correo & "','" & contraseña & "','" & tipo_usuario & "','" & area & "','" & IIf(vigente, "Activo", "Inactivo") & "')"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar personal!")
        End Try
    End Sub

    Public Sub modificarPersonal(id As Integer, dni As String, nombres As String, apellidos As String, telefono As String, correo As String, contraseña As String, tipo_usuario As String, area As String, vigente As Boolean)
        strCon = "update personal set dni='" & dni & "', nombres='" & nombres & "', apellidos='" & apellidos & "', telefono='" & telefono & "', correo='" & correo & "', password='" & contraseña & "', tipo_usuario='" & tipo_usuario & "', area='" & area & "', estado='" & IIf(vigente, "Activo", "Inactivo") & "' where id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al modificar personal!")
        End Try
    End Sub

    Public Sub eliminarPersonal(id As Integer)
        strCon = "delete from personal where id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar personal!")
        End Try
    End Sub

    Public Sub darBajaPersonal(id As Integer)
        strCon = "update personal set estado='Inactivo' where id_personal=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja al personal!")
        End Try
    End Sub

    Public Function buscarPersonal(dni As String) As DataTable
        strCon = "select id_personal, dni, nombres, apellidos, telefono, correo, password, tipo_usuario, area, estado from personal where dni='" & dni & "'"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al buscar personal!")
        End Try
    End Function

    Public Function listarPersonal() As DataTable
        strCon = "select id_personal as ID, dni as DNI, nombres + ' ' + apellidos as Personal, tipo_usuario as Tipo, area as Area, estado as Estado from personal"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar el personal!")
        End Try
    End Function
End Class
