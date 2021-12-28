<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pacientes
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.Enviar = New System.Windows.Forms.Button()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.SYSCLIN.My.Resources.Resources.cancel_29373
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(448, 570)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(75, 29)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(266, 20)
        Me.txtbuscar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar"
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.Transparent
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.Black
        Me.button5.Location = New System.Drawing.Point(-2, -2)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(25, 25)
        Me.button5.TabIndex = 7
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = False
        '
        'Enviar
        '
        Me.Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enviar.ForeColor = System.Drawing.Color.Black
        Me.Enviar.Image = Global.SYSCLIN.My.Resources.Resources._1486564411_checkmark_81522
        Me.Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Enviar.Location = New System.Drawing.Point(175, 570)
        Me.Enviar.Name = "Enviar"
        Me.Enviar.Size = New System.Drawing.Size(91, 38)
        Me.Enviar.TabIndex = 5
        Me.Enviar.Text = "Aceptar"
        Me.Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Enviar.UseVisualStyleBackColor = True
        '
        'Tabla
        '
        Me.Tabla.AllowUserToAddRows = False
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(12, 69)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(748, 471)
        Me.Tabla.TabIndex = 4
        '
        'Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(772, 613)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Enviar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Enviar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents button5 As Button
    Friend WithEvents Tabla As DataGridView
End Class
