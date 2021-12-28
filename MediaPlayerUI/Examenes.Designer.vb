<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Examenes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Verdoc = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.txtfiltro = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Adjuntar1 = New System.Windows.Forms.Button()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.txtexamen = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombrep = New System.Windows.Forms.TextBox()
        Me.txthistoriap = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Verdoc)
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.txtfiltro)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Adjuntar1)
        Me.GroupBox1.Controls.Add(Me.Tabla)
        Me.GroupBox1.Controls.Add(Me.txtexamen)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnombrep)
        Me.GroupBox1.Controls.Add(Me.txthistoriap)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(925, 545)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Examenes"
        '
        'Verdoc
        '
        Me.Verdoc.Enabled = False
        Me.Verdoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Verdoc.Image = Global.SYSCLIN.My.Resources.Resources.view_search_find_image_photo_6099
        Me.Verdoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Verdoc.Location = New System.Drawing.Point(700, 288)
        Me.Verdoc.Name = "Verdoc"
        Me.Verdoc.Size = New System.Drawing.Size(134, 44)
        Me.Verdoc.TabIndex = 57
        Me.Verdoc.Text = "Ver Documentos"
        Me.Verdoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Verdoc.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Enabled = False
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Location = New System.Drawing.Point(220, 350)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(95, 23)
        Me.Buscar.TabIndex = 55
        Me.Buscar.Text = "Refrescar Tabla"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'txtfiltro
        '
        Me.txtfiltro.Enabled = False
        Me.txtfiltro.Location = New System.Drawing.Point(114, 352)
        Me.txtfiltro.Mask = "00/00/0000"
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtfiltro.TabIndex = 54
        Me.txtfiltro.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Buscar por fecha"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.SYSCLIN.My.Resources.Resources.exam_icon_182959
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(752, 475)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 44)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Orden de examen"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(662, 33)
        Me.txtfecha.Mask = "00/00/0000"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(73, 20)
        Me.txtfecha.TabIndex = 51
        Me.txtfecha.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(556, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Fecha del estudio"
        '
        'Adjuntar1
        '
        Me.Adjuntar1.Enabled = False
        Me.Adjuntar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adjuntar1.Image = Global.SYSCLIN.My.Resources.Resources.Attach_26997
        Me.Adjuntar1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Adjuntar1.Location = New System.Drawing.Point(571, 288)
        Me.Adjuntar1.Name = "Adjuntar1"
        Me.Adjuntar1.Size = New System.Drawing.Size(123, 44)
        Me.Adjuntar1.TabIndex = 49
        Me.Adjuntar1.Text = "Adjuntar archivo"
        Me.Adjuntar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Adjuntar1.UseVisualStyleBackColor = True
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
        Me.Tabla.Location = New System.Drawing.Point(15, 395)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(541, 144)
        Me.Tabla.TabIndex = 48
        Me.Tabla.Visible = False
        '
        'txtexamen
        '
        Me.txtexamen.Enabled = False
        Me.txtexamen.Location = New System.Drawing.Point(15, 133)
        Me.txtexamen.Name = "txtexamen"
        Me.txtexamen.Size = New System.Drawing.Size(541, 199)
        Me.txtexamen.TabIndex = 46
        Me.txtexamen.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "* Examen"
        '
        'txtnombrep
        '
        Me.txtnombrep.Enabled = False
        Me.txtnombrep.Location = New System.Drawing.Point(220, 26)
        Me.txtnombrep.Name = "txtnombrep"
        Me.txtnombrep.Size = New System.Drawing.Size(297, 20)
        Me.txtnombrep.TabIndex = 44
        '
        'txthistoriap
        '
        Me.txthistoriap.Enabled = False
        Me.txthistoriap.Location = New System.Drawing.Point(118, 26)
        Me.txthistoriap.Name = "txthistoriap"
        Me.txthistoriap.Size = New System.Drawing.Size(96, 20)
        Me.txthistoriap.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Numero de Historia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Nuevo
        '
        Me.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo.ForeColor = System.Drawing.Color.White
        Me.Nuevo.Image = Global.SYSCLIN.My.Resources.Resources._1486485558_82add_create_new_cross_medical_plus_81161
        Me.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nuevo.Location = New System.Drawing.Point(12, 576)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(84, 44)
        Me.Nuevo.TabIndex = 56
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar.ForeColor = System.Drawing.Color.White
        Me.Agregar.Image = Global.SYSCLIN.My.Resources.Resources.Save_37110__1_
        Me.Agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Agregar.Location = New System.Drawing.Point(102, 576)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(84, 44)
        Me.Agregar.TabIndex = 47
        Me.Agregar.Text = "Agregar"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.LightGray
        Me.button5.Location = New System.Drawing.Point(3, 2)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(25, 25)
        Me.button5.TabIndex = 16
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Modificar
        '
        Me.Modificar.Enabled = False
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.ForeColor = System.Drawing.Color.White
        Me.Modificar.Image = Global.SYSCLIN.My.Resources.Resources.pen_edit_modify_pencil_icon_181536
        Me.Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Modificar.Location = New System.Drawing.Point(192, 576)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(93, 44)
        Me.Modificar.TabIndex = 57
        Me.Modificar.Text = "Modificar"
        Me.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.ForeColor = System.Drawing.Color.White
        Me.Cancelar.Image = Global.SYSCLIN.My.Resources.Resources.cancel_29373
        Me.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancelar.Location = New System.Drawing.Point(291, 576)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(94, 44)
        Me.Cancelar.TabIndex = 58
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Examenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 658)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Agregar)
        Me.Name = "Examenes"
        Me.Text = "Examenes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Adjuntar1 As Button
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents Agregar As Button
    Friend WithEvents txtexamen As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombrep As TextBox
    Friend WithEvents txthistoriap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfecha As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents txtfiltro As MaskedTextBox
    Friend WithEvents Nuevo As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Verdoc As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Cancelar As Button
End Class
