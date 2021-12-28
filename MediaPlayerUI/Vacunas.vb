Imports MySql.Data.MySqlClient

Public Class Vacunas
    Dim conexion As New MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim datos As DataSet
    Dim Sql As String
    Private Sub button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()
    End Sub

    Private Sub Vacunas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = Login.cadena
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
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

        Try
            Dim dt As New DataTable
            Dim consulta1 As String
            consulta1 = "SELECT * FROM observaciones WHERE Num_historia ='" + txthistoria.Text + "' "
            Dim comando As New MySqlCommand(consulta1, conexion)
            Dim drd As MySqlDataReader
            conexion.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                Me.Observacion.Text = drd.Item("Obervacion").ToString
            End If
        Catch ex As Exception
        Finally
            conexion.Dispose()
        End Try
        If (Observacion.Text <> "") Then
            Observacionn.Enabled = False
            Modificar.Enabled = True
        Else
            Observacionn.Enabled = True
            Modificar.Enabled = False
        End If

    End Sub

    Private Sub BCG_Click(sender As Object, e As EventArgs) Handles BCG.Click
        Dim vacuna As String
        vacuna = "BCG"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + bcgdosis.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + bcgdosis.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + bcgfecha.Text + "','" + bcgdosis.Text + "','" + bcgedad.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    bcgfecha.Clear()
                    bcgdosis.Text = ""
                    bcgedad.Clear()
                    Groupbcg.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()
        End If
    End Sub

    Private Sub Polio_Click(sender As Object, e As EventArgs) Handles Polio.Click
        Dim vacuna As String
        vacuna = "Polio"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosispolio.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosispolio.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + fechapolio.Text + "','" + dosispolio.Text + "','" + edadpolio.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechapolio.Clear()
                    dosispolio.Text = ""
                    edadpolio.Clear()
                    Grouppolio.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()

        End If
    End Sub

    Private Sub Penta_Click(sender As Object, e As EventArgs) Handles Penta.Click
        Dim vacuna As String
        vacuna = "Pentavalente"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosisdifte.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosisdifte.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + fechadifte.Text + "','" + dosisdifte.Text + "','" + edaddifte.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechadifte.Clear()
                    dosisdifte.Text = ""
                    edaddifte.Clear()
                    Grouppenta.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()
        End If
    End Sub

    Private Sub Rota_Click(sender As Object, e As EventArgs) Handles Rota.Click
        Dim vacuna As String
        vacuna = "Rotavirus"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + rotadosis.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + rotadosis.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + rotafecha.Text + "','" + rotadosis.Text + "','" + rotaedad.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    rotafecha.Clear()
                    rotadosis.Text = ""
                    rotaedad.Clear()
                    Grouprotavirus.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()
        End If
    End Sub

    Private Sub Varicela_Click(sender As Object, e As EventArgs) Handles Varicela.Click
        Dim vacuna As String
        vacuna = "Varicela"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosisvari.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosisvari.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + fechavari.Text + "','" + dosisvari.Text + "','" + edadvari.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechavari.Clear()
                    dosisvari.Text = ""
                    edadvari.Clear()
                    Groupvarice.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()

        End If
    End Sub

    Private Sub Trivalente_Click(sender As Object, e As EventArgs) Handles Trivalente.Click
        Dim vacuna As String
        vacuna = "Trivalente"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosissara.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosissara.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + fechasara.Text + "','" + dosissara.Text + "','" + edadsara.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechasara.Clear()
                    dosissara.Text = ""
                    edadsara.Clear()
                    Groupsaran.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()
        End If
    End Sub

    Private Sub Neumo_Click(sender As Object, e As EventArgs) Handles Neumo.Click
        Dim vacuna As String
        vacuna = "Neumococo"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosisneumo.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosisneumo.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + fechaneumo.Text + "','" + dosisneumo.Text + "','" + edadneu.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechaneumo.Clear()
                    dosisneumo.Text = ""
                    edadneu.Clear()
                    Groupneumo.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()
        End If
    End Sub

    Private Sub Fiebre_Click(sender As Object, e As EventArgs) Handles Fiebre.Click
        Dim vacuna As String
        vacuna = "Fiebre Amarilla"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosisfiebre.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosisdifte.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad,lote) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + txtfiebre.Text + "','" + dosisfiebre.Text + "','" + edadfiebre.Text + "','" + lotefiebre.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    txtfiebre.Clear()
                    dosisfiebre.Text = ""
                    edadfiebre.Clear()
                    lotefiebre.Clear()
                    GroupBfiebre.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()

        End If
    End Sub

    Private Sub Hepatitis_Click(sender As Object, e As EventArgs) Handles Hepatitis.Click
        Dim vacuna As String
        vacuna = "Hepatitis A"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosishepa.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosishepa.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + fechahepa.Text + "','" + dosishepa.Text + "','" + edadhepa.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechahepa.Clear()
                    dosishepa.Text = ""
                    edadhepa.Clear()
                    Grouphepa.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()
        End If
    End Sub

    Private Sub Meningo_Click(sender As Object, e As EventArgs) Handles Meningo.Click
        Dim vacuna As String
        vacuna = "Meningococo"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosismenigo.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosismenigo.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
               '" + txthistoria.Text + "','" + vacuna + "','" + fechameningo.Text + "','" + dosismenigo.Text + "','" + edadmeningo.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechameningo.Clear()
                    dosismenigo.Text = ""
                    edadmeningo.Clear()
                    Groupmaningo.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()

        End If
    End Sub

    Private Sub Influenza_Click(sender As Object, e As EventArgs) Handles Influenza.Click
        Dim vacuna As String
        vacuna = "Influenza"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosisinflue.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosisinflue.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + fechainflue.Text + "','" + dosisinflue.Text + "','" + edadinflue.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechainflue.Clear()
                    dosisinflue.Text = ""
                    edadinflue.Clear()
                    Groupinflue.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()

        End If
    End Sub

    Private Sub Vph_Click(sender As Object, e As EventArgs) Handles Vph.Click
        Dim vacuna As String
        vacuna = "VPH"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + dosisvph.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + dosisvph.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + fechavph.Text + "','" + dosisvph.Text + "','" + edadvhp.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechavph.Clear()
                    dosisvph.Text = ""
                    edadvhp.Clear()
                    Groupvph.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()

        End If
    End Sub

    Private Sub Pesqui_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Observacionn_Click(sender As Object, e As EventArgs) Handles Observacionn.Click
        If (txthistoria.Text <> "" And Observacion.Text <> "") Then
            Try
                Dim guardar As String = "INSERT INTO observaciones (Num_historia,Obervacion) SELECT 
            '" + txthistoria.Text + "','" + Observacion.Text + "'"
                Dim DTx As New DataTable
                Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                ADAPTADOR.Fill(DTx)
                MessageBox.Show("Registrado Correctamente")
                Observacionn.Enabled = False
                conexion.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conexion.Dispose()
            End Try
        Else
            MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub RadioBCG_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBCG.CheckedChanged
        Groupbcg.Visible = True
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub RadioPolio_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPolio.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = True
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub Radiopenta_CheckedChanged(sender As Object, e As EventArgs) Handles Radiopenta.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = True
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub Radiorota_CheckedChanged(sender As Object, e As EventArgs) Handles Radiorota.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = True
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub RadioTriva_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTriva.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = True
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub RadioVaricela_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVaricela.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = True
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub RadioHepa_CheckedChanged(sender As Object, e As EventArgs) Handles RadioHepa.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = True
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub Radioneumo_CheckedChanged(sender As Object, e As EventArgs) Handles Radioneumo.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = True
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub RadioFiebre_CheckedChanged(sender As Object, e As EventArgs) Handles RadioFiebre.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = True
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub Radioinflueza_CheckedChanged(sender As Object, e As EventArgs) Handles Radioinflueza.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = True
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub RadioMeningo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMeningo.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = True
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub RadioVPh_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVPh.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = True
        Grouppezqui.Visible = False
        Groupcovid.Visible = False
    End Sub

    Private Sub RadioPesqui_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPesqui.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = True
        Groupcovid.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registro_vacuna.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub Pesqui_Click_1(sender As Object, e As EventArgs) Handles Pesqui.Click
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM pesquiza WHERE Num_historia = '" + txthistoria.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Pesquisa ya realizada para este Paciente")

        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO pesquiza (Num_historia,fecha) SELECT 
            '" + txthistoria.Text + "','" + fechapesqui.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechapesqui.Clear()
                    Grouppezqui.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()

        End If
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Try
            Dim update As String = "UPDATE observaciones SET Obervacion = '" & Observacion.Text & "'"
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
    End Sub

    Private Sub agregarcovid_Click(sender As Object, e As EventArgs) Handles agregarcovid.Click
        Dim vacuna As String
        vacuna = "COVID-19"
        Dim dt As New DataTable
        Dim consulta1 As String
        consulta1 = "SELECT * FROM vacunas WHERE Num_historia = '" + txthistoria.Text + "' AND nombre = '" + vacuna + "' AND dosis = '" + txtdosiscovid.Text + "' "
        Dim comando As New MySqlCommand(consulta1, conexion)
        Dim drd As MySqlDataReader
        conexion.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then
            MessageBox.Show("Para la vacuna '" + vacuna + "' la dosis '" + txtdosiscovid.Text + "' ya existe en este paciente")
            conexion.Close()
        Else
            drd.Dispose()
            If (txthistoria.Text <> "") Then
                Try
                    Dim guardar As String = "INSERT INTO vacunas (Num_historia,nombre,fecha,dosis,edad) SELECT 
            '" + txthistoria.Text + "','" + vacuna + "','" + txtcovid.Text + "','" + txtdosiscovid.Text + "','" + txtedadcovid.Text + "'"
                    Dim DTx As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(guardar, conexion)
                    ADAPTADOR.Fill(DTx)
                    MessageBox.Show("Registrado Correctamente")
                    fechavph.Clear()
                    dosisvph.Text = ""
                    edadvhp.Clear()
                    Groupvph.Visible = False
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Dispose()
                End Try
            Else
                MessageBox.Show("Debe llenar los campos obligatorios (*)", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            conexion.Close()

        End If
    End Sub

    Private Sub Radiocovid_CheckedChanged(sender As Object, e As EventArgs) Handles Radiocovid.CheckedChanged
        Groupbcg.Visible = False
        Grouppolio.Visible = False
        Grouppenta.Visible = False
        Grouprotavirus.Visible = False
        Groupsaran.Visible = False
        Groupvarice.Visible = False
        Grouphepa.Visible = False
        Groupneumo.Visible = False
        GroupBfiebre.Visible = False
        Groupinflue.Visible = False
        Groupmaningo.Visible = False
        Groupvph.Visible = False
        Grouppezqui.Visible = False
        Groupcovid.Visible = True
    End Sub
End Class