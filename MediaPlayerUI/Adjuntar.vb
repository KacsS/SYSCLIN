Imports MySql.Data.MySqlClient

Public Class form
    Dim conexion As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Add.Click
        Try
            With OpenFileDialog1
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "jpg"
                .DereferenceLinks = True
                .FileName = ""
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
                .Multiselect = False
                .RestoreDirectory = True
                .Title = "Seleccione la imagen o archivo"
                .ValidateNames = True
                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If (PictureBox1.Image Is Nothing) Then
            MessageBox.Show("Debe Seleccionar una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conexion.ConnectionString = Login.cadena
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim result As Integer
            Dim caption As String
            Dim arrImage() As Byte
            Dim Num_historia As String
            Dim fecha As String
            Dim mstream As New System.IO.MemoryStream()
            caption = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Num_historia = txthitoria.Text
            fecha = txtfecha.Text
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            Try
                conexion.Open()
                sql = "INSERT INTO  `documentos` (`Num_historia`,`fecha`,`Caption`, `ImageFile`) VALUES (@Num_historia, @fecha, @Caption, @ImageFile)"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conexion
                    .CommandText = sql
                    .Parameters.AddWithValue("Num_historia", Num_historia)
                    .Parameters.AddWithValue("fecha", fecha)
                    .Parameters.AddWithValue("@Caption", caption)
                    .Parameters.AddWithValue("@ImageFile", arrImage)
                    result = .ExecuteNonQuery()
                End With
                If result > 0 Then
                    MsgBox("Imagen agregada Correctamente")

                Else
                    MsgBox("Error al agregar", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conexion.Close()
            End Try
        End If

    End Sub

    Private Sub Clean_Click(sender As Object, e As EventArgs) Handles Clean.Click
        PictureBox1.Image = Nothing
    End Sub
End Class