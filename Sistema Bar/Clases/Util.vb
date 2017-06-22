Public Class Util

    Enum eTipoAct
        insertar
        modificar
    End Enum

    Public Shared Function setTipoAct(ByVal tipoAct As eTipoAct, ByVal boton As Button) As eTipoAct
        Select Case tipoAct
            Case eTipoAct.insertar
                boton.Text = "Agregar"
            Case eTipoAct.modificar
                boton.Text = "Actualizar"
        End Select
        Return tipoAct
    End Function

    ' Valida que todos los controles de un formulario cumplan con ciertas condiciones
    Public Shared Function validarForm(ByRef form As Form) As Boolean
        Dim c As Validable
        For Each control As Control In form.Controls
            If TypeOf control Is Validable Then
                c = control
                If Not c.validar() Then
                    MsgBox(c.EMensaje, vbCritical)
                    Dim v As Vaciable
                    If TypeOf form Is Vaciable Then
                        v = form
                        v.FirstControl.Select()
                    End If
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    ' Vacía los controles editables de un formulario
    Public Shared Sub vaciarForm(ByRef form As Form)
        For Each control As Control In form.Controls
            If TypeOf control Is Validable Then
                If TypeOf control Is ComboBox Then
                    Dim combo As ComboBox
                    combo = control
                    combo.SelectedIndex = -1
                ElseIf TypeOf control Is TextBoxBase Then
                    Dim texto As TextBoxBase
                    texto = control
                    texto.Text = ""
                End If
            End If
        Next

        ' Hace foco el el elemento definido como el primero
        Dim f As Vaciable
        If TypeOf form Is Vaciable Then
            f = form
            f.FirstControl.Select()
        End If

    End Sub

    Public Shared Function puedeActuarEnGrilla(ByRef grilla As DataGridView) As Boolean
        If grilla.Rows.Count = 0 Then
            MsgBox("No hay ningún elemento en la grilla.", vbCritical)
            Return False
        End If
        Return True
    End Function

    ' Carga una grilla segun un DataTable
    Public Shared Sub cargarGrilla(ByRef db As AccesoDatos, ByVal sql As String, ByRef grilla As DataGridView)
        'Guarda la posición de la celda seleccionada
        Dim index As Integer
        If grilla.Rows.Count > 0 Then
            index = grilla.CurrentRow.Index
        End If

        ' Construye el DataTable
        grilla.Rows.Clear()
        Dim tabla As DataTable = db.ejecutarSQL(sql)

        ' Carga el DataTable en la grilla
        Dim i, j As Integer
        For i = 0 To tabla.Rows.Count - 1
            grilla.Rows.Add()
            For j = 0 To tabla.Columns.Count - 1
                grilla.Rows(i).Cells(j).Value = tabla.Rows(i)(j)
            Next
        Next

        ' Posiciona la selección donde estaba
        If grilla.Rows.Count > 0 Then
            If grilla.Rows.Count() <= index Then ' Si tenia la ultima celda y tengo menos valores selecciono el ultimo.
                index = grilla.Rows.Count - 1
            End If
            grilla.CurrentCell = grilla.Rows(index).Cells(grilla.FirstDisplayedCell.ColumnIndex)
        End If
    End Sub

    ' Agrega/reemplaza caracteres necesarios (según tipo de dato) (para INSERT o números con decimales)
    Public Shared Function formatear(ByVal dato As String, Optional ByVal tipoDato As String = "Numero") As String
        Select Case tipoDato
            Case "String", "Date", "DateTime"
                Return "'" & dato.Trim & "'"
            Case Else
                Return dato.Trim.Replace(",", ".")
        End Select
    End Function

    ' Carga un ComboBox según tabla
    Public Shared Sub cargarCombo(ByRef combo As ComboBox, ByVal tabla As DataTable, ByVal pk As String, ByVal descriptor As String)
        combo.DataSource = tabla
        combo.ValueMember = pk
        combo.DisplayMember = descriptor
        combo.SelectedIndex = -1
    End Sub

    ' Buscar en la grilla según texto y columna seleccionada
    Public Shared Sub buscar(ByRef txt As TextBoxBase, ByRef grilla As DataGridView)
        If grilla.Rows.Count = 0 Then Return

        Dim columnIndex As Integer = grilla.CurrentCell.ColumnIndex
        Dim i As Integer
        For i = 0 To grilla.Rows.Count - 1
            If grilla.Rows(i).Cells(columnIndex).Value.ToString().ToUpper().Contains(txt.Text.ToUpper()) Then
                grilla.CurrentCell = grilla.Rows(i).Cells(columnIndex)
                Return
            End If
        Next
    End Sub

    Public Shared Function vInputBox(ByVal texto As String, Optional ByVal titulo As String = "", Optional ByVal numero As Boolean = False, Optional ByVal minimo As Integer = 0) As String
        Dim res As String
        res = InputBox(texto, titulo)
        If res = "" Then Return ""

        If numero Then
            If Not IsNumeric(res) Then
                MsgBox("El valor ingresado debe ser un número.", vbCritical)
                Return ""
            End If

            If Val(res) < minimo Then
                MsgBox("El número debe ser mayor o igual que " & minimo, vbCritical)
                Return ""
            End If
        End If
        Return res

    End Function
End Class
