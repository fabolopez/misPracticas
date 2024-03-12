Public Class formIngreso

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim Usuario, Clave As String

        Usuario = textBoxNombre.Text : Clave = textBoxClave.Text

        If Usuario.Length >= 2 And Clave.Length > 2 Then

            If (Usuario = "Maritza") And (Clave = "1234") Then

                Me.Hide()
                formPrincipalInicio.Show()

            Else
                MsgBox("¡Los datos son incorrectos!")

            End If

        Else
                MsgBox("¡Necesitas colocar un usuario y una clave!")
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub
End Class