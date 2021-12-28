Imports MySql.Data.MySqlClient

Public Class Motivo
    Dim conexion As New MySqlConnection
    Dim x As New TextBox
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Motivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Agregar.Enabled = False
        Modificar.Enabled = False
        Tabla.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black
        txtfecha.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim dt As New DataTable
        conexion.ConnectionString = Login.cadena
        Try
            Dim consulta1 As String
            consulta1 = "SELECT * FROM paciente_act "
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                Me.txthistoriaa.Text = drd.Item("Num_historia").ToString
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
            consulta = "SELECT * FROM motivo WHERE Num_historia ='" + txthistoriaa.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "motivo")
            Tabla.DataSource = datos
            Tabla.DataMember = "motivo"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try

    End Sub

    Private Sub Tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellClick
        x.Text = Tabla.CurrentRow.Cells(0).Value.ToString
        txthistoriaa.Text = Tabla.CurrentRow.Cells(1).Value
        txtnombre.Text = Tabla.CurrentRow.Cells(2).Value
        txtfecha.Text = Tabla.CurrentRow.Cells(3).Value
        txtpeso.Text = Tabla.CurrentRow.Cells(4).Value
        txttalla.Text = Tabla.CurrentRow.Cells(5).Value
        txtimc.Text = Tabla.CurrentRow.Cells(6).Value
        txtcc.Text = Tabla.CurrentRow.Cells(7).Value
        txtta.Text = Tabla.CurrentRow.Cells(8).Value
        txtte.Text = Tabla.CurrentRow.Cells(9).Value
        txtpe.Text = Tabla.CurrentRow.Cells(10).Value
        txtpt.Text = Tabla.CurrentRow.Cells(11).Value
        txtenfer.Text = Tabla.CurrentRow.Cells(12).Value
        txtdescri.Text = Tabla.CurrentRow.Cells(13).Value
        Modificar.Enabled = True
        Agregar.Enabled = False
    End Sub

    Private Sub txtfechabusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtfechabusqueda.TextChanged
        Try
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM motivo WHERE Num_historia ='" + txthistoriaa.Text + "' AND fecha LIKE '%" + txtfechabusqueda.Text + "%' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "motivo")
            Tabla.DataSource = datos
            Tabla.DataMember = "motivo"
            Tabla.Refresh()
            conexion.Close()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            Tabla.ReadOnly = True
            Dim adapter As MySqlDataAdapter
            Dim datos As DataSet
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM motivo WHERE Num_historia ='" + txthistoriaa.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "motivo")
            Tabla.DataSource = datos
            Tabla.DataMember = "motivo"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
        txtfechabusqueda.Clear()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        txtpeso.Enabled = True
        txttalla.Enabled = True
        txtimc.Enabled = True
        txtcc.Enabled = True
        txtta.Enabled = True
        txtte.Enabled = True
        txtpe.Enabled = True
        txtpt.Enabled = True
        txtenfer.Enabled = True
        txtdescri.Enabled = True
        txtfechabusqueda.Enabled = True
        Buscar.Enabled = True
        Nuevo.Enabled = False
        Tabla.Visible = True
        Agregar.Enabled = True
        txtfecha.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)


    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        txtpeso.Enabled = False
        txttalla.Enabled = False
        txtimc.Enabled = False
        txtcc.Enabled = False
        txtta.Enabled = False
        txtte.Enabled = False
        txtpe.Enabled = False
        txtpt.Enabled = False
        txtenfer.Enabled = False
        txtdescri.Enabled = False
        txtfechabusqueda.Enabled = False
        Buscar.Enabled = False
        Tabla.Visible = False
        Nuevo.Enabled = True
        ''''''''''''''''''''''''''''''
        txtpeso.Clear()
        txttalla.Clear()
        txtimc.Clear()
        txtcc.Clear()
        txtta.Clear()
        txtte.Clear()
        txtpe.Clear()
        txtpt.Clear()
        txtenfer.Clear()
        txtdescri.Clear()
        txtfechabusqueda.Clear()
        txtfecha.ResetText()
        Nuevo.Enabled = True
        Agregar.Enabled = False
        Modificar.Enabled = False
        txtfecha.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

    End Sub

    Private Sub Agregar_Click_1(sender As Object, e As EventArgs) Handles Agregar.Click
        If (txtpeso.Text <> "" And txttalla.Text <> "" And txtenfer.Text <> "" And txtdescri.Text <> "") Then
            Try
                Dim guardar As String = "INSERT INTO motivo (Num_historia,Nombre,fecha,peso,talla,IMC,CC,TA,TE,PE,PT,Enfermedad,Descripcion) SELECT '" + txthistoriaa.Text + "','" + txtnombre.Text + "',
            '" + txtfecha.Text + "','" + txtpeso.Text + "','" + txttalla.Text + "','" + txtimc.Text + "','" + txtcc.Text + "','" + txtta.Text + "','" + txtte.Text + "','" + txtpe.Text + "','" + txtpt.Text + "',
            '" + txtenfer.Text + "','" + txtdescri.Text + "' "
                Dim DT As New DataTable
                Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                ADAPTADOR.Fill(DT)
                MessageBox.Show("Registrado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpeso.Clear()
                txttalla.Clear()
                txtimc.Clear()
                txtcc.Clear()
                txtta.Clear()
                txtte.Clear()
                txtpe.Clear()
                txtpt.Clear()
                txtenfer.Clear()
                txtdescri.Clear()
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
                consulta = "SELECT * FROM motivo WHERE Num_historia ='" + txthistoriaa.Text + "' "
                adapter = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adapter.Fill(datos, "motivo")
                Tabla.DataSource = datos
                Tabla.DataMember = "motivo"
                conexion.Close()
                Show()
            Catch ex As Exception
            Finally
                conexion.Dispose()
            End Try
        Else
            MessageBox.Show("Debe llenar los campo olbigarorios (*) ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Modificar_Click_1(sender As Object, e As EventArgs) Handles Modificar.Click

        Try
            Dim update As String = "UPDATE motivo SET peso = '" & txtpeso.Text & "', talla = '" & txttalla.Text & "', 
            CC ='" & txtcc.Text & "', TA ='" & txtta.Text & "',TE ='" & txtte.Text & "',PE ='" & txtpe.Text & "', 
            PT ='" & txtpt.Text & "',Enfermedad = '" & txtenfer.Text & "', Descripcion = '" & txtdescri.Text & "' WHERE ID = " & x.Text & " "
            conexion.Open()
            Dim comando As MySqlCommand
            comando = New MySqlCommand(update, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Modificado Correctamente")
            txtpeso.Clear()
            txttalla.Clear()
            txtimc.Clear()
            txtcc.Clear()
            txtta.Clear()
            txtte.Clear()
            txtpe.Clear()
            txtpt.Clear()
            txtenfer.Clear()
            txtdescri.Clear()
            conexion.Close()
            Agregar.Enabled = False
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
            consulta = "SELECT * FROM motivo WHERE Num_historia ='" + txthistoriaa.Text + "' "
            adapter = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adapter.Fill(datos, "motivo")
            Tabla.DataSource = datos
            Tabla.DataMember = "motivo"
            conexion.Close()
            Show()
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub txtpeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttalla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttalla.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtimc_Leave(sender As Object, e As EventArgs) Handles txtimc.Leave
        If (txtpeso.Text <> "" And txtta.Text <> "") Then
            txtimc.Text = CDbl(txtpeso.Text) / (CDbl(txttalla.Text * txttalla.Text))
        Else
            MessageBox.Show("Debe registrar el Peso y la Talla", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
End Class