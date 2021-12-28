Imports MySql.Data.MySqlClient

Public Class Inicio
    Dim conexion As New MySqlConnection
    Dim getting = New TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        Calc.Visible = False
        Nota.Visible = False
        'Percen.Visible = False
    End Sub

    Private Sub hideSubmenu()


    End Sub

    Private Sub showSubmenu(submenu As Inicio)


    End Sub

    Private Sub Historia_Click(sender As Object, e As EventArgs) Handles Historia.Click
        openChildForm(New Historia())



    End Sub

    Private Sub Motivo_Click(sender As Object, e As EventArgs) Handles Motivo.Click
        openChildForm(New Motivo())



    End Sub

    Private Sub Examenes_Click(sender As Object, e As EventArgs) Handles Examenes.Click
        openChildForm(New Examenes())


    End Sub



    Private Sub Antecedentes_Click(sender As Object, e As EventArgs) Handles Antecedentes.Click
        openChildForm(New Antecedentes())

    End Sub

    Private Sub Diagnostico_Click(sender As Object, e As EventArgs) Handles Diagnostico.Click
        openChildForm(New Diagnostico())



    End Sub

    Private currentForm As System.Windows.Forms.Form = Nothing
    Private Sub openChildForm(childForm As System.Windows.Forms.Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            conexion.ConnectionString = Login.cadena
            Dim delete As String = "DELETE FROM paciente_act"
            conexion.Open()
            Dim comando As MySqlCommand
            comando = New MySqlCommand(delete, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try
        Application.Exit()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Tratamiento.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        openChildForm(New Vacunas())


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Herramientas.Click
        If Calc.Visible = True And Nota.Visible = True Then
            Calc.Visible = False
            Nota.Visible = False
            'Percen.Visible = False
        Else
            Calc.Visible = True
            Nota.Visible = True
            'Percen.Visible = True
        End If
    End Sub

    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub Nota_Click(sender As Object, e As EventArgs) Handles Nota.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "notepad.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim a As DialogResult
        a = MessageBox.Show("¿Está seguro que desea cerrar el Formulario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (a = DialogResult.OK) Then
            e.Cancel = False

        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        openChildForm(New Nota())
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        openChildForm(New Historico())
    End Sub

    Private Sub Percen_Click(sender As Object, e As EventArgs) Handles Percen.Click
        openChildForm(New Percentiles())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
