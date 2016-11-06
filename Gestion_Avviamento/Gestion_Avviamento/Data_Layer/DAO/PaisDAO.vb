Public Class PaisDAO

    Public Function getAll() As List(Of Pais)
        Dim oPais As Pais
        Dim paises As New List(Of Pais)
        Dim strSQL = "SELECT id, descripcion FROM Paises"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Supplier a partir de los datos de la/s filas de la tabla Pais

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oPais = New Pais()
            With oPais
                .id = Convert.ToInt32(row.Item("id").ToString)
                .descripcion = row.Item("descripcion").ToString
            End With
            paises.Add(oPais)
        Next

        Return paises
    End Function

End Class
