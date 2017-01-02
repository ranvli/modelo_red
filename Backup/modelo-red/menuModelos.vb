Imports System
Imports System.Web.Mail

Public Class menuModelos

    Dim email As String
    Dim telefono As String
    Dim tipoUsuario As String
    Public username As String
    Public esCreador As Integer

    'tabla de modelos, usuario y su info
    Dim tablaUsuario As DataTable
    Dim tablaUsuarioDueno As DataTable
    Dim tablaModelos As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'llena el databind de listbox de modelos con el userid logeado
        Me.ModelosTableAdapter.FillByUsuarioID(Me._modelo_redDataSet.modelos, username)

        'llena la tabla con los modelos del cliente logeado
        tablaUsuario = UsuariosTableAdapter.GetDataByUserID(username)


        'llena la información del usuario
        lbNombre.Text = "Nombre : " + tablaUsuario.Rows(0).Item("nombre").ToString
        lbEmail.Text = "E-Mail : " + tablaUsuario.Rows(0).Item("email").ToString
        lbTel.Text = "Teléfono : " + tablaUsuario.Rows(0).Item("telefono").ToString
        esCreador = tablaUsuario.Rows(0).Item("esAdmin").ToString


        refrescaModelos()


        'aqui solo si es un usuario visor
        If esCreador = 0 Then

            'llena la tablaUsuarioDueno con la info del dueno
            tablaUsuarioDueno = UsuariosTableAdapter.GetdatosDuenoModeloNombre(lbModelos.SelectedValue)

            'llena los labees informativos del dueno
            lbDuenoNombre.Text = "Nombre del dueño del modelo seleccionado : " + tablaUsuarioDueno.Rows(0).Item("nombre").ToString
            lbDuenoEmail.Text = "E-mail : " + tablaUsuarioDueno.Rows(0).Item("email").ToString
            lbDuenoTel.Text = "Teléfono : " + tablaUsuarioDueno.Rows(0).Item("telefono").ToString
            lbDuenoUsuario.Text = "Nombre de usuario : " + tablaUsuarioDueno.Rows(0).Item("userid").ToString
        End If

        'modifia el modeloID del editor por si lo abre
        editor.modeloID = lbModelos.SelectedValue
        reporte.modeloID = lbModelos.SelectedValue


    End Sub
    Public Sub refrescaModelos()

        If tablaUsuario.Rows(0).Item("esAdmin").ToString = "1" Then
            lbTipoUsuario.Text = "Tipo de Usuario : Creador - Editor"

            'llena el tablaModelos con el userId logeado en el caso de ser un usuario creador
            'se llena con los modelos que le pertenecen
            'llena el databind de listbox de modelos con el userid logeado
            tablaModelos = ModelosTableAdapter.GetDataByUsuarioID(username)
            ModelosBindingSource.DataSource = tablaModelos

            'pune los datagrid de usuarios permisos, y los botones de traspaso
            Label5.Text = "Mis modelos"
            bAgregar.Visible = True
            bDesasignar.Visible = True
            gbUsuariosConPermisos.Visible = True
            gbUsuariosSinPermisos.Visible = True
            gbModMostrar.Visible = False
            'quita la info del dueno
            gbInfo.Visible = False

            'modifia el modeloID del editor por si lo abre
            editor.modeloID = lbModelos.SelectedValue
            reporte.modeloID = lbModelos.SelectedValue

        Else
            lbTipoUsuario.Text = "Tipo de Usuario : Visualizador - modifica pero no puede salvar"
            'llena el tablaModelos que tiene permiso ver el userId logeado
            tablaModelos = ModelosTableAdapter.GetDataByPermisoAusuarioID(username)
            ModelosBindingSource.DataSource = tablaModelos
            'quita los datagrid de usuarios permisos, y los botones de traspaso
            Label5.Text = "Modelos que tiene permitido ver"
            bAgregar.Visible = False
            bDesasignar.Visible = False
            gbUsuariosConPermisos.Visible = False
            gbUsuariosSinPermisos.Visible = False
            gbModMostrar.Visible = True
            'pone la info del dueno
            gbInfo.Visible = True
        End If



    End Sub
    Private Sub refrescaPermisos()


        'llena la lista de los usuarios no asignados a este modelo
        dgvTodosUsuarios.DataSource = UsuariosTableAdapter.getUsuariosNoAsignados(lbModelos.SelectedValue)
        dgvTodosUsuarios.Refresh()

        'llena la lista de usuarios con permisos asignados a este modelo
        dgvPermisosLectura.DataSource = UsuariosTableAdapter.getUsuariosAsignados(lbModelos.SelectedValue)
        dgvPermisosLectura.Refresh()


    End Sub

    Private Sub lbModelos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbModelos.DoubleClick



    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbModelos.SelectedIndexChanged


        'refresca la descripcion refrescando el binding
        ModelosBindingSource.ResetBindings(False)
        refrescaPermisos()


        'modifia el modeloID del editor por si lo abre
        editor.modeloID = lbModelos.SelectedValue
        reporte.modeloID = lbModelos.SelectedValue


        'aqui solo si es un usuario visor
        If esCreador = 0 Then
            'llena la tablaUsuarioDueno con la info del dueno
            tablaUsuarioDueno = UsuariosTableAdapter.GetdatosDuenoModeloNombre(lbModelos.SelectedValue)

            'llena los labees informativos del dueno
            lbDuenoNombre.Text = "Nombre del dueño del modelo seleccionado : " + tablaUsuarioDueno.Rows(0).Item("nombre").ToString
            lbDuenoEmail.Text = "E-mail : " + tablaUsuarioDueno.Rows(0).Item("email").ToString
            lbDuenoTel.Text = "Teléfono : " + tablaUsuarioDueno.Rows(0).Item("telefono").ToString
            lbDuenoUsuario.Text = "Nombre de usuario : " + tablaUsuarioDueno.Rows(0).Item("userid").ToString
        End If


    End Sub

    Private Sub bAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAgregar.Click


        If dgvTodosUsuarios.SelectedRows.Count = 0 Then
            MsgBox("Debe de seleccionar uno o mas usuarios a agregar de la lista de usuarios sin permisos.")
            Exit Sub
        End If

        Dim usuarioID As Integer

        For Each row In dgvTodosUsuarios.SelectedRows
            usuarioID = dgvTodosUsuarios.Rows(row.index).Cells(0).Value
            Permisos_lecturaTableAdapter.asignarPermisosLectura(lbModelos.SelectedValue, usuarioID)
        Next


        'usuarioID = dgvTodosUsuarios.CurrentRow.Cells(0).Value
        'Permisos_lecturaTableAdapter.asignarPermisosLectura(lbModelos.SelectedValue, usuarioID)


        refrescaPermisos()


    End Sub

    Private Sub bDesasignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDesasignar.Click



        If dgvPermisosLectura.SelectedRows.Count = 0 Then
            MsgBox("Debe de seleccionar uno o mas usuarios a remover de la lista de usuarios con permisos.")
            Exit Sub
        End If

        Dim usuarioID As Integer


        For Each row In dgvPermisosLectura.SelectedRows
            usuarioID = dgvPermisosLectura.Rows(row.index).Cells(0).Value
            Permisos_lecturaTableAdapter.eliminaPermisoLectura(lbModelos.SelectedValue, usuarioID)
        Next


        'Dim usuarioID As Integer = dgvPermisosLectura.CurrentRow.Cells(0).Value
        'Permisos_lecturaTableAdapter.eliminaPermisoLectura(lbModelos.SelectedValue, usuarioID)


        refrescaPermisos()


    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click


        MsgBox("Gracias por utilizar nuestro software! Saliendo de la aplicación.")
        End


    End Sub

    Private Sub CrearNuevoModeloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearNuevoModeloToolStripMenuItem.Click

        'carca el id del usuario para usarlo para crear nuevos modelos
        Dim userID As Integer
        Dim username As String
        Dim nombre As String


        userID = Convert.ToInt16(tablaUsuario.Rows(0).Item("id").ToString)
        username = tablaUsuario.Rows(0).Item("userid").ToString
        nombre = tablaUsuario.Rows(0).Item("nombre").ToString

        If esCreador = 0 Then
            MsgBox("Su cuenta no tiene permisos para crear nuevos modelos.")
            Exit Sub
        End If



        crearNuevoModelo.modeloID = -1
        crearNuevoModelo.tbNombreModelo.Text = ""
        crearNuevoModelo.tbDescripModelo.Text = ""
        crearNuevoModelo.modificando = False

        crearNuevoModelo.userID = userID
        crearNuevoModelo.username = username
        crearNuevoModelo.nombreDueno = nombre
        crearNuevoModelo.ShowDialog()


    End Sub


    Private Sub EditarModeloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarModeloToolStripMenuItem.Click


        If lbModelos.SelectedValue Is Nothing Then
            MsgBox("Debe de seleccionar un modelo de la lista")
            Exit Sub
        End If

        If esCreador = 0 Then
            MsgBox("Su cuenta no tiene permisos para crear nuevos modelos.")
            Exit Sub
        End If

        Dim userID As Integer
        Dim username As String
        Dim nombre As String


        userID = Convert.ToInt16(tablaUsuario.Rows(0).Item("id").ToString)
        username = tablaUsuario.Rows(0).Item("userid").ToString
        nombre = tablaUsuario.Rows(0).Item("nombre").ToString

        crearNuevoModelo.modeloID = lbModelos.SelectedValue
        crearNuevoModelo.userID = userID
        crearNuevoModelo.username = username
        crearNuevoModelo.nombreDueno = nombre
        crearNuevoModelo.tbNombreModelo.Text = lbModelos.Text
        crearNuevoModelo.tbDescripModelo.Text = tbDescripModelo.Text
        crearNuevoModelo.modificando = True

        crearNuevoModelo.ShowDialog()


    End Sub

    Private Sub VerModeloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerModeloToolStripMenuItem.Click



        If editor.modeloID = 0 Or lbModelos.SelectedValue Is Nothing Then
            MsgBox("Debe de seleccionar un modelo de la lista")
            Exit Sub
        End If
        
        editor.ShowDialog()






    End Sub

    Private Sub BorrarModeloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarModeloToolStripMenuItem.Click



        If esCreador = 0 Then
            MsgBox("Su cuenta no tiene permisos para borrar modelos.")
            Exit Sub
        End If

        If lbModelos.SelectedValue Is Nothing Then
            MsgBox("Debe de seleccionar un modelo de la lista")
            Exit Sub
        End If

        Dim resp As Integer = MsgBox("Está seguro que desea borrar el modelo " + lbModelos.Text + " (" + lbModelos.SelectedValue.ToString + ") ?", MsgBoxStyle.YesNo, "Borrar modelo")

        If resp = 7 Then
            MsgBox("Operación de borrar modelo ha sido cancelada.")
            Exit Sub
        End If

        ModelosTableAdapter.borrar(lbModelos.SelectedValue)
        refrescaModelos()

        MsgBox("El modelo ha sido borrado.")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSolicPermisos.Click

        MsgBox("Se enviará un email al dueño del modelo, sin embargo no garantizamos que él le dé el permiso. Favor presione OK y espere la confirmación del email ha sido enviado.")

        Dim msgEmail As String
        Dim destinatario As String = lbDuenoEmail.Text.Substring(9)
        Dim remitente As String = "jpslibra@yahoo.com"
        Dim emailUsr As String = "jpslibra"
        Dim emailPW As String = "nerak1326"
        Dim emailSvr As String = "smtp.mail.yahoo.com"


        msgEmail = "Hola " + lbDuenoNombre.Text.Replace("Nombre del dueño del modelo seleccionado :", "")
        msgEmail += vbCrLf + vbCrLf
        msgEmail += "El siguiente usuario desea tener acceso a su modelo : " + lbModelos.Text
        msgEmail += vbCrLf + vbCrLf
        msgEmail += lbNombre.Text + vbCrLf
        msgEmail += lbTipoUsuario.Text + vbCrLf
        msgEmail += lbEmail.Text + vbCrLf
        msgEmail += lbTel.Text + vbCrLf
        msgEmail += vbCrLf + vbCrLf
        msgEmail += "Favor considere darle permisos a este usuario para que no se cabrée y lo busque y le de por la madre."
        msgEmail += vbCrLf
        msgEmail += "Gracias por su atención!"

        If enviaEmail("Solicitud de permiso para ver su modelo : " + lbModelos.Text, msgEmail, destinatario, remitente, emailUsr, emailPW, emailSvr) Then MsgBox("Email ha sido enviado.")


        


    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            tablaModelos = ModelosTableAdapter.GetDataByNoPermisoAusuarioID(username)
            ModelosBindingSource.DataSource = tablaModelos
            btSolicPermisos.Visible = True
            EditarToolStripMenuItem.Enabled = False

            'aqui solo si es un usuario visor
            If esCreador = 0 Then

                'llena la tablaUsuarioDueno con la info del dueno
                tablaUsuarioDueno = UsuariosTableAdapter.GetdatosDuenoModeloNombre(lbModelos.SelectedValue)

                'llena los labees informativos del dueno
                lbDuenoNombre.Text = "Nombre del dueño del modelo seleccionado : " + tablaUsuarioDueno.Rows(0).Item("nombre").ToString
                lbDuenoEmail.Text = "E-mail : " + tablaUsuarioDueno.Rows(0).Item("email").ToString
                lbDuenoTel.Text = "Teléfono : " + tablaUsuarioDueno.Rows(0).Item("telefono").ToString
                lbDuenoUsuario.Text = "Nombre de usuario : " + tablaUsuarioDueno.Rows(0).Item("userid").ToString
            End If


        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked Then
            'llena el tablaModelos que tiene permiso ver el userId logeado
            If username = "" Then Exit Sub
            tablaModelos = ModelosTableAdapter.GetDataByPermisoAusuarioID(username)
            ModelosBindingSource.DataSource = tablaModelos
            btSolicPermisos.Visible = False
            EditarToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Function enviaEmail(ByVal tema As String, ByVal cuerpoMsg As String, ByVal destino As String, ByVal emailDe As String, ByVal usuarioEmail As String, ByVal usuarioPw As String, ByVal servidorEmail As String) As Boolean


        Dim mail As New MailMessage


        mail.To = destino
        mail.From = emailDe
        mail.Subject = tema
        mail.Body = cuerpoMsg


        mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
        mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", usuarioEmail)
        mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", usuarioPw)

        SmtpMail.SmtpServer = servidorEmail

        Try
            SmtpMail.Send(mail)
        Catch ex As Exception
            MsgBox("Error enviando email. MSG ERR: " + ex.Message)
            Return False
        End Try

        Return True

    End Function

    Private Sub VerimprimirReporteDeBitácorasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerimprimirReporteDeBitácorasToolStripMenuItem.Click



        If esCreador = 0 Then
            MsgBox("Su cuenta no tiene permisos para generar reportes y/o estadísticas.")
            Exit Sub
        End If

        reporte.ShowDialog()


    End Sub
End Class
