<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btbcerrar4 = New System.Windows.Forms.Button()
        Me.txtcerrar4 = New System.Windows.Forms.Label()
        Me.txtcerrar3 = New System.Windows.Forms.Label()
        Me.btbcerrar3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btbcerrar4
        '
        Me.btbcerrar4.Location = New System.Drawing.Point(143, 311)
        Me.btbcerrar4.Name = "btbcerrar4"
        Me.btbcerrar4.Size = New System.Drawing.Size(82, 33)
        Me.btbcerrar4.TabIndex = 7
        Me.btbcerrar4.Text = "cerrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btbcerrar4.UseVisualStyleBackColor = True
        '
        'txtcerrar4
        '
        Me.txtcerrar4.AutoSize = True
        Me.txtcerrar4.Location = New System.Drawing.Point(140, 250)
        Me.txtcerrar4.Name = "txtcerrar4"
        Me.txtcerrar4.Size = New System.Drawing.Size(85, 26)
        Me.txtcerrar4.TabIndex = 6
        Me.txtcerrar4.Text = "cerrar solamente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "este formulario " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtcerrar3
        '
        Me.txtcerrar3.AutoSize = True
        Me.txtcerrar3.Location = New System.Drawing.Point(130, 106)
        Me.txtcerrar3.Name = "txtcerrar3"
        Me.txtcerrar3.Size = New System.Drawing.Size(115, 26)
        Me.txtcerrar3.TabIndex = 5
        Me.txtcerrar3.Text = "cerrar los 2 formularios " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y salir de la aplicacion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btbcerrar3
        '
        Me.btbcerrar3.Location = New System.Drawing.Point(143, 161)
        Me.btbcerrar3.Name = "btbcerrar3"
        Me.btbcerrar3.Size = New System.Drawing.Size(82, 33)
        Me.btbcerrar3.TabIndex = 4
        Me.btbcerrar3.Text = "cerrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btbcerrar3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 450)
        Me.Controls.Add(Me.btbcerrar4)
        Me.Controls.Add(Me.txtcerrar4)
        Me.Controls.Add(Me.txtcerrar3)
        Me.Controls.Add(Me.btbcerrar3)
        Me.Name = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btbcerrar4 As Button
    Friend WithEvents txtcerrar4 As Label
    Friend WithEvents txtcerrar3 As Label
    Friend WithEvents btbcerrar3 As Button
End Class
