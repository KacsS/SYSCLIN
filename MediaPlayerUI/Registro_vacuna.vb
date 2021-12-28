Imports MySql.Data.MySqlClient

Public Class Registro_vacuna
    Dim conexion As New MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim datos As DataSet
    Dim Sql As String
    Dim x As New TextBox

    Private Sub Registro_vacuna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = Login.cadena
        Try
            Dim dt As New DataTable
            Dim consulta1 As String
            consulta1 = "SELECT * FROM paciente_act "
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                Me.txthistoria.Text = drd.Item("Num_historia").ToString
                Me.txtnombre.Text = drd.Item("Nombre").ToString
            End If
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellClick
        x.Text = Tabla.CurrentRow.Cells(0).Value
        txtfecha.Text = Tabla.CurrentRow.Cells(3).Value
        txtdosis.Text = Tabla.CurrentRow.Cells(4).Value
        txtedad.Text = Tabla.CurrentRow.Cells(5).Value
        txtlote.Text = Tabla.CurrentRow.Cells(6).Value.ToString

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        If (filtro.Text.Length = 0) Then
            MessageBox.Show("El filtro de busqueda no puede estan blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (filtro.Text = "BCG") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Polio") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Pentavalente") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Rotavirus") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Varicela") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Trivalente") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Neumococo") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Fiebre Amarilla") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Hepatitis A") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Meningococo") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "Influenza") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If

            If (filtro.Text = "VPH") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If


            If (filtro.Text = "Todos") Then
                Try
                    conexion.Open()
                    Dim consulta As String
                    consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "'"
                    adapter = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adapter.Fill(datos, "vacunas")
                    Tabla.DataSource = datos
                    Tabla.DataMember = "vacunas"
                Catch ex As Exception
                    MessageBox.Show("Error al conectar")
                End Try
                conexion.Close()
            End If
        End If
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Try
            Dim update As String = "UPDATE vacunas SET fecha = '" & txtfecha.Text & "', dosis = '" & txtdosis.Text & "', edad = '" & txtedad.Text & "', lote = '" & txtlote.Text & "'  WHERE ID = " & x.Text & " "
            conexion.Open()
            Dim comando As MySqlCommand
            comando = New MySqlCommand(update, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Modificado Correctamente")
            txtfecha.Clear()
            txtdosis.Clear()
            txtedad.Clear()
            txtlote.Clear()
            Modificar.Enabled = True
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try

        Try
            Dim consulta As String
            consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "vacunas")
            Tabla.DataSource = datos
            Tabla.DataMember = "vacunas"
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        End Try


    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Try
            Dim update As String = "DELETE FROM vacunas WHERE Num_historia = '" & txthistoria.Text & "'and nombre = '" & filtro.Text & "'and dosis = '" & txtdosis.Text & "'"
            Dim comando As MySqlCommand
            comando = New MySqlCommand(update, conexion)
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Registro Eliminado")
            txtfecha.Clear()
            txtdosis.Clear()
            txtedad.Clear()
            txtlote.Clear()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try

        Try
            Dim consulta As String
            consulta = "SELECT * FROM vacunas WHERE Num_historia= '" + txthistoria.Text + "' and nombre = '" + filtro.Text + "'"
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "vacunas")
            Tabla.DataSource = datos
            Tabla.DataMember = "vacunas"
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        End Try
    End Sub
End Class