<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuModelos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lbNombre = New System.Windows.Forms.Label
        Me.lbEmail = New System.Windows.Forms.Label
        Me.lbTipoUsuario = New System.Windows.Forms.Label
        Me.lbTel = New System.Windows.Forms.Label
        Me.lbModelos = New System.Windows.Forms.ListBox
        Me.ModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._modelo_redDataSet = New modelo_red._modelo_redDataSet
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbDescripModelo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.bDesasignar = New System.Windows.Forms.Button
        Me.bAgregar = New System.Windows.Forms.Button
        Me.gbUsuariosConPermisos = New System.Windows.Forms.GroupBox
        Me.dgvPermisosLectura = New System.Windows.Forms.DataGridView
        Me.gbUsuariosSinPermisos = New System.Windows.Forms.GroupBox
        Me.dgvTodosUsuarios = New System.Windows.Forms.DataGridView
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelosTableAdapter = New modelo_red._modelo_redDataSetTableAdapters.modelosTableAdapter
        Me.UsuariosTableAdapter = New modelo_red._modelo_redDataSetTableAdapters.usuariosTableAdapter
        Me.Permisos_lecturaTableAdapter = New modelo_red._modelo_redDataSetTableAdapters.permisos_lecturaTableAdapter
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CrearNuevoModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrarModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gbInfo = New System.Windows.Forms.GroupBox
        Me.lbDuenoUsuario = New System.Windows.Forms.Label
        Me.lbDuenoTel = New System.Windows.Forms.Label
        Me.lbDuenoEmail = New System.Windows.Forms.Label
        Me.lbDuenoNombre = New System.Windows.Forms.Label
        Me.btSolicPermisos = New System.Windows.Forms.Button
        Me.gbModMostrar = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.VerimprimirReporteDeBitácorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._modelo_redDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUsuariosConPermisos.SuspendLayout()
        CType(Me.dgvPermisosLectura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUsuariosSinPermisos.SuspendLayout()
        CType(Me.dgvTodosUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.gbModMostrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 41)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(176, 13)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "Nombre del dueño de los modelos : "
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(591, 41)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(42, 13)
        Me.lbEmail.TabIndex = 1
        Me.lbEmail.Text = "E-Mail :"
        '
        'lbTipoUsuario
        '
        Me.lbTipoUsuario.AutoSize = True
        Me.lbTipoUsuario.Location = New System.Drawing.Point(12, 58)
        Me.lbTipoUsuario.Name = "lbTipoUsuario"
        Me.lbTipoUsuario.Size = New System.Drawing.Size(86, 13)
        Me.lbTipoUsuario.TabIndex = 3
        Me.lbTipoUsuario.Text = "Tipo de usuario :"
        '
        'lbTel
        '
        Me.lbTel.AutoSize = True
        Me.lbTel.Location = New System.Drawing.Point(591, 58)
        Me.lbTel.Name = "lbTel"
        Me.lbTel.Size = New System.Drawing.Size(58, 13)
        Me.lbTel.TabIndex = 2
        Me.lbTel.Text = "Teléfono : "
        '
        'lbModelos
        '
        Me.lbModelos.DataSource = Me.ModelosBindingSource
        Me.lbModelos.DisplayMember = "nombre"
        Me.lbModelos.FormattingEnabled = True
        Me.lbModelos.Location = New System.Drawing.Point(12, 96)
        Me.lbModelos.Name = "lbModelos"
        Me.lbModelos.Size = New System.Drawing.Size(790, 95)
        Me.lbModelos.TabIndex = 4
        Me.lbModelos.ValueMember = "id"
        '
        'ModelosBindingSource
        '
        Me.ModelosBindingSource.DataMember = "modelos"
        Me.ModelosBindingSource.DataSource = Me._modelo_redDataSet
        '
        '_modelo_redDataSet
        '
        Me._modelo_redDataSet.DataSetName = "_modelo_redDataSet"
        Me._modelo_redDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Modelos guardados"
        '
        'tbDescripModelo
        '
        Me.tbDescripModelo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModelosBindingSource, "descripcion", True))
        Me.tbDescripModelo.Location = New System.Drawing.Point(12, 244)
        Me.tbDescripModelo.Multiline = True
        Me.tbDescripModelo.Name = "tbDescripModelo"
        Me.tbDescripModelo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbDescripModelo.Size = New System.Drawing.Size(790, 151)
        Me.tbDescripModelo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Descripción del modelo"
        '
        'bDesasignar
        '
        Me.bDesasignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDesasignar.Location = New System.Drawing.Point(383, 456)
        Me.bDesasignar.Name = "bDesasignar"
        Me.bDesasignar.Size = New System.Drawing.Size(75, 23)
        Me.bDesasignar.TabIndex = 13
        Me.bDesasignar.Text = "<---"
        Me.bDesasignar.UseVisualStyleBackColor = True
        '
        'bAgregar
        '
        Me.bAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAgregar.Location = New System.Drawing.Point(383, 497)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(75, 23)
        Me.bAgregar.TabIndex = 12
        Me.bAgregar.Text = "--->"
        Me.bAgregar.UseVisualStyleBackColor = True
        '
        'gbUsuariosConPermisos
        '
        Me.gbUsuariosConPermisos.Controls.Add(Me.dgvPermisosLectura)
        Me.gbUsuariosConPermisos.Location = New System.Drawing.Point(464, 401)
        Me.gbUsuariosConPermisos.Name = "gbUsuariosConPermisos"
        Me.gbUsuariosConPermisos.Size = New System.Drawing.Size(341, 173)
        Me.gbUsuariosConPermisos.TabIndex = 11
        Me.gbUsuariosConPermisos.TabStop = False
        Me.gbUsuariosConPermisos.Text = "Usuarios con permisos"
        '
        'dgvPermisosLectura
        '
        Me.dgvPermisosLectura.AllowUserToAddRows = False
        Me.dgvPermisosLectura.AllowUserToDeleteRows = False
        Me.dgvPermisosLectura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvPermisosLectura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPermisosLectura.Location = New System.Drawing.Point(15, 28)
        Me.dgvPermisosLectura.Name = "dgvPermisosLectura"
        Me.dgvPermisosLectura.ReadOnly = True
        Me.dgvPermisosLectura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPermisosLectura.Size = New System.Drawing.Size(320, 132)
        Me.dgvPermisosLectura.TabIndex = 0
        '
        'gbUsuariosSinPermisos
        '
        Me.gbUsuariosSinPermisos.Controls.Add(Me.dgvTodosUsuarios)
        Me.gbUsuariosSinPermisos.Location = New System.Drawing.Point(12, 401)
        Me.gbUsuariosSinPermisos.Name = "gbUsuariosSinPermisos"
        Me.gbUsuariosSinPermisos.Size = New System.Drawing.Size(342, 173)
        Me.gbUsuariosSinPermisos.TabIndex = 10
        Me.gbUsuariosSinPermisos.TabStop = False
        Me.gbUsuariosSinPermisos.Text = "Usuarios sin permisos"
        '
        'dgvTodosUsuarios
        '
        Me.dgvTodosUsuarios.AllowUserToAddRows = False
        Me.dgvTodosUsuarios.AllowUserToDeleteRows = False
        Me.dgvTodosUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvTodosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodosUsuarios.Location = New System.Drawing.Point(3, 19)
        Me.dgvTodosUsuarios.Name = "dgvTodosUsuarios"
        Me.dgvTodosUsuarios.ReadOnly = True
        Me.dgvTodosUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodosUsuarios.Size = New System.Drawing.Size(333, 134)
        Me.dgvTodosUsuarios.TabIndex = 0
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me._modelo_redDataSet
        '
        'ModelosTableAdapter
        '
        Me.ModelosTableAdapter.ClearBeforeFill = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'Permisos_lecturaTableAdapter
        '
        Me.Permisos_lecturaTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(817, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevoModeloToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CrearNuevoModeloToolStripMenuItem
        '
        Me.CrearNuevoModeloToolStripMenuItem.Name = "CrearNuevoModeloToolStripMenuItem"
        Me.CrearNuevoModeloToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CrearNuevoModeloToolStripMenuItem.Text = "Crear nuevo modelo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(179, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarModeloToolStripMenuItem, Me.EditarModeloToolStripMenuItem, Me.VerModeloToolStripMenuItem, Me.VerimprimirReporteDeBitácorasToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'BorrarModeloToolStripMenuItem
        '
        Me.BorrarModeloToolStripMenuItem.Name = "BorrarModeloToolStripMenuItem"
        Me.BorrarModeloToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.BorrarModeloToolStripMenuItem.Text = "Borrar modelo"
        '
        'EditarModeloToolStripMenuItem
        '
        Me.EditarModeloToolStripMenuItem.Name = "EditarModeloToolStripMenuItem"
        Me.EditarModeloToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.EditarModeloToolStripMenuItem.Text = "Editar información del modelo"
        '
        'VerModeloToolStripMenuItem
        '
        Me.VerModeloToolStripMenuItem.Name = "VerModeloToolStripMenuItem"
        Me.VerModeloToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.VerModeloToolStripMenuItem.Text = "Ver diagrama del modelo"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.lbDuenoUsuario)
        Me.gbInfo.Controls.Add(Me.lbDuenoTel)
        Me.gbInfo.Controls.Add(Me.lbDuenoEmail)
        Me.gbInfo.Controls.Add(Me.lbDuenoNombre)
        Me.gbInfo.Location = New System.Drawing.Point(15, 401)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(786, 90)
        Me.gbInfo.TabIndex = 15
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Información del creador del modelo"
        '
        'lbDuenoUsuario
        '
        Me.lbDuenoUsuario.AutoSize = True
        Me.lbDuenoUsuario.Location = New System.Drawing.Point(6, 52)
        Me.lbDuenoUsuario.Name = "lbDuenoUsuario"
        Me.lbDuenoUsuario.Size = New System.Drawing.Size(49, 13)
        Me.lbDuenoUsuario.TabIndex = 6
        Me.lbDuenoUsuario.Text = "Usuario :"
        '
        'lbDuenoTel
        '
        Me.lbDuenoTel.AutoSize = True
        Me.lbDuenoTel.Location = New System.Drawing.Point(576, 52)
        Me.lbDuenoTel.Name = "lbDuenoTel"
        Me.lbDuenoTel.Size = New System.Drawing.Size(58, 13)
        Me.lbDuenoTel.TabIndex = 5
        Me.lbDuenoTel.Text = "Teléfono : "
        '
        'lbDuenoEmail
        '
        Me.lbDuenoEmail.AutoSize = True
        Me.lbDuenoEmail.Location = New System.Drawing.Point(576, 26)
        Me.lbDuenoEmail.Name = "lbDuenoEmail"
        Me.lbDuenoEmail.Size = New System.Drawing.Size(42, 13)
        Me.lbDuenoEmail.TabIndex = 4
        Me.lbDuenoEmail.Text = "E-Mail :"
        '
        'lbDuenoNombre
        '
        Me.lbDuenoNombre.AutoSize = True
        Me.lbDuenoNombre.Location = New System.Drawing.Point(6, 26)
        Me.lbDuenoNombre.Name = "lbDuenoNombre"
        Me.lbDuenoNombre.Size = New System.Drawing.Size(176, 13)
        Me.lbDuenoNombre.TabIndex = 3
        Me.lbDuenoNombre.Text = "Nombre del dueño de los modelos : "
        '
        'btSolicPermisos
        '
        Me.btSolicPermisos.Location = New System.Drawing.Point(195, 205)
        Me.btSolicPermisos.Name = "btSolicPermisos"
        Me.btSolicPermisos.Size = New System.Drawing.Size(241, 26)
        Me.btSolicPermisos.TabIndex = 16
        Me.btSolicPermisos.Text = "Solicitar permisos al dueño para ver modelo"
        Me.btSolicPermisos.UseVisualStyleBackColor = True
        Me.btSolicPermisos.Visible = False
        '
        'gbModMostrar
        '
        Me.gbModMostrar.Controls.Add(Me.RadioButton2)
        Me.gbModMostrar.Controls.Add(Me.RadioButton1)
        Me.gbModMostrar.Location = New System.Drawing.Point(442, 195)
        Me.gbModMostrar.Name = "gbModMostrar"
        Me.gbModMostrar.Size = New System.Drawing.Size(357, 43)
        Me.gbModMostrar.TabIndex = 17
        Me.gbModMostrar.TabStop = False
        Me.gbModMostrar.Text = "Modelos a mostrar"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(182, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(153, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Modelos sin permiso de ver"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(158, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Modelos con permiso de ver"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'VerimprimirReporteDeBitácorasToolStripMenuItem
        '
        Me.VerimprimirReporteDeBitácorasToolStripMenuItem.Name = "VerimprimirReporteDeBitácorasToolStripMenuItem"
        Me.VerimprimirReporteDeBitácorasToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.VerimprimirReporteDeBitácorasToolStripMenuItem.Text = "Ver/imprimir reporte de bitácoras"
        '
        'menuModelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbModMostrar)
        Me.Controls.Add(Me.btSolicPermisos)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.bDesasignar)
        Me.Controls.Add(Me.bAgregar)
        Me.Controls.Add(Me.gbUsuariosConPermisos)
        Me.Controls.Add(Me.gbUsuariosSinPermisos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbDescripModelo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbModelos)
        Me.Controls.Add(Me.lbTipoUsuario)
        Me.Controls.Add(Me.lbTel)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuModelos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de modelos"
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._modelo_redDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUsuariosConPermisos.ResumeLayout(False)
        CType(Me.dgvPermisosLectura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUsuariosSinPermisos.ResumeLayout(False)
        CType(Me.dgvTodosUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        Me.gbModMostrar.ResumeLayout(False)
        Me.gbModMostrar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents lbTipoUsuario As System.Windows.Forms.Label
    Friend WithEvents lbTel As System.Windows.Forms.Label
    Friend WithEvents lbModelos As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbDescripModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _modelo_redDataSet As modelo_red._modelo_redDataSet
    Friend WithEvents ModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelosTableAdapter As modelo_red._modelo_redDataSetTableAdapters.modelosTableAdapter
    Friend WithEvents UsuariosTableAdapter As modelo_red._modelo_redDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents bDesasignar As System.Windows.Forms.Button
    Friend WithEvents bAgregar As System.Windows.Forms.Button
    Friend WithEvents gbUsuariosConPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents gbUsuariosSinPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTodosUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvPermisosLectura As System.Windows.Forms.DataGridView
    Friend WithEvents Permisos_lecturaTableAdapter As modelo_red._modelo_redDataSetTableAdapters.permisos_lecturaTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearNuevoModeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lbDuenoUsuario As System.Windows.Forms.Label
    Friend WithEvents lbDuenoTel As System.Windows.Forms.Label
    Friend WithEvents lbDuenoEmail As System.Windows.Forms.Label
    Friend WithEvents lbDuenoNombre As System.Windows.Forms.Label
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarModeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarModeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerModeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btSolicPermisos As System.Windows.Forms.Button
    Friend WithEvents gbModMostrar As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents VerimprimirReporteDeBitácorasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
