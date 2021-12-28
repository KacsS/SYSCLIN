Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class Login
    Dim cone As MySqlConnection
    Public cadena As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For contador = 90 To 10 Step -10
            Me.Opacity = contador / 100
            Me.Refresh()
            Thread.Sleep(10)
        Next
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'A esta funcion se le paso 2 valores String de la funcion registro sismtea
        If (Registrosistema(txtusuario.Text, txtclave.Text)) Then
            For contador = 90 To 10 Step -10
                Me.Opacity = contador / 100
                Me.Refresh()
                Thread.Sleep(10)
            Next
            Inicio.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Onlywords(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Function Registrosistema(ByVal usuario As String, ByVal clave As String) As Boolean

        'esta funcion crea la conexion y ejecuta el SQL para validar el usuario
        Dim Conexion As New MySqlConnection
        Dim DataAdaptar As MySqlDataAdapter
        Dim Dataset As New DataSet
        Dim Sql As String
        Dim sw As Boolean = False
        Try
            'aqui creo la conexion y ejecuto el SQL
            Conexion.ConnectionString = cadena
            Sql = "SELECT * FROM tbl_user WHERE Usuario = '" & usuario & "'and Clave = '" & clave & "'"
            Conexion.Open()
            DataAdaptar = New MySqlDataAdapter(Sql, Conexion)
            Dataset.Clear()
            DataAdaptar.Fill(Dataset, "tbl_user")
            'valido si dentro de la tabla, en sus columnas existe el usuario
            If (Dataset.Tables("tbl_user").Rows.Count() <> 0) Then
                ' MessageBox.Show("Bienvenido " + usuario + "", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                sw = True
            Else
                MessageBox.Show("Usuario " + usuario + " no registrado verifique sus datos o contacte con su administrador", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtusuario.Clear()
                txtclave.Clear()
            End If

        Catch ex As Exception
        End Try
        Return (sw)
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cadena = "server=localhost;database=sysclin;user id=root;password=070662;"

        'cambias nombre luego de los cambios a ffcbd

    End Sub

    Private Sub txtclave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclave.KeyDown
        If e.KeyCode = "13" Then
            Button1.Focus()

        End If

    End Sub
End Class