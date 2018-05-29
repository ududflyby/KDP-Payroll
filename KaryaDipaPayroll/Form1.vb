Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Yakin Ingin Membatalkan Login?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Call koneksi()
            Dim str As String
            str = "select * from user where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                Me.Visible = True
                Me.Enabled = True
                MessageBox.Show("Anda berhasil login")
                Form2.Visible = True
                Form2.Enabled = True
                Me.Hide()
            Else
                rd.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Text = ""
                txtUsername.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class