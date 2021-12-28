Imports MySql.Data.MySqlClient

Public Class Pac_histo
    Dim conexion As New MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim datos As DataSet
    Private Sub Pac_histo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellDoubleClick
        Dim frmx As Historico = CType(Owner, Historico)
        frmx.txthistoriah.Text = Tabla.CurrentRow.Cells(0).Value.ToString()
        frmx.txtcedulah.Text = Tabla.CurrentRow.Cells(1).Value.ToString()
        frmx.txtnombre.Text = Tabla.CurrentRow.Cells(2).Value.ToString()
        frmx.txtapellido.Text = Tabla.CurrentRow.Cells(3).Value.ToString()
        frmx.txtfecha.Text = Tabla.CurrentRow.Cells(4).Value.ToString()
        frmx.txtsexo.Text = Tabla.CurrentRow.Cells(5).Value.ToString()
        frmx.txtcedularepreh.Text = Tabla.CurrentRow.Cells(6).Value.ToString
        frmx.txtnombrerepre.Text = Tabla.CurrentRow.Cells(7).Value.ToString
        frmx.txtapellidosrepre.Text = Tabla.CurrentRow.Cells(8).Value.ToString
        frmx.txtocupacion.Text = Tabla.CurrentRow.Cells(9).Value.ToString
        frmx.txtdireccion.Text = Tabla.CurrentRow.Cells(10).Value.ToString
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If (RadioButton1.Checked) Then
            Try
                Dim adapter As MySqlDataAdapter
                Dim datos As DataSet
                conexion.Open()
                Dim consulta As String
                consulta = "select * from hist_histpacientes hp inner join hist_histrepre hr on hp.cedula_repre=hr.Cedula where hp.Num_historia LIKE '%" & txtbuscar.Text & "%' or hp.nombres LIKE '%" & txtbuscar.Text & "%' or hp.apellidos LIKE '%" & txtbuscar.Text & "%'  "
                adapter = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adapter.Fill(datos, "hist_histpacientes")
                Tabla.DataSource = datos
                Tabla.DataMember = "hist_histpacientes"
                Tabla.Refresh()
                conexion.Close()
            Catch ex As Exception
            Finally
                conexion.Dispose()
            End Try
        Else
            MessageBox.Show("Debe seleccionar un listado")
        End If

        If (RadioButton2.Checked) Then
            Try
                Dim adapter As MySqlDataAdapter
                Dim datos As DataSet
                conexion.Open()
                Dim consulta As String
                consulta = "select * from hist_histpacientes where Num_historia LIKE '%" & txtbuscar.Text & "%' or nombres LIKE '%" & txtbuscar.Text & "%' or apellidos LIKE '%" & txtbuscar.Text & "%'  "
                adapter = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adapter.Fill(datos, "hist_histpacientes")
                Tabla.DataSource = datos
                Tabla.DataMember = "hist_histpacientes"
                Tabla.Refresh()
                conexion.Close()
            Catch ex As Exception
            Finally
                conexion.Dispose()
            End Try
        Else
            MessageBox.Show("Debe seleccionar un listado")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buscar1.Click
        Tabla.ReadOnly = True
        Try
            conexion.ConnectionString = Login.cadena
            conexion.Open()
            Dim consulta As String
            consulta = "select * from hist_histpacientes hp inner join hist_histrepre hr on hp.cedula_repre=hr.Cedula "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "hist_histpacientes")
            Tabla.DataSource = datos
            Tabla.DataMember = "hist_histpacientes"
            'ProgressBar1.
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Buscar1.Visible = True
        Buscar2.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Buscar1.Visible = False
        Buscar2.Visible = True

    End Sub

    Private Sub Buscar2_Click(sender As Object, e As EventArgs) Handles Buscar2.Click
        Try
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM hist_histpacientes WHERE Num_historia "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "hist_histpacientes")
            Tabla.DataSource = datos
            Tabla.DataMember = "hist_histpacientes"
            Tabla.Refresh()
            conexion.Close()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub
End Class