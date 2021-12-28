Imports MySql.Data.MySqlClient

Public Class Examenes
    Dim conexion As New MySqlConnection
    Dim x As New TextBox
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Recp_exam.Show()
    End Sub

    Private Sub Examenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black

        txtfecha.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        conexion.ConnectionString = Login.cadena
        Agregar.Enabled = False
        Try
            Dim consulta1 As String
            consulta1 = "SELECT * FROM paciente_act "
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                Me.txthistoriap.Text = drd.Item("Num_historia").ToString
                Me.txtnombrep.Text = drd.Item("Nombre").ToString
                conexion.Close()
            End If
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try


        Try
            Tabla.ReadOnly = True
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM paraclinicos WHERE Num_historia ='" + txthistoriap.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "paraclinicos")
            Tabla.DataSource = datos
            Tabla.DataMember = "paraclinicos"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        If (txtexamen.Text <> "") Then
            Try
                Dim guardar As String = "INSERT INTO paraclinicos (Num_historia,Nombre,Fecha,Examen) SELECT '" + txthistoriap.Text + "','" + txtnombrep.Text + "',
            '" + txtfecha.Text + "','" + txtexamen.Text + "' "
                Dim DT As New DataTable
                Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                ADAPTADOR.Fill(DT)
                MessageBox.Show("Registrado Correctamente")
                conexion.Close()
                txtexamen.Clear()
                Nuevo.Enabled = True
                Modificar.Enabled = False
                Agregar.Enabled = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conexion.Dispose()
            End Try

            Try
                Tabla.ReadOnly = True
                Dim adapter As MySqlDataAdapter
                Dim datos As DataSet
                conexion.Open()
                Dim consulta As String
                consulta = "SELECT * FROM paraclinicos WHERE Num_historia ='" + txthistoriap.Text + "' "
                adapter = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adapter.Fill(datos, "paraclinicos")
                Tabla.DataSource = datos
                Tabla.DataMember = "paraclinicos"
                conexion.Close()
                Show()
            Catch ex As Exception
            Finally
                conexion.Dispose()
            End Try
        Else
            MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Adjuntar1.Click
        form.Show()
    End Sub

    Private Sub Tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellClick
        x.Text = Tabla.CurrentRow.Cells(0).Value.ToString

        txtfecha.Text = Tabla.CurrentRow.Cells(3).Value
        txtexamen.Text = Tabla.CurrentRow.Cells(4).Value
        Modificar.Enabled = True
        Agregar.Enabled = False
    End Sub

    Private Sub MaskedTextBox1_MaskChanged(sender As Object, e As EventArgs) Handles txtfiltro.MaskChanged
        Try
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM paraclinicos WHERE Num_historia ='" + txthistoriap.Text + "' AND Fecha LIKE '%" + txtfiltro.Text + "%' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "paraclinicos")
            Tabla.DataSource = datos
            Tabla.DataMember = "paraclinicos"
            Tabla.Refresh()
            conexion.Close()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try

    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        txtexamen.Clear()
        txtfecha.ResetText()
        txtfecha.Enabled = True
        txtexamen.Enabled = True
        Adjuntar1.Enabled = True
        Verdoc.Enabled = True
        txtfiltro.Enabled = True
        Buscar.Enabled = True
        Agregar.Enabled = True
        Modificar.Enabled = False
        Nuevo.Enabled = False
        Tabla.Visible = True
        txtfecha.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            Tabla.ReadOnly = True
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM paraclinicos WHERE Num_historia ='" + txthistoriap.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "paraclinicos")
            Tabla.DataSource = datos
            Tabla.DataMember = "paraclinicos"
            conexion.Close()
            txtfiltro.Clear()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Verdoc.Click
        Ver_documentos.Show()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        txtexamen.Clear()
        txtfiltro.Clear()
        Adjuntar1.Enabled = False
        Verdoc.Enabled = False
        Agregar.Enabled = False
        Modificar.Enabled = False
        Tabla.Visible = False
        txtfecha.ResetText()
        Nuevo.Enabled = True
        txtfecha.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Try
            Dim update As String = "UPDATE paraclinicos SET Examen = '" & txtexamen.Text & "' WHERE ID = " & x.Text & " "
            conexion.Open()
            Dim comando As MySqlCommand
            comando = New MySqlCommand(update, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Modificado Correctamente")
            conexion.Close()
            txtexamen.Clear()
            Nuevo.Enabled = True
            Modificar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try

        Try
            Tabla.ReadOnly = True
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM paraclinicos WHERE Num_historia ='" + txthistoriap.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "paraclinicos")
            Tabla.DataSource = datos
            Tabla.DataMember = "paraclinicos"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub
End Class