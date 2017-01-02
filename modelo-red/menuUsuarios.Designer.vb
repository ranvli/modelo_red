<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbPWconf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbTipoUsuario = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTel = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.tbUserId = New System.Windows.Forms.TextBox()
        Me.btCerrar = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._modelo_redDataSet = New modelo_red._modelo_redDataSet()
        Me.UsuariosTableAdapter = New modelo_red._modelo_redDataSetTableAdapters.usuariosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbTipoUsuario.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._modelo_redDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(695, 290)
        Me.DataGridView1.TabIndex = 63
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "notif"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.tbPWconf)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.gbTipoUsuario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbTel)
        Me.GroupBox1.Controls.Add(Me.tbPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbEmail)
        Me.GroupBox1.Controls.Add(Me.tNom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btAgregar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btSalvar)
        Me.GroupBox1.Controls.Add(Me.tbUserId)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 173)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar/modificar cliente"
        '
        'tbPWconf
        '
        Me.tbPWconf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPWconf.Location = New System.Drawing.Point(99, 146)
        Me.tbPWconf.Name = "tbPWconf"
        Me.tbPWconf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPWconf.Size = New System.Drawing.Size(231, 20)
        Me.tbPWconf.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Password otravez"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Location = New System.Drawing.Point(546, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 19)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Borrar cliente"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gbTipoUsuario
        '
        Me.gbTipoUsuario.BackColor = System.Drawing.SystemColors.Highlight
        Me.gbTipoUsuario.Controls.Add(Me.RadioButton2)
        Me.gbTipoUsuario.Controls.Add(Me.RadioButton1)
        Me.gbTipoUsuario.Location = New System.Drawing.Point(406, 19)
        Me.gbTipoUsuario.Name = "gbTipoUsuario"
        Me.gbTipoUsuario.Size = New System.Drawing.Size(283, 72)
        Me.gbTipoUsuario.TabIndex = 13
        Me.gbTipoUsuario.TabStop = False
        Me.gbTipoUsuario.Text = "Tipo de Usuario"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(232, 17)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.Text = "Visualizador - modifica pero no puede salvar"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Creador - Editor"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Teléfono"
        '
        'tbTel
        '
        Me.tbTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTel.Location = New System.Drawing.Point(99, 70)
        Me.tbTel.Name = "tbTel"
        Me.tbTel.Size = New System.Drawing.Size(231, 20)
        Me.tbTel.TabIndex = 4
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPassword.Location = New System.Drawing.Point(99, 124)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(231, 20)
        Me.tbPassword.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "E-mail"
        '
        'tbEmail
        '
        Me.tbEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbEmail.Location = New System.Drawing.Point(99, 45)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(231, 20)
        Me.tbEmail.TabIndex = 3
        '
        'tNom
        '
        Me.tNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tNom.Location = New System.Drawing.Point(99, 19)
        Me.tNom.Name = "tNom"
        Me.tNom.Size = New System.Drawing.Size(231, 20)
        Me.tNom.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'btAgregar
        '
        Me.btAgregar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btAgregar.Location = New System.Drawing.Point(407, 129)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(133, 32)
        Me.btAgregar.TabIndex = 6
        Me.btAgregar.Text = "Agregar nuevo cliente"
        Me.btAgregar.UseVisualStyleBackColor = False
        Me.btAgregar.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "UserId"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btSalvar.Location = New System.Drawing.Point(546, 129)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(143, 32)
        Me.btSalvar.TabIndex = 10
        Me.btSalvar.Text = "Agregar"
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'tbUserId
        '
        Me.tbUserId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbUserId.Location = New System.Drawing.Point(99, 96)
        Me.tbUserId.Name = "tbUserId"
        Me.tbUserId.Size = New System.Drawing.Size(231, 20)
        Me.tbUserId.TabIndex = 5
        '
        'btCerrar
        '
        Me.btCerrar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btCerrar.Location = New System.Drawing.Point(563, 497)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(139, 33)
        Me.btCerrar.TabIndex = 61
        Me.btCerrar.Text = "Salir"
        Me.btCerrar.UseVisualStyleBackColor = False
        '
        'tbSearch
        '
        Me.tbSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.ForeColor = System.Drawing.Color.Gold
        Me.tbSearch.Location = New System.Drawing.Point(12, 487)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.ReadOnly = True
        Me.tbSearch.Size = New System.Drawing.Size(173, 15)
        Me.tbSearch.TabIndex = 64
        Me.tbSearch.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.BackColor = System.Drawing.Color.DarkKhaki
        Me.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbStatus.Location = New System.Drawing.Point(0, 534)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(10, 13)
        Me.lbStatus.TabIndex = 65
        Me.lbStatus.Text = "."
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me._modelo_redDataSet
        '
        '_modelo_redDataSet
        '
        Me._modelo_redDataSet.DataSetName = "_modelo_redDataSet"
        Me._modelo_redDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'menuUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(714, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btCerrar)
        Me.Name = "menuUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de Usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTipoUsuario.ResumeLayout(False)
        Me.gbTipoUsuario.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._modelo_redDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbTel As System.Windows.Forms.TextBox
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents tNom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents tbUserId As System.Windows.Forms.TextBox
    Friend WithEvents btCerrar As System.Windows.Forms.Button
    Friend WithEvents _modelo_redDataSet As modelo_red._modelo_redDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As modelo_red._modelo_redDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents gbTipoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbPWconf As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbStatus As System.Windows.Forms.Label
End Class
