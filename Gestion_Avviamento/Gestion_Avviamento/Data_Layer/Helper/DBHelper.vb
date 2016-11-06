Imports System.Data.SqlClient

Public Class BDHelper
    ' La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    ' Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    ' Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    Private string_conexion As String
    Private Shared instance As BDHelper 'Unica instancia de la clase

    Private Sub New()
        string_conexion = "Data Source=AYLÉN-PC\AYLEN;Initial Catalog=TPI;User ID=avisuales; Password=instance"
    End Sub

    Public Shared Function getDBHelper() As BDHelper
        If IsNothing(instance) Then
            instance = New BDHelper()
        End If
        Return instance
    End Function

    Public Function EjecutarSQL(ByVal strSql As String) As Integer
        ' La función EjecutarSQL es una función compartida y puede ser invocada desde cualquier componente del proyecto
        ' Establece la conexión con la base de datos usando la clase SqlConnection
        ' Dimensiona los objetos conexion y sqlcomand 

        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar la consulta
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' La función ConsultaSQL es una función compartida y puede ser invocada desde cualquier componente del proyecto
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function EjecutarTRANS(ByVal strSql As String) As Integer
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim trans As SqlTransaction = Nothing
        Dim status As Integer = 0
        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            trans = conexion.BeginTransaction()
            With cmd
                .Connection = conexion
                .CommandType = CommandType.Text
                ' Establece la instrucción a ejecutar
                .Transaction = trans
                .CommandText = strSql
                ' Retorna el resultado de ejecutar el comando
                status = .ExecuteNonQuery()
            End With
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            status = 0
            Throw ex
        Finally
            ' Cierra la conexión
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status
    End Function

    Public Function report_origen_mat(Optional ByVal id_pais As Integer = -1) As DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Dim strSQL = "SELECT T5.descripcion as pais, t2.descripcion as tipo_vol, COUNT(T1.ID_MAT) as cant_mat" & _
            " FROM Material T1, Tipo_Volumen T2, Prov_X_Mat T3, Proveedor T4, Paises T5" & _
            " WHERE(T1.id_mat = T3.id_mat) AND T1.tipo_vol = T2.id AND T3.id_prov = T4.cod_proveedor" & _
            " AND T4.pais = T5.id AND T1.habilitado = 0 AND T4.habilitado = 0 "

        If id_pais <> -1 Then
            strSQL += " AND T5.id = " + id_pais.ToString
        End If

        strSQL += " GROUP BY T5.descripcion, t2.descripcion"
        strSQL += " ORDER BY 1, 2 ASC"
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL
            tabla.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try

        Return tabla
    End Function
End Class