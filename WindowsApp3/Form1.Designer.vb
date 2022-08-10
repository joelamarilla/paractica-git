<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btbcerrar1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btbcerrar2 = New System.Windows.Forms.Button()
        Me.txtcerrar1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btbcerrar1
        '
        Me.btbcerrar1.Location = New System.Drawing.Point(96, 171)
        Me.btbcerrar1.Name = "btbcerrar1"
        Me.btbcerrar1.Size = New System.Drawing.Size(75, 23)
        Me.btbcerrar1.TabIndex = 0
        Me.btbcerrar1.Text = "cerrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btbcerrar1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "cerrar los 2 formularios " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y salir de la aplicacion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btbcerrar2
        '
        Me.btbcerrar2.Location = New System.Drawing.Point(96, 333)
        Me.btbcerrar2.Name = "btbcerrar2"
        Me.btbcerrar2.Size = New System.Drawing.Size(75, 23)
        Me.btbcerrar2.TabIndex = 2
        Me.btbcerrar2.Text = "cerraar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btbcerrar2.UseVisualStyleBackColor = True
        '
        'txtcerrar1
        '
        Me.txtcerrar1.AutoSize = True
        Me.txtcerrar1.Location = New System.Drawing.Point(93, 255)
        Me.txtcerrar1.Name = "txtcerrar1"
        Me.txtcerrar1.Size = New System.Drawing.Size(88, 26)
        Me.txtcerrar1.TabIndex = 3
        Me.txtcerrar1.Text = "cerrar solamente " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "este formulario " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 450)
        Me.Controls.Add(Me.txtcerrar1)
        Me.Controls.Add(Me.btbcerrar2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btbcerrar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btbcerrar1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btbcerrar2 As Button
    Friend WithEvents txtcerrar1 As Label
End Class
