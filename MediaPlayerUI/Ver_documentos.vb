Imports MySql.Data.MySqlClient

Public Class Ver_documentos
    Dim conexion As New MySqlConnection
    Private Sub Ver_documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfecha.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        conexion.ConnectionString = Login.cadena
        Try
            Dim consulta1 As String
            consulta1 = "SELECT * FROM paciente_act "
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                Me.txthitoria.Text = drd.Item("Num_historia").ToString
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
            consulta = "SELECT * FROM documentos WHERE Num_historia ='" + txthitoria.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "documentos")
            Tabla.DataSource = datos
            Tabla.DataMember = "documentos"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub Tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellContentClick

    End Sub

    Private Sub Tabla_Click(sender As Object, e As EventArgs) Handles Tabla.Click
        PictureBox1.Image = Tabla.CurrentRow.Cells(3).FormattedValue
    End Sub
End Class