<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crearNuevoModelo
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbUsuarioDueno = New System.Windows.Forms.Label
        Me.tbDescripModelo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbNombreModelo = New System.Windows.Forms.TextBox
        Me.btCerrar = New System.Windows.Forms.Button
        Me.ModelosTableAdapter = New modelo_red._modelo_redDataSetTableAdapters.modelosTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del modelo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbUsuarioDueno)
        Me.GroupBox1.Controls.Add(Me.tbDescripModelo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbNombreModelo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 335)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del modelo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Guardar información del modelo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbUsuarioDueno
        '
        Me.lbUsuarioDueno.AutoSize = True
        Me.lbUsuarioDueno.Location = New System.Drawing.Point(6, 26)
        Me.lbUsuarioDueno.Name = "lbUsuarioDueno"
        Me.lbUsuarioDueno.Size = New System.Drawing.Size(76, 13)
        Me.lbUsuarioDueno.TabIndex = 8
        Me.lbUsuarioDueno.Text = "Usuario dueno"
        '
        'tbDescripModelo
        '
        Me.tbDescripModelo.Location = New System.Drawing.Point(6, 118)
        Me.tbDescripModelo.Multiline = True
        Me.tbDescripModelo.Name = "tbDescripModelo"
        Me.tbDescripModelo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbDescripModelo.Size = New System.Drawing.Size(804, 170)
        Me.tbDescripModelo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción del modelo"
        '
        'tbNombreModelo
        '
        Me.tbNombreModelo.Location = New System.Drawing.Point(103, 62)
        Me.tbNombreModelo.Name = "tbNombreModelo"
        Me.tbNombreModelo.Size = New System.Drawing.Size(707, 20)
        Me.tbNombreModelo.TabIndex = 1
        '
        'btCerrar
        '
        Me.btCerrar.Location = New System.Drawing.Point(714, 355)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(114, 36)
        Me.btCerrar.TabIndex = 2
        Me.btCerrar.Text = "Cerrar"
        Me.btCerrar.UseVisualStyleBackColor = True
        '
        'ModelosTableAdapter
        '
        Me.ModelosTableAdapter.ClearBeforeFill = True
        '
        'crearNuevoModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "crearNuevoModelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear/Editar Modelo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNombreModelo As System.Windows.Forms.TextBox
    Friend WithEvents tbDescripModelo As System.Windows.Forms.TextBox
    Friend WithEvents lbUsuarioDueno As System.Windows.Forms.Label
    Friend WithEvents btCerrar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ModelosTableAdapter As modelo_red._modelo_redDataSetTableAdapters.modelosTableAdapter
End Class
