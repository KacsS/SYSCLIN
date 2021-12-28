<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_vacuna
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
        Me.txthistoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.filtro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdosis = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlote = New System.Windows.Forms.TextBox()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Historia"
        '
        'txthistoria
        '
        Me.txthistoria.Enabled = False
        Me.txthistoria.Location = New System.Drawing.Point(33, 38)
        Me.txthistoria.Name = "txthistoria"
        Me.txthistoria.Size = New System.Drawing.Size(100, 20)
        Me.txthistoria.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(186, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del paciente"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(189, 37)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(311, 20)
        Me.txtnombre.TabIndex = 3
        '
        'filtro
        '
        Me.filtro.FormattingEnabled = True
        Me.filtro.Items.AddRange(New Object() {"BCG", "Polio", "Pentavalente", "Rotavirus", "Varicela", "Trivalente", "Neumococo", "Fiebre Amarilla", "Hepatitis A", "Meningococo", "Influenza", "VPH", "COVID-19", "Todos"})
        Me.filtro.Location = New System.Drawing.Point(33, 104)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(175, 21)
        Me.filtro.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(33, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filtrar por vacuna"
        '
        'Tabla
        '
        Me.Tabla.AllowUserToAddRows = False
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(33, 155)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(677, 218)
        Me.Tabla.TabIndex = 6
        '
        'Buscar
        '
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.ForeColor = System.Drawing.Color.White
        Me.Buscar.Location = New System.Drawing.Point(214, 104)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 7
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(36, 405)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(134, 20)
        Me.txtfecha.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(219, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dosis"
        '
        'txtdosis
        '
        Me.txtdosis.Location = New System.Drawing.Point(222, 404)
        Me.txtdosis.Name = "txtdosis"
        Me.txtdosis.Size = New System.Drawing.Size(144, 20)
        Me.txtdosis.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(407, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Edad"
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(410, 404)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(110, 20)
        Me.txtedad.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(576, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Lote"
        '
        'txtlote
        '
        Me.txtlote.Location = New System.Drawing.Point(579, 404)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(100, 20)
        Me.txtlote.TabIndex = 15
        '
        'Modificar
        '
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.ForeColor = System.Drawing.Color.White
        Me.Modificar.Image = Global.SYSCLIN.My.Resources.Resources.pen_edit_modify_pencil_icon_181536
        Me.Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Modificar.Location = New System.Drawing.Point(391, 491)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(166, 32)
        Me.Modificar.TabIndex = 16
        Me.Modificar.Text = "Modificar Registro"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar.ForeColor = System.Drawing.Color.White
        Me.Eliminar.Image = Global.SYSCLIN.My.Resources.Resources.cancel_29373
        Me.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Eliminar.Location = New System.Drawing.Point(579, 491)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(156, 32)
        Me.Eliminar.TabIndex = 17
        Me.Eliminar.Text = "Eliminar Registro"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Registro_vacuna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(750, 535)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.txtlote)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdosis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.filtro)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txthistoria)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registro_vacuna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro vacuna"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txthistoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents filtro As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents Buscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdosis As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtedad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtlote As TextBox
    Friend WithEvents Modificar As Button
    Friend WithEvents Eliminar As Button
End Class
