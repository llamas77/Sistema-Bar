﻿Public Class VMaskedTextBox
    Inherits MaskedTextBox
    Implements Validable

    Public Property NombreVisual As String Implements Validable.NombreVisual
    Public Property VObligatorio As Boolean

    Public Property EMensaje As String Implements Validable.EMensaje

    Public Sub New()
        MyBase.New()
        NombreVisual = "sin nombre"
    End Sub

    Public Function validar() As Boolean Implements Validable.validar
        If VObligatorio Then
            If Text.Trim = "" Or Text.Trim = "/  /       :" Or
                Text.Trim = "/  /" Or Text.Trim = ":" Then
                EMensaje = "El campo: '" & NombreVisual & "' es obligatorio."
                Return False
            End If
        End If

        Return True
    End Function
End Class
