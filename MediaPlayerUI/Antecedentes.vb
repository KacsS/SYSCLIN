Imports MySql.Data.MySqlClient

Public Class Antecedentes
    Dim conexion As New MySqlConnection
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Antecedentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = Login.cadena
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
            Dim consulta1 As String
            consulta1 = "SELECT * FROM antecedentes WHERE Num_historia= '" + txthistoria.Text + "' "
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                Me.txtfamilia.Text = drd.Item("Faniliares").ToString
                Me.txtpersonales.Text = drd.Item("Personales").ToString
                conexion.Close()
            End If
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        If (txtpersonales.Text <> "") Then
            Try
                Dim guardar As String = "INSERT INTO antecedentes (Num_historia,Nombre,Faniliares,Personales) SELECT '" + txthistoria.Text + "','" + txtnombre.Text + "',
            '" + txtfamilia.Text + "','" + txtpersonales.Text + "' "
                Dim DT As New DataTable
                Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                ADAPTADOR.Fill(DT)
                MessageBox.Show("Registrado Correctamente")
                Agregar.Enabled = False
                Modificar.Enabled = True
                conexion.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conexion.Dispose()
            End Try
        Else
            MessageBox.Show("Debe registrar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Try
            Dim update As String = "UPDATE antecedentes SET Faniliares = '" & txtfamilia.Text & "', Personales = '" & txtpersonales.Text & "'  WHERE Num_historia = " & txthistoria.Text & " "
            conexion.Open()
            Dim comando As MySqlCommand
            comando = New MySqlCommand(update, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Modificado Correctamente")
            Modificar.Enabled = False
            txtfamilia.Enabled = False
            txtpersonales.Enabled = False
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Nuevo.Click
        If (txtfamilia.Text <> "" And txtpersonales.Text <> "") Then
            Agregar.Enabled = False
            Modificar.Enabled = True
        Else
            Agregar.Enabled = True
            Modificar.Enabled = False
        End If
        txtfamilia.Enabled = True
        txtpersonales.Enabled = True
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Cancelar.Click
        Agregar.Enabled = False
        Modificar.Enabled = False
        txtfamilia.Enabled = False
        txtpersonales.Enabled = False
    End Sub
End Class