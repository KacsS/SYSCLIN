<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Antecedentes
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
        Me.txtfamilia = New System.Windows.Forms.RichTextBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpersonales = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthistoria = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtfamilia)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Familiares"
        '
        'txtfamilia
        '
        Me.txtfamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfamilia.Enabled = False
        Me.txtfamilia.Location = New System.Drawing.Point(15, 19)
        Me.txtfamilia.Name = "txtfamilia"
        Me.txtfamilia.Size = New System.Drawing.Size(867, 237)
        Me.txtfamilia.TabIndex = 0
        Me.txtfamilia.Text = ""
        '
        'button5
        '
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.LightGray
        Me.button5.Location = New System.Drawing.Point(1, 2)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(25, 25)
        Me.button5.TabIndex = 16
        Me.button5.Text = "X"
        Me.button5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtpersonales)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 339)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(898, 294)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " * Personales"
        '
        'txtpersonales
        '
        Me.txtpersonales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpersonales.Enabled = False
        Me.txtpersonales.Location = New System.Drawing.Point(15, 19)
        Me.txtpersonales.Name = "txtpersonales"
        Me.txtpersonales.Size = New System.Drawing.Size(867, 256)
        Me.txtpersonales.TabIndex = 0
        Me.txtpersonales.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Historia"
        '
        'txthistoria
        '
        Me.txthistoria.Enabled = False
        Me.txthistoria.Location = New System.Drawing.Point(103, 22)
        Me.txthistoria.Name = "txthistoria"
        Me.txthistoria.Size = New System.Drawing.Size(100, 20)
        Me.txthistoria.TabIndex = 19
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(209, 21)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(264, 20)
        Me.txtnombre.TabIndex = 20
        '
        'Agregar
        '
        Me.Agregar.Enabled = False
        Me.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar.ForeColor = System.Drawing.Color.White
        Me.Agregar.Image = Global.SYSCLIN.My.Resources.Resources.Save_37110__1_
        Me.Agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Agregar.Location = New System.Drawing.Point(502, 639)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(89, 46)
        Me.Agregar.TabIndex = 21
        Me.Agregar.Text = "Guardar"
        Me.Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Enabled = False
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.ForeColor = System.Drawing.Color.White
        Me.Modificar.Image = Global.SYSCLIN.My.Resources.Resources.pen_edit_modify_pencil_icon_181536
        Me.Modificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Modificar.Location = New System.Drawing.Point(598, 639)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(93, 46)
        Me.Modificar.TabIndex = 22
        Me.Modificar.Text = "Modificar"
        Me.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo.ForeColor = System.Drawing.Color.White
        Me.Nuevo.Image = Global.SYSCLIN.My.Resources.Resources._1486485558_82add_create_new_cross_medical_plus_81161
        Me.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nuevo.Location = New System.Drawing.Point(414, 639)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(82, 46)
        Me.Nuevo.TabIndex = 23
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.ForeColor = System.Drawing.Color.White
        Me.Cancelar.Image = Global.SYSCLIN.My.Resources.Resources.cancel_29373
        Me.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancelar.Location = New System.Drawing.Point(697, 639)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(90, 46)
        Me.Cancelar.TabIndex = 24
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Antecedentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(922, 697)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txthistoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Antecedentes"
        Me.Text = "Antecedentes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents button5 As Button
    Friend WithEvents txtfamilia As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtpersonales As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txthistoria As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Agregar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Nuevo As Button
    Friend WithEvents Cancelar As Button
End Class
