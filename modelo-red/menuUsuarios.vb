Public Class menuUsuarios


    Dim userIDsel As Integer = -1

    'variables usadas en la buskeda rapida
    Dim cabusIdx As Integer
    Dim colsel As Integer
    Dim cancelar As Boolean = True
    Dim cabus As String

    Private Sub btCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCerrar.Click


        MsgBox("Gracias por utilizar nuestro software! Saliendo de la aplicación.")
        End


    End Sub

    Private Sub menuUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        refresca()
        
    End Sub
    Private Sub refresca()

        'Me.UsuariosTableAdapter.Fill(Me._modelo_redDataSet.usuarios)

        DataGridView1.DataSource = UsuariosTableAdapter.GetNoBorrados



    End Sub
    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click




        If tNom.Text = "" Or tbUserId.Text = "" Then
            MsgBox("El nombre y/o teléfono no puede quedar en blanco.")
            Exit Sub
        End If

        If tbPassword.Text <> tbPWconf.Text Then
            MsgBox("El password no es el mismo en el casilla de confirmaci;oin")
            Exit Sub
        End If


        Dim tipoUsr As Integer
        'tipo de usuario tipoUsr true si es creador sino false
        If RadioButton1.Checked Then tipoUsr = 1
        If RadioButton2.Checked Then tipoUsr = 0

        If btSalvar.Text = "Agregar" Then
            'verificar si el usuario a agregar existe
            If UsuariosTableAdapter.existeUsuario(tbUserId.Text) > 0 Then
                MsgBox("El usuario : " + tbUserId.Text + " ya existe. Seleccione uno diferente.")
                Exit Sub
            End If

            UsuariosTableAdapter.Insert(tNom.Text, tbUserId.Text, tbPassword.Text, tbEmail.Text, tbTel.Text, tipoUsr, 0)
            MsgBox("Usuario ha sido metido y todo salió tuanis!")
            tNom.Text = ""
            tbEmail.Text = ""
            tbTel.Text = ""
            tbUserId.Text = ""
            tbPassword.Text = ""
            tbPWconf.Text = ""
        End If

        If btSalvar.Text = "Modificar" Then
            'mete nueva infom modificada en el userID guardado de donde le dio click en el datagridview userIDsel
            UsuariosTableAdapter.actualizar(tNom.Text, tbUserId.Text, tbPassword.Text, tbEmail.Text, tbTel.Text, tipoUsr, userIDsel)
            btAgregar.Visible = False
            btSalvar.Text = "Agregar"
            MsgBox("Cliente modificado con éxito!")
            tNom.Text = ""
            tbEmail.Text = ""
            tbTel.Text = ""
            tbUserId.Text = ""
            tbPassword.Text = ""
            tbPWconf.Text = ""
        End If

        refresca()

    End Sub

    Private Sub btAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAgregar.Click


        tNom.Visible = True
        tbEmail.Visible = True
        tbTel.Visible = True
        tbUserId.Visible = True
        tbPassword.Visible = True
        gbTipoUsuario.Visible = True

        tNom.Text = ""
        tbEmail.Text = ""
        tbTel.Text = ""
        tbUserId.Text = ""
        tbPassword.Text = ""
        tbPWconf.Text = ""

        btSalvar.Visible = True
        btAgregar.Visible = False
        btSalvar.Text = "Agregar"


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        'byuscador
        colsel = DataGridView1.CurrentCell.ColumnIndex
        cabus = ""

        lbStatus.Text = "Digite lo que desea buscar en la columna : " + DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).HeaderText
        'end byuscador


        userIDsel = DataGridView1.CurrentRow.Cells(1).Value

        tNom.Text = DataGridView1.CurrentRow.Cells(2).Value
        tbEmail.Text = DataGridView1.CurrentRow.Cells(5).Value
        tbTel.Text = DataGridView1.CurrentRow.Cells(6).Value
        tbUserId.Text = DataGridView1.CurrentRow.Cells(3).Value
        tbPassword.Text = DataGridView1.CurrentRow.Cells(4).Value
        tbPWconf.Text = tbPassword.Text

        If DataGridView1.CurrentRow.Cells(7).Value = 1 Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        End If

        If DataGridView1.CurrentRow.Cells(7).Value = 0 Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If

        btSalvar.Text = "Modificar"
        btSalvar.Visible = True
        btAgregar.Visible = True



    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If userIDsel = -1 Then
            MsgBox("Primero debe seleccionar un usuario de la lista a borrar.")
            Exit Sub
        End If

        Dim resp As Integer = MsgBox("Está seguro que desea borrar el usuario " + tNom.Text + "(" + userIDsel.ToString + ") ?", MsgBoxStyle.YesNo, "Borrar usuario")

        If resp = 7 Then
            MsgBox("Operación cancelada.")
            Exit Sub
        End If
        
        UsuariosTableAdapter.borrar(userIDsel)
        MsgBox("Cliente ha sido borrado!")

        tNom.Text = ""
        tbEmail.Text = ""
        tbTel.Text = ""
        tbUserId.Text = ""
        tbPassword.Text = ""
        userIDsel = -1

        refresca()

    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown




        Timer1.Enabled = False

        'buskeda rapida
        If e.KeyCode = 27 Then
            tbSearch.Visible = False
            cabus = ""
            Exit Sub
        End If


        If e.KeyCode = 8 Then
            If cabus = "" Then Exit Sub
            cabus = Strings.Left(cabus, Len(cabus) - 1)
            GoTo naca
        End If

        cabus = cabus + Chr(e.KeyCode)

naca:

        tbSearch.Visible = True
        'MsgBox(DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).ToString)


        tbSearch.Focus()
        tbSearch.Text = "Buscar : " + cabus


        For i = 1 To DataGridView1.RowCount
            'MsgBox(Strings.Left(DataGridView1.Rows(i).Cells(DataGridView1.CurrentCell.ColumnIndex).Value, Strings.Len(cabus)))
            'MsgBox (cabus)

            'este segmento es cuando termina de buscar
            If i >= DataGridView1.RowCount Then
                'With DataGridView1
                '    .SelectedRows = .RowSel
                '    '.Col = 1
                '    .ColSel = .Cols - 1
                '    .HighLight = flexHighlightNever
                'End With

                tbSearch.Text = "No se encontró : " + cabus
                Timer1.Enabled = True
                DataGridView1.Focus()
                Exit Sub
            End If

            If LCase(Strings.Left(DataGridView1.Rows(i).Cells(DataGridView1.CurrentCell.ColumnIndex).Value, Strings.Len(cabus))) = LCase(cabus) Then
                DataGridView1.Rows(i).Selected = True
                DataGridView1.Focus()
                cabusIdx = i
                Timer1.Enabled = True
                'mueve el tbsearch
                Dim posX As Integer = DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).X + DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).Width + 25
                Dim posY As Integer = DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).Y + DataGridView1.Top

                If posX = DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).Width + 25 And posY = DataGridView1.Top Then
                    DataGridView1.FirstDisplayedScrollingRowIndex = i
                    posX = DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).X + DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).Width + 25
                    posY = DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).Y + DataGridView1.Top
                End If

                If posX + tbSearch.Width >= Me.Width Then
                    posX = DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).X
                    posY = DataGridView1.GetCellDisplayRectangle(colsel, cabusIdx, True).Y + DataGridView1.Top + 50
                End If

                tbSearch.SetBounds(posX, posY, tbSearch.Width, tbSearch.Height)

                Exit Sub
            End If
        Next i




    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        tbSearch.Visible = False
        lbStatus.Text = "Hecho."
        Timer1.Enabled = False


    End Sub
End Class