<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formIngreso
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBoxNombre = New System.Windows.Forms.TextBox()
        Me.textBoxClave = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelClave = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa HOMEl"
        '
        'textBoxNombre
        '
        Me.textBoxNombre.Location = New System.Drawing.Point(156, 76)
        Me.textBoxNombre.Name = "textBoxNombre"
        Me.textBoxNombre.Size = New System.Drawing.Size(169, 20)
        Me.textBoxNombre.TabIndex = 1
        '
        'textBoxClave
        '
        Me.textBoxClave.Location = New System.Drawing.Point(156, 140)
        Me.textBoxClave.Name = "textBoxClave"
        Me.textBoxClave.Size = New System.Drawing.Size(169, 20)
        Me.textBoxClave.TabIndex = 2
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.labelNombre.Location = New System.Drawing.Point(60, 72)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(84, 24)
        Me.labelNombre.TabIndex = 3
        Me.labelNombre.Text = "Nombre:"
        '
        'labelClave
        '
        Me.labelClave.AutoSize = True
        Me.labelClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.labelClave.Location = New System.Drawing.Point(68, 136)
        Me.labelClave.Name = "labelClave"
        Me.labelClave.Size = New System.Drawing.Size(62, 24)
        Me.labelClave.TabIndex = 4
        Me.labelClave.Text = "Clave:"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(72, 213)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(88, 32)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(388, 213)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 32)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'formIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 257)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.labelClave)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.textBoxClave)
        Me.Controls.Add(Me.textBoxNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formIngreso"
        Me.Text = "Ingreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxNombre As TextBox
    Friend WithEvents textBoxClave As TextBox
    Friend WithEvents labelNombre As Label
    Friend WithEvents labelClave As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
End Class
