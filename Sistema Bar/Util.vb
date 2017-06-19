Public Class Util
    Public Shared Sub tablaToGrilla(ByRef tabla As DataTable, ByRef grilla As DataGridView)
        grilla.Rows.Clear()

        Dim i, j As Integer
        For i = 0 To tabla.Rows.Count - 1
            grilla.Rows.Add()
            For j = 0 To tabla.Columns.Count - 1
                grilla.Rows(i).Cells(j).Value = tabla.Rows(i)(j)
            Next
        Next
    End Sub
End Class
