Public Class Form1


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim res As Integer

        listBoxTablas.Items.Clear()

        For i As Integer = 1 To 10
            res = (i * 9)
            listBoxTablas.Items.Add("9x" & i & "=" & res)
        Next


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formNumero.Show()
        form2dividir.Show()
        formIngreso.Show()
    End Sub
End Class
