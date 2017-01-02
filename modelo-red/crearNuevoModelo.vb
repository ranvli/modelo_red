Public Class crearNuevoModelo

    Public userID As Integer
    Public username As String
    Public nombreDueno As String
    Public modificando As Boolean
    Public modeloID As Integer

    Private Sub crearNuevoModelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbUsuarioDueno.Text = "Nombre del dueño : " + nombreDueno
        If modificando Then Button1.Text = "Modificar datos del modelo"
        If Not modificando Then Button1.Text = "Guardar información del modelo"


    End Sub


    Private Sub btCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCerrar.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If tbNombreModelo.Text = "" Then
            MsgBox("El nombre del modelo no puede quedar en blanco.")
            Exit Sub
        End If

        If modificando Then
            ModelosTableAdapter.actualizar(tbNombreModelo.Text, tbDescripModelo.Text, modeloID)
            MsgBox("El modelo ha sido modificado.")
            menuModelos.refrescaModelos()
            Me.Close()
            Exit Sub
        End If


        ModelosTableAdapter.Insert(userID, tbNombreModelo.Text, tbDescripModelo.Text, 0)
        MsgBox("El modelo ha sido creado.")

        menuModelos.refrescaModelos()
        Me.Close()



    End Sub

End Class