Imports MySql.Data.MySqlClient

Public Class Diagnostico
    Dim conexion As New MySqlConnection
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Diagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabla.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black
        MaskedTextBox1.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        conexion.ConnectionString = Login.cadena
        Modificar.Enabled = False
        Agregar.Enabled = False
        Try

            Dim consulta1 As String
            consulta1 = "SELECT * FROM paciente_act "
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                Me.txthistoria.Text = drd.Item("Num_historia").ToString
                Me.txtnombre.Text = drd.Item("Nombre").ToString
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
            consulta = "SELECT * FROM diagnostico WHERE Num_historia ='" + txthistoria.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "diagnostico")
            Tabla.DataSource = datos
            Tabla.DataMember = "diagnostico"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        If (txtdiagnostico.Text <> "") Then
            Try
                Dim guardar As String = "INSERT INTO diagnostico (Num_historia,Nombre,Fecha,Breve,Descripcion) SELECT '" + txthistoria.Text + "','" + txtnombre.Text + "',
            '" + MaskedTextBox1.Text + "','" + txtdiagnostico.Text + "','" + txtdescripcion.Text + "'"
                Dim DT As New DataTable
                Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                ADAPTADOR.Fill(DT)
                MessageBox.Show("Registrado Correctamente")
                txtdiagnostico.Clear()
                txtdescripcion.Clear()
                Agregar.Enabled = False
                Nuevo.Enabled = True
                conexion.Close()

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
                consulta = "SELECT * FROM diagnostico WHERE Num_historia ='" + txthistoria.Text + "' "
                adapter = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adapter.Fill(datos, "diagnostico")
                Tabla.DataSource = datos
                Tabla.DataMember = "diagnostico"
                conexion.Close()
                Show()
            Catch ex As Exception
            Finally
                conexion.Dispose()
            End Try
        End If

    End Sub

    Private Sub Tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellClick
        txthistoria.Text = Tabla.CurrentRow.Cells(0).Value
        txtnombre.Text = Tabla.CurrentRow.Cells(1).Value
        MaskedTextBox1.Text = Tabla.CurrentRow.Cells(2).Value
        txtdiagnostico.Text = Tabla.CurrentRow.Cells(3).Value
        txtdescripcion.Text = Tabla.CurrentRow.Cells(4).Value
        Modificar.Enabled = True
        Agregar.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Try
            Dim update As String = "UPDATE diagnostico SET Breve = '" & txtdiagnostico.Text & "', Descripcion = '" & txtdescripcion.Text & "'"
            conexion.Open()
            Dim comando As MySqlCommand
            comando = New MySqlCommand(update, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Modificado Correctamente")
            conexion.Close()
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
            consulta = "SELECT * FROM diagnostico WHERE Num_historia ='" + txthistoria.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "diagnostico")
            Tabla.DataSource = datos
            Tabla.DataMember = "diagnostico"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub MaskedTextBox2_MaskChanged(sender As Object, e As EventArgs) Handles txtfecha.MaskChanged
        Try
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM diagnostico WHERE Num_historia ='" + txthistoria.Text + "' AND Fecha LIKE '%" + txtfecha.Text + "%' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "diagnostico")
            Tabla.DataSource = datos
            Tabla.DataMember = "diagnostico"
            Tabla.Refresh()
            conexion.Close()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Nuevo.Click
        txtdiagnostico.Enabled = True
        txtdescripcion.Enabled = True
        txtfecha.Enabled = True
        Buscar.Enabled = True
        Tabla.Visible = True
        Agregar.Enabled = True
        Nuevo.Enabled = False


    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            Tabla.ReadOnly = True
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM diagnostico WHERE Num_historia ='" + txthistoria.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "diagnostico")
            Tabla.DataSource = datos
            Tabla.DataMember = "diagnostico"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        txtdiagnostico.Enabled = False
        txtdescripcion.Enabled = False
        txtdescripcion.Clear()
        txtdiagnostico.Clear()
        txtfecha.Enabled = False
        Buscar.Enabled = False
        Tabla.Visible = False
        Agregar.Enabled = False
        Modificar.Enabled = False
        Nuevo.Enabled = True


    End Sub
End Class