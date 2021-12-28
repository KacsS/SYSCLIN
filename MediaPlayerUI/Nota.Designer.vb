<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nota
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtnota = New System.Windows.Forms.RichTextBox()
        Me.txtnombrep = New System.Windows.Forms.TextBox()
        Me.txthistoriap = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtnota)
        Me.GroupBox1.Controls.Add(Me.txtnombrep)
        Me.GroupBox1.Controls.Add(Me.txthistoriap)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 552)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nota"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SYSCLIN.My.Resources.Resources.Save_37110__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(654, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 41)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtnota
        '
        Me.txtnota.Location = New System.Drawing.Point(16, 78)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(727, 399)
        Me.txtnota.TabIndex = 48
        Me.txtnota.Text = ""
        '
        'txtnombrep
        '
        Me.txtnombrep.Location = New System.Drawing.Point(224, 19)
        Me.txtnombrep.Name = "txtnombrep"
        Me.txtnombrep.Size = New System.Drawing.Size(297, 20)
        Me.txtnombrep.TabIndex = 47
        '
        'txthistoriap
        '
        Me.txthistoriap.Location = New System.Drawing.Point(122, 19)
        Me.txthistoriap.Name = "txthistoriap"
        Me.txthistoriap.Size = New System.Drawing.Size(96, 20)
        Me.txthistoriap.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Numero de Historia"
        '
        'Nota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(915, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Nota"
        Me.Text = "Nota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtnota As RichTextBox
    Friend WithEvents txtnombrep As TextBox
    Friend WithEvents txthistoriap As TextBox
    Friend WithEvents Label2 As Label
End Class
