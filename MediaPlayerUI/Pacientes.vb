Imports MySql.Data.MySqlClient
Public Class Pacientes
    Dim conexion As New MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim datos As DataSet
    Dim historiax = New TextBox
    Dim nombrex = New TextBox


    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As Historia = CType(Owner, Historia)
        Me.Close()
        frm.Limpiar()
    End Sub

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Tabla.ReadOnly = True
        Try
            conexion.ConnectionString = Login.cadena
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM ficha_prin"
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "ficha_prin")
            Tabla.DataSource = datos
            Tabla.DataMember = "ficha_prin"
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        End Try
    End Sub

    Private Sub Tabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellDoubleClick
        Try

            Dim delete As String = "DELETE FROM paciente_act"

            Dim comando As MySqlCommand
            comando = New MySqlCommand(delete, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try
        Dim frm As Historia = CType(Owner, Historia)
        frm.habilitar()
        frm.txthistoria.Enabled = False
        frm.txthistoria.Text = Tabla.CurrentRow.Cells(0).Value.ToString()
        frm.txtNombre_paci.Text = Tabla.CurrentRow.Cells(1).Value.ToString()
        frm.fecha_naci.Value = Tabla.CurrentRow.Cells(2).Value.ToString()
        frm.txtdomicilio.Text = Tabla.CurrentRow.Cells(3).Value.ToString()
        frm.txtestado.Text = Tabla.CurrentRow.Cells(4).Value.ToString()
        frm.cmbmunicipio.Text = Tabla.CurrentRow.Cells(5).Value.ToString()
        frm.cmbciudad.Text = Tabla.CurrentRow.Cells(6).Value.ToString
        frm.txtsexo.Text = Tabla.CurrentRow.Cells(7).Value.ToString()
        frm.txtedadgesta.Text = Tabla.CurrentRow.Cells(8).Value.ToString()
        frm.txtpeso.Text = Tabla.CurrentRow.Cells(9).Value.ToString()
        frm.txttalla.Text = Tabla.CurrentRow.Cells(10).Value.ToString()
        frm.txtccx.Text = Tabla.CurrentRow.Cells(11).Value.ToString()
        frm.txtparto.Text = Tabla.CurrentRow.Cells(12).Value.ToString()
        frm.txtgesta.Text = Tabla.CurrentRow.Cells(13).Value.ToString()
        frm.txtalimentacion.Text = Tabla.CurrentRow.Cells(14).Value.ToString()
        frm.txtsangre.Text = Tabla.CurrentRow.Cells(15).Value.ToString()
        frm.txtcedula.Text = Tabla.CurrentRow.Cells(16).Value.ToString()
        frm.txtnombre_repre.Text = Tabla.CurrentRow.Cells(17).Value.ToString()
        frm.txtedad_repre.Text = Tabla.CurrentRow.Cells(18).Value.ToString()
        frm.txtparente.Text = Tabla.CurrentRow.Cells(19).Value.ToString()
        frm.txtocupacion.Text = Tabla.CurrentRow.Cells(20).Value.ToString()
        frm.txtmovil.Text = Tabla.CurrentRow.Cells(21).Value.ToString()
        frm.txtlocal.Text = Tabla.CurrentRow.Cells(22).Value.ToString()
        frm.txtcedula2.Text = Tabla.CurrentRow.Cells(23).Value.ToString()
        frm.txtnombre_repre2.Text = Tabla.CurrentRow.Cells(24).Value.ToString()
        frm.txtedad_repre2.Text = Tabla.CurrentRow.Cells(25).Value.ToString()
        frm.txtparente2.Text = Tabla.CurrentRow.Cells(26).Value.ToString()
        frm.txtocupacion2.Text = Tabla.CurrentRow.Cells(27).Value.ToString()
        frm.txtmovil2.Text = Tabla.CurrentRow.Cells(28).Value.ToString
        frm.txtlocal2.Text = Tabla.CurrentRow.Cells(29).Value.ToString()
        frm.Guardar.Enabled = False
        frm.Incluir.Enabled = False
        frm.Modificar.Enabled = True
        frm.Cancelar.Enabled = True
        Me.Close()
        historiax.Text = Tabla.CurrentRow.Cells(0).Value
        nombrex.Text = Tabla.CurrentRow.Cells(1).Value

        Try
            Dim guardar As String = "INSERT INTO paciente_act (Num_historia,Nombre) SELECT '" + historiax.Text + "','" + nombrex.Text + "' "
            Dim DT As New DataTable
            Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
            ADAPTADOR.Fill(DT)
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
        End Try

    End Sub

    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click
        Try

            Dim delete As String = "DELETE FROM paciente_act"
            Dim comando As MySqlCommand
            comando = New MySqlCommand(delete, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try
        Dim frm As Historia = CType(Owner, Historia)
        If (Tabla.SelectedRows.Count > 0) Then
            frm.habilitar()
            frm.txthistoria.Enabled = False
            frm.txthistoria.Text = Tabla.CurrentRow.Cells(0).Value.ToString()
            frm.txtNombre_paci.Text = Tabla.CurrentRow.Cells(1).Value.ToString()
            frm.fecha_naci.Value = Tabla.CurrentRow.Cells(2).Value.ToString()
            frm.txtdomicilio.Text = Tabla.CurrentRow.Cells(3).Value.ToString()
            frm.txtestado.Text = Tabla.CurrentRow.Cells(4).Value.ToString()
            frm.cmbmunicipio.Text = Tabla.CurrentRow.Cells(5).Value.ToString()
            frm.cmbciudad.Text = Tabla.CurrentRow.Cells(6).Value.ToString
            frm.txtsexo.Text = Tabla.CurrentRow.Cells(7).Value.ToString()
            frm.txtedadgesta.Text = Tabla.CurrentRow.Cells(8).Value.ToString()
            frm.txtpeso.Text = Tabla.CurrentRow.Cells(9).Value.ToString()
            frm.txttalla.Text = Tabla.CurrentRow.Cells(10).Value.ToString()
            frm.txtccx.Text = Tabla.CurrentRow.Cells(11).Value.ToString()
            frm.txtparto.Text = Tabla.CurrentRow.Cells(12).Value.ToString()
            frm.txtgesta.Text = Tabla.CurrentRow.Cells(13).Value.ToString()
            frm.txtalimentacion.Text = Tabla.CurrentRow.Cells(14).Value.ToString()
            frm.txtsangre.Text = Tabla.CurrentRow.Cells(15).Value.ToString()
            frm.txtcedula.Text = Tabla.CurrentRow.Cells(16).Value.ToString()
            frm.txtnombre_repre.Text = Tabla.CurrentRow.Cells(17).Value.ToString()
            frm.txtedad_repre.Text = Tabla.CurrentRow.Cells(18).Value.ToString()
            frm.txtparente.Text = Tabla.CurrentRow.Cells(19).Value.ToString()
            frm.txtocupacion.Text = Tabla.CurrentRow.Cells(20).Value.ToString()
            frm.txtmovil.Text = Tabla.CurrentRow.Cells(21).Value.ToString()
            frm.txtlocal.Text = Tabla.CurrentRow.Cells(22).Value.ToString()
            frm.txtcedula2.Text = Tabla.CurrentRow.Cells(23).Value.ToString()
            frm.txtnombre_repre2.Text = Tabla.CurrentRow.Cells(24).Value.ToString()
            frm.txtedad_repre2.Text = Tabla.CurrentRow.Cells(25).Value.ToString()
            frm.txtparente2.Text = Tabla.CurrentRow.Cells(26).Value.ToString()
            frm.txtocupacion2.Text = Tabla.CurrentRow.Cells(27).Value.ToString()
            frm.txtmovil2.Text = Tabla.CurrentRow.Cells(28).Value.ToString
            frm.txtlocal2.Text = Tabla.CurrentRow.Cells(29).Value.ToString()
            frm.Guardar.Enabled = False
            frm.Incluir.Enabled = False
            frm.Modificar.Enabled = True
            frm.Cancelar.Enabled = True
            Me.Close()
            historiax.Text = Tabla.CurrentRow.Cells(0).Value
            nombrex.Text = Tabla.CurrentRow.Cells(1).Value
            Try
                Dim guardar As String = "INSERT INTO paciente_act (Num_historia,Nombre) SELECT '" + historiax.Text + "','" + nombrex.Text + "' "
                Dim DT As New DataTable
                Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                ADAPTADOR.Fill(DT)
                conexion.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conexion.Dispose()
            End Try
        Else
            MessageBox.Show("Debe Seleccionar una fila")
        End If

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged

        Try
            conexion.ConnectionString = Login.cadena
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "select * from ficha_prin hp WHERE hp.Num_historia LIKE '%" & txtbuscar.Text & "%' or hp.Nombre_paciente LIKE '%" & txtbuscar.Text & "%' or hp.Cedu_repre LIKE '%" & txtbuscar.Text & "%' or hp.Nombre_repre LIKE '%" & txtbuscar.Text & "%' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "ficha_prin")
            Tabla.DataSource = datos
            Tabla.DataMember = "ficha_prin"
            Tabla.Refresh()
            conexion.Close()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try

    End Sub
End Class