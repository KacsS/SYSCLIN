<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Percen = New System.Windows.Forms.Button()
        Me.Nota = New System.Windows.Forms.Button()
        Me.Calc = New System.Windows.Forms.Button()
        Me.Herramientas = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Diagnostico = New System.Windows.Forms.Button()
        Me.Examenes = New System.Windows.Forms.Button()
        Me.Antecedentes = New System.Windows.Forms.Button()
        Me.Motivo = New System.Windows.Forms.Button()
        Me.Historia = New System.Windows.Forms.Button()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.panelLogo.SuspendLayout()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelChildForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.panelLogo.Controls.Add(Me.Label2)
        Me.panelLogo.Controls.Add(Me.Label1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(161, 62)
        Me.panelLogo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Historia Clinica Pediatrica"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MTGSystem"
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PanelSideMenu.Controls.Add(Me.Button7)
        Me.PanelSideMenu.Controls.Add(Me.Button6)
        Me.PanelSideMenu.Controls.Add(Me.Button5)
        Me.PanelSideMenu.Controls.Add(Me.Button4)
        Me.PanelSideMenu.Controls.Add(Me.Button3)
        Me.PanelSideMenu.Controls.Add(Me.Percen)
        Me.PanelSideMenu.Controls.Add(Me.Nota)
        Me.PanelSideMenu.Controls.Add(Me.Calc)
        Me.PanelSideMenu.Controls.Add(Me.Herramientas)
        Me.PanelSideMenu.Controls.Add(Me.Button2)
        Me.PanelSideMenu.Controls.Add(Me.Button1)
        Me.PanelSideMenu.Controls.Add(Me.btnExit)
        Me.PanelSideMenu.Controls.Add(Me.Diagnostico)
        Me.PanelSideMenu.Controls.Add(Me.Examenes)
        Me.PanelSideMenu.Controls.Add(Me.Antecedentes)
        Me.PanelSideMenu.Controls.Add(Me.Motivo)
        Me.PanelSideMenu.Controls.Add(Me.Historia)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(178, 598)
        Me.PanelSideMenu.TabIndex = 0
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = Global.SYSCLIN.My.Resources.Resources._068minimize_100011
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(0, 737)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(161, 45)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "Minimizar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(0, 692)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(161, 45)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Acerca de"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = Global.SYSCLIN.My.Resources.Resources.Historical_icon_icons_com_54175__1_
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button5.Location = New System.Drawing.Point(0, 647)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(161, 45)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Historico"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.SYSCLIN.My.Resources.Resources.Attach_26997
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(0, 602)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(161, 45)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Nota informativa"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(0, 557)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(161, 45)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Informes"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Percen
        '
        Me.Percen.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Percen.Dock = System.Windows.Forms.DockStyle.Top
        Me.Percen.FlatAppearance.BorderSize = 0
        Me.Percen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Percen.ForeColor = System.Drawing.Color.Black
        Me.Percen.Image = Global.SYSCLIN.My.Resources.Resources._4_icon_icons_com_67659
        Me.Percen.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Percen.Location = New System.Drawing.Point(0, 512)
        Me.Percen.Name = "Percen"
        Me.Percen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Percen.Size = New System.Drawing.Size(161, 45)
        Me.Percen.TabIndex = 18
        Me.Percen.Text = "Percentiles"
        Me.Percen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Percen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Percen.UseVisualStyleBackColor = False
        Me.Percen.Visible = False
        '
        'Nota
        '
        Me.Nota.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Nota.Dock = System.Windows.Forms.DockStyle.Top
        Me.Nota.FlatAppearance.BorderSize = 0
        Me.Nota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nota.ForeColor = System.Drawing.Color.Black
        Me.Nota.Image = CType(resources.GetObject("Nota.Image"), System.Drawing.Image)
        Me.Nota.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Nota.Location = New System.Drawing.Point(0, 467)
        Me.Nota.Name = "Nota"
        Me.Nota.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Nota.Size = New System.Drawing.Size(161, 45)
        Me.Nota.TabIndex = 14
        Me.Nota.Text = "Nota Rapida"
        Me.Nota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nota.UseVisualStyleBackColor = False
        '
        'Calc
        '
        Me.Calc.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Calc.Dock = System.Windows.Forms.DockStyle.Top
        Me.Calc.FlatAppearance.BorderSize = 0
        Me.Calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Calc.ForeColor = System.Drawing.Color.Black
        Me.Calc.Image = CType(resources.GetObject("Calc.Image"), System.Drawing.Image)
        Me.Calc.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Calc.Location = New System.Drawing.Point(0, 422)
        Me.Calc.Name = "Calc"
        Me.Calc.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Calc.Size = New System.Drawing.Size(161, 45)
        Me.Calc.TabIndex = 13
        Me.Calc.Text = "Calculadora"
        Me.Calc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Calc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Calc.UseVisualStyleBackColor = False
        '
        'Herramientas
        '
        Me.Herramientas.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Herramientas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Herramientas.FlatAppearance.BorderSize = 0
        Me.Herramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Herramientas.ForeColor = System.Drawing.Color.Black
        Me.Herramientas.Image = CType(resources.GetObject("Herramientas.Image"), System.Drawing.Image)
        Me.Herramientas.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Herramientas.Location = New System.Drawing.Point(0, 377)
        Me.Herramientas.Name = "Herramientas"
        Me.Herramientas.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Herramientas.Size = New System.Drawing.Size(161, 45)
        Me.Herramientas.TabIndex = 12
        Me.Herramientas.Text = "Herramientas"
        Me.Herramientas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Herramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Herramientas.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(0, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(161, 45)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Vacunas"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(0, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(161, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Tratamiento"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 782)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(161, 45)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Salir"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Diagnostico
        '
        Me.Diagnostico.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Diagnostico.Dock = System.Windows.Forms.DockStyle.Top
        Me.Diagnostico.FlatAppearance.BorderSize = 0
        Me.Diagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Diagnostico.ForeColor = System.Drawing.Color.Black
        Me.Diagnostico.Image = CType(resources.GetObject("Diagnostico.Image"), System.Drawing.Image)
        Me.Diagnostico.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Diagnostico.Location = New System.Drawing.Point(0, 242)
        Me.Diagnostico.Name = "Diagnostico"
        Me.Diagnostico.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Diagnostico.Size = New System.Drawing.Size(161, 45)
        Me.Diagnostico.TabIndex = 8
        Me.Diagnostico.Text = "Diagnóstico"
        Me.Diagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Diagnostico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Diagnostico.UseVisualStyleBackColor = False
        '
        'Examenes
        '
        Me.Examenes.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Examenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Examenes.FlatAppearance.BorderSize = 0
        Me.Examenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Examenes.ForeColor = System.Drawing.Color.Black
        Me.Examenes.Image = CType(resources.GetObject("Examenes.Image"), System.Drawing.Image)
        Me.Examenes.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Examenes.Location = New System.Drawing.Point(0, 197)
        Me.Examenes.Name = "Examenes"
        Me.Examenes.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Examenes.Size = New System.Drawing.Size(161, 45)
        Me.Examenes.TabIndex = 6
        Me.Examenes.Text = "Paraclínicos"
        Me.Examenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Examenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Examenes.UseVisualStyleBackColor = False
        '
        'Antecedentes
        '
        Me.Antecedentes.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Antecedentes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Antecedentes.FlatAppearance.BorderSize = 0
        Me.Antecedentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Antecedentes.ForeColor = System.Drawing.Color.Black
        Me.Antecedentes.Image = CType(resources.GetObject("Antecedentes.Image"), System.Drawing.Image)
        Me.Antecedentes.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Antecedentes.Location = New System.Drawing.Point(0, 152)
        Me.Antecedentes.Name = "Antecedentes"
        Me.Antecedentes.Size = New System.Drawing.Size(161, 45)
        Me.Antecedentes.TabIndex = 5
        Me.Antecedentes.Text = "Antecedentes"
        Me.Antecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Antecedentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Antecedentes.UseVisualStyleBackColor = False
        '
        'Motivo
        '
        Me.Motivo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Motivo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Motivo.FlatAppearance.BorderSize = 0
        Me.Motivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Motivo.ForeColor = System.Drawing.Color.Black
        Me.Motivo.Image = CType(resources.GetObject("Motivo.Image"), System.Drawing.Image)
        Me.Motivo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Motivo.Location = New System.Drawing.Point(0, 107)
        Me.Motivo.Name = "Motivo"
        Me.Motivo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Motivo.Size = New System.Drawing.Size(161, 45)
        Me.Motivo.TabIndex = 3
        Me.Motivo.Text = "Motivo"
        Me.Motivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Motivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Motivo.UseVisualStyleBackColor = False
        '
        'Historia
        '
        Me.Historia.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Historia.Dock = System.Windows.Forms.DockStyle.Top
        Me.Historia.FlatAppearance.BorderSize = 0
        Me.Historia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Historia.ForeColor = System.Drawing.Color.Black
        Me.Historia.Image = CType(resources.GetObject("Historia.Image"), System.Drawing.Image)
        Me.Historia.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Historia.Location = New System.Drawing.Point(0, 62)
        Me.Historia.Name = "Historia"
        Me.Historia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Historia.Size = New System.Drawing.Size(161, 45)
        Me.Historia.TabIndex = 1
        Me.Historia.Text = "Historia Clínica"
        Me.Historia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Historia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Historia.UseVisualStyleBackColor = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.PanelChildForm.Controls.Add(Me.Panel1)
        Me.PanelChildForm.Controls.Add(Me.PictureBox9)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(178, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(770, 598)
        Me.PanelChildForm.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(35, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(143, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(404, 39)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Francisco Finizola Celli"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(145, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 39)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Consultorio Pediatrico"
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(35, 148)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(679, 507)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelLogo.ResumeLayout(False)
        Me.panelLogo.PerformLayout()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelChildForm.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnExit As Button
    Private WithEvents Diagnostico As Button
    Private WithEvents Examenes As Button
    Private WithEvents Antecedentes As Button
    Private WithEvents Motivo As Button
    Private WithEvents Historia As Button
    Friend WithEvents PictureBox9 As PictureBox
    Private WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents Button2 As Button
    Private WithEvents Herramientas As Button
    Private WithEvents panelLogo As System.Windows.Forms.Panel
    Friend WithEvents PanelChildForm As System.Windows.Forms.Panel
    Private WithEvents Nota As Button
    Private WithEvents Calc As Button
    Private WithEvents Percen As Button
    Private WithEvents Button5 As Button
    Private WithEvents Button4 As Button
    Private WithEvents Button3 As Button
    Public WithEvents PanelSideMenu As Panel
    Private WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents Button7 As Button
End Class
