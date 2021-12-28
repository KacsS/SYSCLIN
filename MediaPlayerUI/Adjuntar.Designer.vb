<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
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
        Me.txthitoria = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Clean = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Historia"
        '
        'txthitoria
        '
        Me.txthitoria.Enabled = False
        Me.txthitoria.Location = New System.Drawing.Point(133, 25)
        Me.txthitoria.Name = "txthitoria"
        Me.txthitoria.Size = New System.Drawing.Size(100, 20)
        Me.txthitoria.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(253, 25)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(287, 20)
        Me.txtnombre.TabIndex = 3
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(670, 25)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(627, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Clean
        '
        Me.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clean.ForeColor = System.Drawing.Color.White
        Me.Clean.Image = Global.SYSCLIN.My.Resources.Resources.delete_remove_page_document_16678
        Me.Clean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Clean.Location = New System.Drawing.Point(315, 373)
        Me.Clean.Name = "Clean"
        Me.Clean.Size = New System.Drawing.Size(85, 43)
        Me.Clean.TabIndex = 9
        Me.Clean.Text = "Limpiar"
        Me.Clean.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Clean.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ForeColor = System.Drawing.Color.White
        Me.Save.Image = Global.SYSCLIN.My.Resources.Resources.Save_37110__1_
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Save.Location = New System.Drawing.Point(222, 373)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(87, 43)
        Me.Save.TabIndex = 8
        Me.Save.Text = "Guardar"
        Me.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Save.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add.ForeColor = System.Drawing.Color.White
        Me.Add.Image = Global.SYSCLIN.My.Resources.Resources.preview_search_find_locate_1551
        Me.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Add.Location = New System.Drawing.Point(133, 373)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(83, 43)
        Me.Add.TabIndex = 7
        Me.Add.Text = "Buscar"
        Me.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Add.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(133, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(508, 289)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Clean)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txthitoria)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjuntar Archivos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txthitoria As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Add As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Save As Button
    Friend WithEvents Clean As Button
End Class
