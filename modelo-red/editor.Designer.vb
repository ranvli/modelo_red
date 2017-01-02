<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editor
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbDelConectiva = New System.Windows.Forms.Label
        Me.lbQnodo = New System.Windows.Forms.Label
        Me.btBorrarTodo = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbCconect = New System.Windows.Forms.Label
        Me.lbCnodo = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btEncAp = New System.Windows.Forms.Button
        Me.lbEncendido = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbPrinc = New System.Windows.Forms.Label
        Me.tbNomNodo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbNodoSel = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.tbRetraso = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbDistCam = New System.Windows.Forms.TextBox
        Me.tbMsg = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirDelEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me._modelo_redDataSet = New modelo_red._modelo_redDataSet
        Me.NodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NodosTableAdapter = New modelo_red._modelo_redDataSetTableAdapters.nodosTableAdapter
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogTableAdapter = New modelo_red._modelo_redDataSetTableAdapters.logTableAdapter
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me._modelo_redDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(135, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 480)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbDelConectiva)
        Me.GroupBox1.Controls.Add(Me.lbQnodo)
        Me.GroupBox1.Controls.Add(Me.btBorrarTodo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbCconect)
        Me.GroupBox1.Controls.Add(Me.lbCnodo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 480)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementos"
        '
        'lbDelConectiva
        '
        Me.lbDelConectiva.AutoSize = True
        Me.lbDelConectiva.BackColor = System.Drawing.Color.Gray
        Me.lbDelConectiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDelConectiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDelConectiva.Location = New System.Drawing.Point(5, 108)
        Me.lbDelConectiva.Name = "lbDelConectiva"
        Me.lbDelConectiva.Size = New System.Drawing.Size(102, 20)
        Me.lbDelConectiva.TabIndex = 11
        Me.lbDelConectiva.Text = "Del Conectiva"
        '
        'lbQnodo
        '
        Me.lbQnodo.AutoSize = True
        Me.lbQnodo.BackColor = System.Drawing.Color.Gray
        Me.lbQnodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQnodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQnodo.Location = New System.Drawing.Point(5, 55)
        Me.lbQnodo.Name = "lbQnodo"
        Me.lbQnodo.Size = New System.Drawing.Size(102, 20)
        Me.lbQnodo.TabIndex = 10
        Me.lbQnodo.Text = "Borrar nodo   "
        '
        'btBorrarTodo
        '
        Me.btBorrarTodo.Location = New System.Drawing.Point(8, 441)
        Me.btBorrarTodo.Name = "btBorrarTodo"
        Me.btBorrarTodo.Size = New System.Drawing.Size(102, 27)
        Me.btBorrarTodo.TabIndex = 9
        Me.btBorrarTodo.Text = "Limpiar diagrama"
        Me.btBorrarTodo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 12)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Click derecho = accionar"
        '
        'lbCconect
        '
        Me.lbCconect.AutoSize = True
        Me.lbCconect.BackColor = System.Drawing.Color.Gray
        Me.lbCconect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCconect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCconect.Location = New System.Drawing.Point(5, 88)
        Me.lbCconect.Name = "lbCconect"
        Me.lbCconect.Size = New System.Drawing.Size(102, 20)
        Me.lbCconect.TabIndex = 1
        Me.lbCconect.Text = "Set Conectiva"
        '
        'lbCnodo
        '
        Me.lbCnodo.AutoSize = True
        Me.lbCnodo.BackColor = System.Drawing.Color.Salmon
        Me.lbCnodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCnodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCnodo.Location = New System.Drawing.Point(5, 35)
        Me.lbCnodo.Name = "lbCnodo"
        Me.lbCnodo.Size = New System.Drawing.Size(101, 20)
        Me.lbCnodo.TabIndex = 0
        Me.lbCnodo.Text = "Colocar nodo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btEncAp)
        Me.GroupBox2.Controls.Add(Me.lbEncendido)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lbPrinc)
        Me.GroupBox2.Controls.Add(Me.tbNomNodo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbNodoSel)
        Me.GroupBox2.Location = New System.Drawing.Point(779, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 188)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Propiedades del nodo"
        '
        'btEncAp
        '
        Me.btEncAp.Location = New System.Drawing.Point(7, 157)
        Me.btEncAp.Name = "btEncAp"
        Me.btEncAp.Size = New System.Drawing.Size(154, 20)
        Me.btEncAp.TabIndex = 6
        Me.btEncAp.Text = "EncenderApagar"
        Me.btEncAp.UseVisualStyleBackColor = True
        '
        'lbEncendido
        '
        Me.lbEncendido.AutoSize = True
        Me.lbEncendido.Location = New System.Drawing.Point(3, 62)
        Me.lbEncendido.Name = "lbEncendido"
        Me.lbEncendido.Size = New System.Drawing.Size(58, 13)
        Me.lbEncendido.TabIndex = 5
        Me.lbEncendido.Text = "Encendido"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Setear a nodo principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbPrinc
        '
        Me.lbPrinc.AutoSize = True
        Me.lbPrinc.Location = New System.Drawing.Point(3, 35)
        Me.lbPrinc.Name = "lbPrinc"
        Me.lbPrinc.Size = New System.Drawing.Size(61, 13)
        Me.lbPrinc.TabIndex = 3
        Me.lbPrinc.Text = "Es principal"
        '
        'tbNomNodo
        '
        Me.tbNomNodo.Location = New System.Drawing.Point(6, 104)
        Me.tbNomNodo.Name = "tbNomNodo"
        Me.tbNomNodo.Size = New System.Drawing.Size(155, 20)
        Me.tbNomNodo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del nodo"
        '
        'lbNodoSel
        '
        Me.lbNodoSel.AutoSize = True
        Me.lbNodoSel.Location = New System.Drawing.Point(2, 16)
        Me.lbNodoSel.Name = "lbNodoSel"
        Me.lbNodoSel.Size = New System.Drawing.Size(99, 13)
        Me.lbNodoSel.TabIndex = 0
        Me.lbNodoSel.Text = "Nodo seleccionado"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 606)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(940, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Color del nodo principal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(781, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 139)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Colores  (click para cambiar)"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SkyBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Color del fondo del editor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(4, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Color del texto"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.YellowGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(5, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Color nodo principal seleccionado"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Color nodo seleccionado"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Iniciar simulación"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbRetraso
        '
        Me.tbRetraso.Location = New System.Drawing.Point(101, 13)
        Me.tbRetraso.Name = "tbRetraso"
        Me.tbRetraso.Size = New System.Drawing.Size(54, 20)
        Me.tbRetraso.TabIndex = 9
        Me.tbRetraso.Text = "10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Retraso animación"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.tbDistCam)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.tbRetraso)
        Me.GroupBox4.Location = New System.Drawing.Point(784, 365)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(161, 142)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Simulación"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Yellow
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(7, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Color camino"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Distancia camino"
        '
        'tbDistCam
        '
        Me.tbDistCam.Location = New System.Drawing.Point(101, 38)
        Me.tbDistCam.Name = "tbDistCam"
        Me.tbDistCam.Size = New System.Drawing.Size(54, 20)
        Me.tbDistCam.TabIndex = 11
        Me.tbDistCam.Text = "5"
        '
        'tbMsg
        '
        Me.tbMsg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbMsg.Location = New System.Drawing.Point(0, 538)
        Me.tbMsg.Multiline = True
        Me.tbMsg.Name = "tbMsg"
        Me.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbMsg.Size = New System.Drawing.Size(940, 68)
        Me.tbMsg.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-2, 523)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 12)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Bitácora"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(940, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarCambiosToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirDelEditorToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar cambios"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 6)
        '
        'SalirDelEditorToolStripMenuItem
        '
        Me.SalirDelEditorToolStripMenuItem.Name = "SalirDelEditorToolStripMenuItem"
        Me.SalirDelEditorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SalirDelEditorToolStripMenuItem.Text = "Salir del editor"
        '
        '_modelo_redDataSet
        '
        Me._modelo_redDataSet.DataSetName = "_modelo_redDataSet"
        Me._modelo_redDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NodosBindingSource
        '
        Me.NodosBindingSource.DataMember = "nodos"
        Me.NodosBindingSource.DataSource = Me._modelo_redDataSet
        '
        'NodosTableAdapter
        '
        Me.NodosTableAdapter.ClearBeforeFill = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'LogBindingSource
        '
        Me.LogBindingSource.DataMember = "log"
        Me.LogBindingSource.DataSource = Me._modelo_redDataSet
        '
        'LogTableAdapter
        '
        Me.LogTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(838, 512)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 20)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(875, 512)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(31, 20)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(794, 517)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 12)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Tamaño"
        '
        'editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbMsg)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor de la vara"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me._modelo_redDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCnodo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbNodoSel As System.Windows.Forms.Label
    Friend WithEvents tbNomNodo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbCconect As System.Windows.Forms.Label
    Friend WithEvents lbPrinc As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbEncendido As System.Windows.Forms.Label
    Friend WithEvents btEncAp As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbRetraso As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbDistCam As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btBorrarTodo As System.Windows.Forms.Button
    Friend WithEvents lbDelConectiva As System.Windows.Forms.Label
    Friend WithEvents lbQnodo As System.Windows.Forms.Label
    Friend WithEvents tbMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents _modelo_redDataSet As modelo_red._modelo_redDataSet
    Friend WithEvents NodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NodosTableAdapter As modelo_red._modelo_redDataSetTableAdapters.nodosTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirDelEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogTableAdapter As modelo_red._modelo_redDataSetTableAdapters.logTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
