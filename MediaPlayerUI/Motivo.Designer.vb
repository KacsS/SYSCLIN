<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Motivo
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
        Me.txtfechabusqueda = New System.Windows.Forms.MaskedTextBox()
        Me.txtimc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpe = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtta = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcc = New System.Windows.Forms.MaskedTextBox()
        Me.txttalla = New System.Windows.Forms.MaskedTextBox()
        Me.txtpeso = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtenfer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txthistoriaa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescri = New System.Windows.Forms.RichTextBox()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
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
        Me.button5.Location = New System.Drawing.Point(-4, -6)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(25, 25)
        Me.button5.TabIndex = 21
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.txtfechabusqueda)
        Me.GroupBox1.Controls.Add(Me.txtimc)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtpt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtpe)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtte)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Tabla)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcc)
        Me.GroupBox1.Controls.Add(Me.txttalla)
        Me.GroupBox1.Controls.Add(Me.txtpeso)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtenfer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txthistoriaa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdescri)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 578)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Buscar
        '
        Me.Buscar.Enabled = False
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Location = New System.Drawing.Point(210, 387)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(98, 25)
        Me.Buscar.TabIndex = 40
        Me.Buscar.Text = "Refrescar Tabla"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'txtfechabusqueda
        '
        Me.txtfechabusqueda.Enabled = False
        Me.txtfechabusqueda.Location = New System.Drawing.Point(106, 390)
        Me.txtfechabusqueda.Mask = "00/00/0000"
        Me.txtfechabusqueda.Name = "txtfechabusqueda"
        Me.txtfechabusqueda.Size = New System.Drawing.Size(100, 20)
        Me.txtfechabusqueda.TabIndex = 27
        Me.txtfechabusqueda.ValidatingType = GetType(Date)
        '
        'txtimc
        '
        Me.txtimc.Enabled = False
        Me.txtimc.Location = New System.Drawing.Point(350, 48)
        Me.txtimc.Name = "txtimc"
        Me.txtimc.Size = New System.Drawing.Size(147, 20)
        Me.txtimc.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(318, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "IMC"
        '
        'txtpt
        '
        Me.txtpt.Enabled = False
        Me.txtpt.Location = New System.Drawing.Point(350, 89)
        Me.txtpt.Name = "txtpt"
        Me.txtpt.Size = New System.Drawing.Size(72, 20)
        Me.txtpt.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(318, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "P/T"
        '
        'txtpe
        '
        Me.txtpe.Enabled = False
        Me.txtpe.Location = New System.Drawing.Point(236, 89)
        Me.txtpe.Name = "txtpe"
        Me.txtpe.Size = New System.Drawing.Size(72, 20)
        Me.txtpe.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(204, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "P/E"
        '
        'txtte
        '
        Me.txtte.Enabled = False
        Me.txtte.Location = New System.Drawing.Point(127, 89)
        Me.txtte.Name = "txtte"
        Me.txtte.Size = New System.Drawing.Size(72, 20)
        Me.txtte.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "T/E"
        '
        'txtta
        '
        Me.txtta.Enabled = False
        Me.txtta.Location = New System.Drawing.Point(660, 48)
        Me.txtta.Mask = "000/000 mm Hg"
        Me.txtta.Name = "txtta"
        Me.txtta.Size = New System.Drawing.Size(100, 20)
        Me.txtta.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(633, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "TA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Buscar por Fecha"
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
        Me.Tabla.Location = New System.Drawing.Point(6, 416)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(901, 140)
        Me.Tabla.TabIndex = 29
        Me.Tabla.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = " *Enfermedad Actual"
        '
        'txtcc
        '
        Me.txtcc.Enabled = False
        Me.txtcc.Location = New System.Drawing.Point(543, 48)
        Me.txtcc.Mask = "0000,00,cm"
        Me.txtcc.Name = "txtcc"
        Me.txtcc.Size = New System.Drawing.Size(66, 20)
        Me.txtcc.TabIndex = 13
        '
        'txttalla
        '
        Me.txttalla.Enabled = False
        Me.txttalla.Location = New System.Drawing.Point(236, 48)
        Me.txttalla.Name = "txttalla"
        Me.txttalla.Size = New System.Drawing.Size(66, 20)
        Me.txttalla.TabIndex = 9
        '
        'txtpeso
        '
        Me.txtpeso.Enabled = False
        Me.txtpeso.Location = New System.Drawing.Point(127, 51)
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(72, 20)
        Me.txtpeso.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(510, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "C.C "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(200, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "* Talla"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(90, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "* Peso"
        '
        'txtenfer
        '
        Me.txtenfer.Enabled = False
        Me.txtenfer.Location = New System.Drawing.Point(111, 154)
        Me.txtenfer.Name = "txtenfer"
        Me.txtenfer.Size = New System.Drawing.Size(344, 20)
        Me.txtenfer.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "* Motivo de Consulta"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(589, 12)
        Me.txtfecha.Mask = "00/00/0000"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(69, 20)
        Me.txtfecha.TabIndex = 5
        Me.txtfecha.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(229, 12)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(297, 20)
        Me.txtnombre.TabIndex = 3
        '
        'txthistoriaa
        '
        Me.txthistoriaa.Enabled = False
        Me.txthistoriaa.Location = New System.Drawing.Point(127, 12)
        Me.txthistoriaa.Name = "txthistoriaa"
        Me.txthistoriaa.Size = New System.Drawing.Size(96, 20)
        Me.txthistoriaa.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de Historia"
        '
        'txtdescri
        '
        Me.txtdescri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescri.Enabled = False
        Me.txtdescri.Location = New System.Drawing.Point(7, 226)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(827, 158)
        Me.txtdescri.TabIndex = 24
        Me.txtdescri.Text = ""
        '
        'Nuevo
        '
        Me.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo.Image = Global.SYSCLIN.My.Resources.Resources._1486485558_82add_create_new_cross_medical_plus_81161
        Me.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nuevo.Location = New System.Drawing.Point(12, 607)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(80, 43)
        Me.Nuevo.TabIndex = 32
        Me.Nuevo.Text = "Incluir"
        Me.Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Enabled = False
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.Image = Global.SYSCLIN.My.Resources.Resources.pen_edit_modify_pencil_icon_181536
        Me.Modificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Modificar.Location = New System.Drawing.Point(194, 607)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(89, 43)
        Me.Modificar.TabIndex = 34
        Me.Modificar.Text = "Modificar"
        Me.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar.Image = Global.SYSCLIN.My.Resources.Resources.Save_37110__1_
        Me.Agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Agregar.Location = New System.Drawing.Point(99, 607)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(89, 43)
        Me.Agregar.TabIndex = 33
        Me.Agregar.Text = "Agregar"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Image = Global.SYSCLIN.My.Resources.Resources.cancel_29373
        Me.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancelar.Location = New System.Drawing.Point(289, 607)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(89, 43)
        Me.Cancelar.TabIndex = 35
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Motivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 765)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button5)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Motivo"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button5 As Button
    Friend WithEvents txtenfer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfecha As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txthistoriaa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdescri As RichTextBox
    Friend WithEvents txtcc As MaskedTextBox
    Friend WithEvents txttalla As MaskedTextBox
    Friend WithEvents txtpeso As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents txtta As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtimc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtpt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpe As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtte As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfechabusqueda As MaskedTextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Nuevo As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents Cancelar As Button
End Class
