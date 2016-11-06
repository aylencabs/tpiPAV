Public Class VolDAO
    Public Function getAll() As List(Of Tipo_Volumen)
        Dim oVol As Tipo_Volumen
        Dim vols As New List(Of Tipo_Volumen)
        Dim strSQL = "SELECT id as id_vol, descripcion FROM TIPO_VOLUMEN " & _
            "ORDER BY 1 ASC"

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oVol = New Tipo_Volumen
            With oVol
                .descripcion = row.Item("descripcion").ToString
                .id_tipo_vol = Integer.Parse(row.Item("id_vol").ToString)
            End With
            vols.Add(oVol)
        Next
        Return vols
    End Function
End Class
