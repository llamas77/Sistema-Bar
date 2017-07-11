Imports Sistema_Bar

Public Class VTextBox
    Inherits TextBox
    Implements Validable

    Public Property NombreVisual As String Implements Validable.NombreVisual

    Public Property NumMin As Integer
    Public Property NumLimit As Long

    Public Property VNumero As Boolean
    Public Property VPositivo As Boolean
    Public Property VNumLimit As Boolean
    Public Property VNumMin As Boolean
    Public Property VObligatorio As Boolean

    Public Property EMensaje As String Implements Validable.EMensaje

    Public Sub New()
        MyBase.New()
        NombreVisual = "sin nombre"
        NumLimit = 999999999
        NumMin = 0
    End Sub

    Public Function validar() As Boolean Implements Validable.validar
        If VObligatorio Then
            If Text.Trim = "" Then
                EMensaje = "El campo: '" & NombreVisual & "' es obligatorio."
                Return False
            End If

        End If

        If Text.Trim <> "" Then
            If VNumero Then
                If Not IsNumeric(Text) Then
                    EMensaje = "El campo: '" & NombreVisual & "' debe ser un número."
                    Return False
                End If

                If VPositivo Then
                    If Val(Text) < 0 Then
                        EMensaje = "El campo: '" & NombreVisual & "' debe ser un número positivo."
                        Return False
                    End If
                End If

                If VNumMin Then
                    If Val(Text) < NumMin Then
                        EMensaje = "El número del campo: '" & NombreVisual & "' debe ser mayor o igual a " & NumMin & "."
                        Return False
                    End If
                End If

                If VNumLimit Then
                    If Val(Text) > NumLimit Then
                        EMensaje = "El número del campo: '" & NombreVisual & "' debe ser menor o igual a " & NumLimit & "."
                        Return False
                    End If
                End If
            End If
        End If

        Return True
    End Function
End Class
