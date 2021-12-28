Imports MySql.Data.MySqlClient

Public Class Historia
    Dim conexion As New MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim datos As DataSet
    Private Recibe As TextBox

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Historia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = Login.cadena
        txtdomicilio.MaxLength = 126
        fecha.Text = ""
        Motivo.txthistoriaa.Text = txthistoria.Text
        Motivo.txtnombre.Text = txtNombre_paci.Text
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

            End If
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try

        Try
            Dim dt As New DataTable
            Dim consulta1 As String
            consulta1 = "SELECT * FROM ficha_prin WHERE Num_historia = '" + txthistoria.Text + "' "
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                Me.txtNombre_paci.Text = drd.Item("Nombre_paciente").ToString
                Me.fecha_naci.Value = drd.Item("Fecha_naci").ToString
                Me.txtdomicilio.Text = drd.Item("Domicilio").ToString
                Me.txtestado.Text = drd.Item("Estado").ToString
                Me.cmbciudad.Text = drd.Item("Ciudad").ToString
                Me.cmbmunicipio.Text = drd.Item("Municipio").ToString
                Me.txtsexo.Text = drd.Item("Sexo").ToString
                Me.txtedadgesta.Text = drd.Item("Edad_gesti").ToString
                Me.txtpeso.Text = drd.Item("peso").ToString
                Me.txttalla.Text = drd.Item("talla").ToString
                Me.txtccx.Text = drd.Item("CC").ToString
                Me.txtparto.Text = drd.Item("Parto").ToString
                Me.txtgesta.Text = drd.Item("gesta").ToString
                Me.txtalimentacion.Text = drd.Item("Alimentacion").ToString
                Me.txtsangre.Text = drd.Item("Sangre").ToString

                Me.txtcedula.Text = drd.Item("Cedu_repre").ToString
                Me.txtnombre_repre.Text = drd.Item("Nombre_repre").ToString
                Me.txtedad_repre.Text = drd.Item("edad_repre").ToString
                Me.txtparente.Text = drd.Item("Parenteso").ToString
                Me.txtocupacion.Text = drd.Item("ocupacion").ToString
                Me.txtmovil.Text = drd.Item("tlfmovil").ToString
                Me.txtlocal.Text = drd.Item("tlflocal").ToString

                Me.txtcedula2.Text = drd.Item("cedula_repre2").ToString
                Me.txtnombre_repre2.Text = drd.Item("Nompre_repre2").ToString
                Me.txtedad_repre2.Text = drd.Item("edad_repre2").ToString
                Me.txtparente2.Text = drd.Item("parente2").ToString
                Me.txtocupacion2.Text = drd.Item("ocupacion2").ToString
                Me.txtmovil2.Text = drd.Item("tlfmovil2").ToString
                Me.txtlocal2.Text = drd.Item("tlflocal2").ToString
            End If
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try


        If (txthistoria.Text <> "") Then
            Modificar.Enabled = True
            Guardar.Enabled = False
        Else
            Modificar.Enabled = False
            Guardar.Enabled = True
        End If



    End Sub

    Private Sub Fecha_naci_ValueChanged(sender As Object, e As EventArgs) Handles fecha_naci.ValueChanged
        Dim dia As Integer
        Dim mes As Integer
        Dim año As Integer
        Dim diaedad As Integer
        Dim mesedad As Integer
        Dim añoedad As Integer
        dia = DateTime.Now.Day
        mes = DateTime.Now.Month
        año = DateTime.Now.Year
        Dim fechax = fecha_naci.ToString
        diaedad = fecha_naci.Value.Day - dia
        mesedad = fecha_naci.Value.Month - mes
        añoedad = año - fecha_naci.Value.Year
        If (fecha_naci.Value.Day < dia) Then
            diaedad = -diaedad
            fecha.Text = "" + añoedad.ToString + " Años " + mesedad.ToString + " Meses " + diaedad.ToString + " Dias"
        End If
        If (fecha_naci.Value.Month < mes) Then
            mesedad = -mesedad
            fecha.Text = "" + añoedad.ToString + " Años " + mesedad.ToString + " Meses " + diaedad.ToString + " Dias"
        End If
        If (fecha_naci.Value.Year > año) Then
            MessageBox.Show("Año incorrecto no puede sobre pasar el actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            fecha.Text = ""
        Else
            fecha.Text = "" + añoedad.ToString + " Años " + mesedad.ToString + " Meses " + diaedad.ToString + " Dias"
        End If

    End Sub

    Private Sub Validation_id(sender As Object, e As KeyPressEventArgs) Handles txtcedula.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Valiadtion_age(sender As Object, e As KeyPressEventArgs) Handles txtedad_repre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Validapeso(sender As Object, e As KeyPressEventArgs) Handles txtpeso.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Validatalla(sender As Object, e As KeyPressEventArgs) Handles txttalla.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Validacc(sender As Object, e As KeyPressEventArgs) Handles txtccx.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtestado.SelectedIndexChanged

        Try
            Dim Dt As New DataTable

            Dim adapter As MySqlDataAdapter


            Dim consulta As String

            consulta = "SELECT Ciudad FROM estado WHERE Estado = '" + txtestado.Text + "'" + " order By Ciudad "

            adapter = New MySqlDataAdapter(consulta, conexion)

            adapter.Fill(Dt)

            cmbciudad.DataSource = Dt
            cmbciudad.DisplayMember = "Ciudad"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

    End Sub



    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim frm As New Pacientes
        AddOwnedForm(frm)
        frm.ShowDialog()

    End Sub




    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Limpiar()
    End Sub

    Private Sub Modificar_Click_1(sender As Object, e As EventArgs) Handles Modificar.Click
        Try
            Dim update As String = "UPDATE ficha_prin SET Nombre_paciente = '" & txtNombre_paci.Text & "', 
            Fecha_naci ='" & fecha_naci.Text & "', Domicilio = '" & txtdomicilio.Text & "', Estado = '" & txtestado.Text & "', Ciudad = '" & cmbciudad.Text & "', Municipio = '" & cmbmunicipio.Text & "', 
            Sexo = '" & txtsexo.Text & "', Edad_gesti = '" & txtedadgesta.Text & "', peso = '" & txtpeso.Text & "', talla = '" & txttalla.Text & "',
            CC = '" & txtccx.Text & "', Parto = '" & txtparto.Text & "', gesta = '" & txtgesta.Text & "', Alimentacion = '" & txtalimentacion.Text & "', 
            Sangre = '" & txtsangre.Text & "', Cedu_repre = '" & txtcedula.Text & "', Nombre_repre = '" & txtnombre_repre.Text & "', 
            edad_repre = '" & txtedad_repre.Text & "', Parenteso = '" & txtparente.Text & "', ocupacion = '" & txtocupacion.Text & "',
            tlfmovil = '" & txtmovil.Text & "', tlflocal = '" & txtlocal.Text & "', cedula_repre2 = '" & txtcedula2.Text & "',
            Nompre_repre2 = '" & txtnombre_repre2.Text & "', edad_repre2 = '" & txtedad_repre2.Text & "',parente2 = '" & txtparente2.Text & "',
            ocupacion2 = '" & txtocupacion2.Text & "',tlfmovil2 = '" & txtmovil2.Text & "',tlflocal2 = '" & txtlocal2.Text & "' WHERE Num_historia = '" & txthistoria.Text & "'"
            conexion.Open()
            Dim comando As MySqlCommand
            comando = New MySqlCommand(update, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Modificado Correctamente")

            conexion.Close()
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub Guardar_Click_1(sender As Object, e As EventArgs) Handles Guardar.Click
        Try
            Dim DataAdaptar As MySqlDataAdapter
            Dim Dataset As New DataSet
            Dim Sql As String
            Dim sw As Boolean = False
            Sql = "SELECT * FROM ficha_prin WHERE Num_historia = '" & txthistoria.Text & "'"
            conexion.Open()
            DataAdaptar = New MySqlDataAdapter(Sql, conexion)
            Dataset.Clear()
            DataAdaptar.Fill(Dataset, "ficha_prin")
            If (Dataset.Tables("ficha_prin").Rows.Count() <> 0) Then
                MessageBox.Show("El numero de Historia ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sw = True
            Else
                If txtcedula.Text <> "" And txthistoria.Text <> "" Then
                    Try
                        Dim guardar As String = "INSERT INTO ficha_prin (Num_historia,Nombre_paciente,Fecha_naci,Domicilio,Estado,Municipio,Ciudad,Sexo,Edad_gesti,peso,talla,CC,Parto,gesta,Alimentacion,Sangre,Cedu_repre,Nombre_repre,edad_repre,Parenteso,ocupacion,tlfmovil,tlflocal,cedula_repre2,Nompre_repre2,edad_repre2,parente2,ocupacion2,tlfmovil2,tlflocal2) SELECT 
            '" + txthistoria.Text + "','" + txtNombre_paci.Text + "','" + fecha_naci.Text + "','" + txtdomicilio.Text + "','" + txtestado.Text + "','" + cmbmunicipio.Text + "','" + "','" + cmbciudad.Text + "','" + txtsexo.Text + "','" + txtedadgesta.Text + "'
            ,'" + txtpeso.Text + "','" + txttalla.Text + "','" + txtccx.Text + "','" + txtparto.Text + "','" + txtgesta.Text + "','" + txtalimentacion.Text + "','" + txtsangre.Text + "','" + txtcedula.Text + "'
            ,'" + txtnombre_repre.Text + "','" + txtedad_repre.Text + "','" + txtparente.Text + "','" + txtocupacion.Text + "' ,'" + txtmovil.Text + "','" + txtlocal.Text + "','" + txtcedula2.Text + "','" + txtnombre_repre2.Text + "' 
            ,'" + txtedad_repre2.Text + "','" + txtparente2.Text + "','" + txtocupacion2.Text + "','" + txtmovil2.Text + "','" + txtlocal2.Text + "'"
                        Dim DT As New DataTable
                        Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                        ADAPTADOR.Fill(DT)
                        MessageBox.Show("Registrado Correctamente")
                        conexion.Close()
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
            Limpiar()
        Catch ex As Exception
        Finally
            'conexion.Dispose()
        End Try

    End Sub

    Private Sub Incluir_Click_1(sender As Object, e As EventArgs) Handles Incluir.Click
        Buscar.Enabled = False
        Guardar.Enabled = True
        habilitar()


    End Sub


    Public Sub Limpiar()
        txthistoria.Clear()
        txtNombre_paci.Clear()
        txtdomicilio.Clear()
        txtestado.Text = ""
        cmbciudad.Text = ""
        cmbmunicipio.Text = ""
        txtsexo.Text = ""
        txtedadgesta.Text = ""
        txtpeso.Clear()
        txttalla.Clear()
        txtccx.Clear()
        txtparto.Clear()
        txtgesta.Text = ""
        txtalimentacion.Text = ""
        txtsangre.Text = ""
        txtcedula.Clear()
        txtcedula2.Text = ""
        txtedad_repre.Text = ""
        txtedad_repre2.Text = ""
        txtmovil.Text = ""
        txtmovil2.Text = ""
        txtlocal.Text = ""
        txtlocal2.Text = ""
        txtocupacion.Text = ""
        txtocupacion2.Text = ""
        txtnombre_repre2.Text = ""
        txtparente2.Text = ""
        txtnombre_repre.Clear()
        txtedad_repre.Clear()
        txtparente.Text = ""
        fecha_naci.ResetText()
        Buscar.Enabled = True
        Guardar.Enabled = False
        Modificar.Enabled = False
        Incluir.Enabled = True

        'Inhabilita Incluir Datos'

        txthistoria.Enabled = False
        txtNombre_paci.Enabled = False
        txtdomicilio.Enabled = False
        txtestado.Enabled = False
        cmbciudad.Enabled = False
        cmbmunicipio.Enabled = False
        txtsexo.Enabled = False
        txtedadgesta.Enabled = False
        txtpeso.Enabled = False
        txttalla.Enabled = False
        txtccx.Enabled = False
        txtparto.Enabled = False
        txtgesta.Enabled = False
        txtalimentacion.Enabled = False
        txtsangre.Enabled = False
        txtcedula.Enabled = False
        txtnombre_repre.Enabled = False
        txtedad_repre.Enabled = False
        txtparente.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        fecha_naci.ResetText()
        fecha_naci.Enabled = False
        Guardar.Enabled = False
        Cancelar.Enabled = False

        Try
            Dim delete As String = "DELETE FROM paciente_act"
            conexion.Open()
            Dim comando As MySqlCommand
            comando = New MySqlCommand(delete, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try

    End Sub


    Public Sub habilitar()
        txthistoria.Enabled = True
        txtNombre_paci.Enabled = True
        txtdomicilio.Enabled = True
        txtestado.Enabled = True
        cmbciudad.Enabled = True
        cmbmunicipio.Enabled = True
        txtsexo.Enabled = True
        txtedadgesta.Enabled = True
        txtpeso.Enabled = True
        txttalla.Enabled = True
        txtccx.Enabled = True
        txtparto.Enabled = True
        txtgesta.Enabled = True
        txtalimentacion.Enabled = True
        txtsangre.Enabled = True
        txtcedula.Enabled = True
        txtnombre_repre.Enabled = True
        txtedad_repre.Enabled = True
        txtparente.Enabled = True
        txtocupacion.Enabled = True
        txtocupacion2.Enabled = True
        txtmovil.Enabled = True
        txtmovil2.Enabled = True
        txtlocal.Enabled = True
        txtlocal2.Enabled = True
        txtcedula2.Enabled = True
        txtnombre_repre2.Enabled = True
        txtedad_repre2.Enabled = True
        txtparente2.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        fecha_naci.ResetText()
        fecha_naci.Enabled = True
        Cancelar.Enabled = True

    End Sub

    Private Sub cmbmunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmunicipio.SelectedIndexChanged


    End Sub

    Private Sub cmbciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbciudad.SelectedIndexChanged
        Try
            Dim Dt As New DataTable

            Dim adapter As MySqlDataAdapter


            Dim consulta As String

            consulta = "SELECT Municipio FROM estado WHERE Estado = '" + txtestado.Text + "'" + "and Ciudad='" + cmbciudad.Text + "'" + " Order By Municipio"

            adapter = New MySqlDataAdapter(consulta, conexion)

            adapter.Fill(Dt)

            cmbmunicipio.DataSource = Dt
            cmbmunicipio.DisplayMember = "Municipio"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()
    End Sub
End Class
