Imports MySql.Data.MySqlClient

Public Class Nota
    Dim conexion As New MySqlConnection
    Private Sub Nota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = Login.cadena

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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txthistoriap.Text <> "") Then
            If (txtnota.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO nota (Num_historia,Nombre,Nota) SELECT '" + txthistoriap.Text + "','" + txtnombrep.Text + "',
            '" + txtnota.Text + "' "
                    Dim DT As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DT)
                    MessageBox.Show("Registrado Correctamente")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                Try
                    Dim update As String = "UPDATE nota SET Nota = '" & txtnota.Text & "'"
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
            End If
        Else
            MessageBox.Show("Debe llenar los campos obligatorios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub
End Class