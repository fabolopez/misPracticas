<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNumero
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
        Me.numeroTexBox = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.btbAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduzca un numero:"
        '
        'numeroTexBox
        '
        Me.numeroTexBox.Location = New System.Drawing.Point(117, 42)
        Me.numeroTexBox.Name = "numeroTexBox"
        Me.numeroTexBox.Size = New System.Drawing.Size(154, 20)
        Me.numeroTexBox.TabIndex = 1
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.Location = New System.Drawing.Point(120, 112)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(137, 18)
        Me.labelNombre.TabIndex = 2
        Me.labelNombre.Text = "Escriba un nombre:"
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Location = New System.Drawing.Point(117, 142)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(154, 20)
        Me.nombreTextBox.TabIndex = 3
        '
        'btbAceptar
        '
        Me.btbAceptar.Location = New System.Drawing.Point(323, 188)
        Me.btbAceptar.Name = "btbAceptar"
        Me.btbAceptar.Size = New System.Drawing.Size(79, 23)
        Me.btbAceptar.TabIndex = 4
        Me.btbAceptar.Text = "Aceptar"
        Me.btbAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 188)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(37, 27)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'formNumero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 223)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btbAceptar)
        Me.Controls.Add(Me.nombreTextBox)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.numeroTexBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formNumero"
        Me.Text = "Gana un premio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numeroTexBox As TextBox
    Friend WithEvents labelNombre As Label
    Friend WithEvents nombreTextBox As TextBox
    Friend WithEvents btbAceptar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
