<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Diagnostico
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.txtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.txtdiagnostico = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txthistoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button5
        '
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.LightGray
        Me.button5.Location = New System.Drawing.Point(2, 3)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(25, 25)
        Me.button5.TabIndex = 17
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tabla)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtdiagnostico)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txthistoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(834, 470)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diagnostico"
        '
        'Buscar
        '
        Me.Buscar.Enabled = False
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Location = New System.Drawing.Point(217, 286)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(94, 23)
        Me.Buscar.TabIndex = 14
        Me.Buscar.Text = "Refrescar Tabla"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(111, 288)
        Me.txtfecha.Mask = "00/00/0000"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 12
        Me.txtfecha.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Buscar por fecha"
        '
        'Tabla
        '
        Me.Tabla.AllowUserToAddRows = False
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tabla.DefaultCellStyle = DataGridViewCellStyle1
        Me.Tabla.Location = New System.Drawing.Point(14, 324)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(480, 140)
        Me.Tabla.TabIndex = 8
        Me.Tabla.Visible = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(11, 134)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(581, 125)
        Me.txtdescripcion.TabIndex = 7
        Me.txtdescripcion.Text = ""
        '
        'txtdiagnostico
        '
        Me.txtdiagnostico.Enabled = False
        Me.txtdiagnostico.Location = New System.Drawing.Point(111, 75)
        Me.txtdiagnostico.Name = "txtdiagnostico"
        Me.txtdiagnostico.Size = New System.Drawing.Size(264, 20)
        Me.txtdiagnostico.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "* Diagnostico Breve"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Enabled = False
        Me.MaskedTextBox1.Location = New System.Drawing.Point(572, 33)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(72, 20)
        Me.MaskedTextBox1.TabIndex = 4
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(518, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(238, 36)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(274, 20)
        Me.txtnombre.TabIndex = 2
        '
        'txthistoria
        '
        Me.txthistoria.Enabled = False
        Me.txthistoria.Location = New System.Drawing.Point(111, 36)
        Me.txthistoria.Name = "txthistoria"
        Me.txthistoria.Size = New System.Drawing.Size(121, 20)
        Me.txthistoria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Historia "
        '
        'Nuevo
        '
        Me.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo.ForeColor = System.Drawing.Color.White
        Me.Nuevo.Image = Global.SYSCLIN.My.Resources.Resources._1486485558_82add_create_new_cross_medical_plus_81161
        Me.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nuevo.Location = New System.Drawing.Point(12, 516)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(83, 41)
        Me.Nuevo.TabIndex = 13
        Me.Nuevo.Text = "Incluir"
        Me.Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.ForeColor = System.Drawing.Color.White
        Me.Modificar.Image = Global.SYSCLIN.My.Resources.Resources.pen_edit_modify_pencil_icon_181536
        Me.Modificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Modificar.Location = New System.Drawing.Point(197, 516)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(90, 41)
        Me.Modificar.TabIndex = 10
        Me.Modificar.Text = "Modificar"
        Me.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar.ForeColor = System.Drawing.Color.White
        Me.Agregar.Image = Global.SYSCLIN.My.Resources.Resources.Save_37110__1_
        Me.Agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Agregar.Location = New System.Drawing.Point(101, 516)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(90, 41)
        Me.Agregar.TabIndex = 9
        Me.Agregar.Text = "Agregar"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.SYSCLIN.My.Resources.Resources.cancel_29373
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(293, 516)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 41)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Diagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(860, 569)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Modificar)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Diagnostico"
        Me.Text = "Diagnostico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents txtdescripcion As RichTextBox
    Friend WithEvents txtdiagnostico As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txthistoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Agregar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents txtfecha As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Nuevo As Button
    Friend WithEvents Buscar As Button
    Friend WithEvents Button2 As Button
End Class
