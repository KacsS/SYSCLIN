Imports MySql.Data.MySqlClient

Public Class Historico
    Dim conexion As New MySqlConnection
    Dim x As String
    Private Sub Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = Login.cadena

    End Sub

    Private currentForm As System.Windows.Forms.Form = Nothing

    Private Sub openChildForm(childForm As System.Windows.Forms.Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        Dim frmx As New Pac_histo
        AddOwnedForm(frmx)
        frmx.ShowDialog()
        Buscar.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = txtnombre.Text + "" + txtapellido.Text


        Try
            Dim DataAdaptar As MySqlDataAdapter
            Dim Dataset As New DataSet
            Dim Sql As String
            Dim sw As Boolean = False
            Sql = "SELECT * FROM ficha_prin WHERE Num_historia = '" & txthistoriah.Text & "'"
            conexion.Open()
            DataAdaptar = New MySqlDataAdapter(Sql, conexion)
            Dataset.Clear()
            DataAdaptar.Fill(Dataset, "ficha_prin")
            If (Dataset.Tables("ficha_prin").Rows.Count() <> 0) Then
                MessageBox.Show("El numero de Historia ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sw = True
            Else
                If txtcedularepreh.Text <> "" And txthistoriah.Text <> "" Then
                    Try
                        Dim guardar As String = "INSERT INTO ficha_prin (Num_historia,Nombre_paciente,Fecha_naci,Domicilio,Sexo,Cedu_repre,Nombre_repre,ocupacion) SELECT 
            '" + txthistoriah.Text + "','" + x + "','" + txtfecha.Text + "','" + txtdireccion.Text + "','" + txtsexo.Text + "','" + txtcedularepreh.Text + "','" + txtnombrerepre.Text + "','" + txtocupacion.Text + "'"
                        Dim DT As New DataTable
                        Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                        ADAPTADOR.Fill(DT)
                        MessageBox.Show("Exportado Correctamente")
                        conexion.Close()
                        txthistoriah.Clear()
                        txtnombre.Clear()
                        txtapellido.Clear()
                        txtfecha.Clear()
                        txtsexo.Clear()
                        txtcedulah.Clear()
                        txtnombrerepre.Clear()
                        txtapellidosrepre.Clear()
                        txtocupacion.Clear()
                        txtdireccion.Clear()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        conexion.Dispose()
                    End Try
                Else

                    MsgBox("Debe Incluir los campos obligatorios")
                End If
            End If
            conexion.Close()

        Catch ex As Exception
        Finally
            'conexion.Dispose()
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Buscar.Enabled = True
        txthistoriah.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txtfecha.Clear()
        txtsexo.Clear()
        txtcedulah.Clear()

        txtcedularepreh.Clear()
        txtnombrerepre.Clear()
        txtapellidosrepre.Clear()
        txtocupacion.Clear()
        txtdireccion.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            Dim dt As New DataTable
            Dim consulta1 As String
            consulta1 = "select hr.Cedula, hr.nombres, hr.apellidos, hr.ocupacion, hr.Direccion from hist_histpacientes hp inner join hist_histrepre hr on hp.cedula_repre = hr.Cedula where hp.cedula_repre= " + txtcedulah.Text + ""
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                txtcedularepreh.Text = drd.Item("Cedula").ToString
                txtnombrerepre.Text = drd.Item("nombres").ToString
                txtapellidosrepre.Text = drd.Item("apellidos").ToString
                txtdireccion.Text = drd.Item("Direccion").ToString
            Else
                MessageBox.Show("error")
            End If
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub
End Class