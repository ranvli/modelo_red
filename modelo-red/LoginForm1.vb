Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        'si es root entonces iniciar menu de edicion de usuarios
        If UsernameTextBox.Text = "root" And PasswordTextBox.Text = "root" Then
            Me.Hide()
            menuUsuarios.Show()
            Exit Sub
        End If

        'logearse
        'si el resultado resLogin es 1 la autenticación fue exitosa
        'else, no.
        Dim resLogin As Integer = 0
        If Me.UsuariosTableAdapter.login(UsernameTextBox.Text, PasswordTextBox.Text) >= 0 Then resLogin = 1


        If resLogin = 1 Then
            MsgBox("Autenticación exitosa!")
            menuModelos.username = UsernameTextBox.Text
            Me.Hide()
            menuModelos.Show()
        End If

        If resLogin = 0 Then MsgBox("Usuario/Password incorrectos.")





    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        MsgBox("Gracias por utilizar nuestros programas. Saliendo de la aplicación.")
        End

    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_modelo_redDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me._modelo_redDataSet.usuarios)

    End Sub
End Class
