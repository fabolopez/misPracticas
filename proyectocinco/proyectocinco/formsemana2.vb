Public Class formNumero
    Private Sub btbAceptar_Click(sender As Object, e As EventArgs) Handles btbAceptar.Click
        Dim NombrePersona As String = nombreTextBox.Text


        If NombrePersona = "" Then
            Return
        End If

        Dim numeroDado As String = numeroTexBox.Text

        If Val(numeroDado) = 5 Then
            MsgBox(NombrePersona & " ¡Acaba de ganar un premio!")
        Else
            MsgBox("¡Lastima " & NombrePersona & ", no ganó nada tenga feliz día!")
        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        numeroTexBox.Clear()
        nombreTextBox.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub



End Class