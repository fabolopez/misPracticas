<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2dividir
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
        Me.textBoxn1 = New System.Windows.Forms.TextBox()
        Me.textBoxn2 = New System.Windows.Forms.TextBox()
        Me.labelDivision = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.labelResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduzca los números a dividir:"
        '
        'textBoxn1
        '
        Me.textBoxn1.Location = New System.Drawing.Point(48, 86)
        Me.textBoxn1.Name = "textBoxn1"
        Me.textBoxn1.Size = New System.Drawing.Size(100, 20)
        Me.textBoxn1.TabIndex = 1
        '
        'textBoxn2
        '
        Me.textBoxn2.Location = New System.Drawing.Point(202, 86)
        Me.textBoxn2.Name = "textBoxn2"
        Me.textBoxn2.Size = New System.Drawing.Size(100, 20)
        Me.textBoxn2.TabIndex = 2
        '
        'labelDivision
        '
        Me.labelDivision.AutoSize = True
        Me.labelDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDivision.Location = New System.Drawing.Point(164, 82)
        Me.labelDivision.Name = "labelDivision"
        Me.labelDivision.Size = New System.Drawing.Size(27, 29)
        Me.labelDivision.TabIndex = 3
        Me.labelDivision.Text = "÷"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(48, 186)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 29)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'labelResultado
        '
        Me.labelResultado.AutoSize = True
        Me.labelResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelResultado.ForeColor = System.Drawing.Color.Green
        Me.labelResultado.Location = New System.Drawing.Point(330, 82)
        Me.labelResultado.Name = "labelResultado"
        Me.labelResultado.Size = New System.Drawing.Size(87, 24)
        Me.labelResultado.TabIndex = 5
        Me.labelResultado.Text = "resultado"
        '
        'form2dividir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 236)
        Me.Controls.Add(Me.labelResultado)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.labelDivision)
        Me.Controls.Add(Me.textBoxn2)
        Me.Controls.Add(Me.textBoxn1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form2dividir"
        Me.Text = "form2dividir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxn1 As TextBox
    Friend WithEvents textBoxn2 As TextBox
    Friend WithEvents labelDivision As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents labelResultado As Label
End Class
