﻿Public Class form2dividir
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim resultado, numero1, numero2 As Integer




        numero1 = Val(textBoxn1.Text)
        numero2 = Val(textBoxn2.Text)

        If numero1 = 0 Or numero2 = 0 Then
            MsgBox("¡No estan definidos los campos!")
            Return
        End If


        resultado = (numero1 \ numero2)
        labelResultado.Text = resultado






    End Sub
End Class