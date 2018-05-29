Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text.pdf
Public Class Form2
    Private searchIndex As Integer = -1
    'this is the start if load'
    Private Sub Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilDatabarang()
    End Sub
    Private Sub Pekerja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilDatapekerja()
    End Sub
    Private Sub Gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilGaji()
    End Sub
    'this is the end of load'
    'this is the start of bersihkan'
    Sub bersihkan()
        txtKdbarang.Text = ""
        txtBarang.Text = ""
        txtJbarang.Text = ""
        txtJumlah.Text = ""
        txtCatatan.Text = ""
    End Sub
    Sub bersihkan2()
        txtKdpekerja.Text = ""
        txtNamapekerja.Text = ""
        txtNoktp.Text = ""
        txtAnak.Text = ""
        txtIstri.Text = ""
        txtLainya.Text = ""
    End Sub
    Sub bersihkan3()
        txtKdgaji.Text = ""
        txtNamapekerja2.Text = ""
        txtKehadiran.Text = ""
        txtTotal.Text = ""
    End Sub
    'this is the end of bersihkan'
    'this the start if tampil query'
    Sub tampilDatabarang()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select * from databarang order by kd_barang Asc", conn)
            ds = New DataSet
            da.Fill(ds, "databarang")
            dgvDataBarang.DataSource = ds.Tables("databarang")
        Catch ex As Exception

        End Try
    End Sub
    Sub tampilDatapekerja()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select * from datapekerja order by kd_pekerja Asc", conn)
            ds = New DataSet
            da.Fill(ds, "datapekerja")
            dgvDatapekerja.DataSource = ds.Tables("datapekerja")
        Catch ex As Exception

        End Try
    End Sub
    Sub tampilGaji()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select * from datagaji order by kd_gaji Asc", conn)
            ds = New DataSet
            da.Fill(ds, "datagaji")
            dgvGaji.DataSource = ds.Tables("datagaji")
        Catch ex As Exception

        End Try
    End Sub
    'this is the end of tampil query'
    'this the start of simpan query'
    Sub simpanBarang()
        Try
            Call koneksi()
            Dim str As String
            str = "insert into databarang ( kd_barang, namabarang, jenisbarang, jumlah, catatan) values ('" & txtKdbarang.Text & "','" & txtBarang.Text & "','" & txtJbarang.Text & "','" & txtJumlah.Text & "', '" & txtCatatan.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Barang Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Insert Data Barang Gagal Dilakukan" + ex.Message, "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub
    Sub simpanPekerja()
        Try
            Call koneksi()
            Dim str As String
            str = "insert into datapekerja ( kd_pekerja, namapekerja, noktp, anak, istri, lainya) values ('" & txtKdpekerja.Text & "','" & txtNamapekerja.Text & "','" & txtNoktp.Text & "', '" & txtAnak.Text & "', '" & txtIstri.Text & "', '" & txtLainya.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Pekerja Lapangan Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Insert Data Pekerja Lapangan Gagal Dilakukan" + ex.Message, "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub
    Sub simpanGajiPekerja()
        Try
            Call koneksi()
            Dim str As String
            str = "insert into datagaji ( kd_gaji, namapekerja) values ('" & txtKdpekerja.Text & "','" & txtNamapekerja.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()


        Catch ex As Exception

        End Try
    End Sub
    'this is the end of simpan query'
    'this is the start of barang query'
    Sub ubahBarang()
        Try
            Call koneksi()
            Dim str As String
            str = "update databarang set namabarang = '" & txtBarang.Text & "', jenisbarang = '" & txtJbarang.Text & "', jumlah = '" & txtJumlah.Text & "', catatan = '" & txtCatatan.Text & "' where kd_barang =  '" & txtKdbarang.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Barang Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ubah Data Barang Gagal Dilakukan" + ex.Message, "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub
    Sub ubahPekerja()
        Try
            Call koneksi()
            Dim str As String
            str = "update datapekerja set namapekerja = '" & txtNamapekerja.Text & "', noktp = '" & txtNoktp.Text & "', anak = '" & txtAnak.Text & "', istri = '" & txtIstri.Text & "', lainya = '" & txtLainya.Text & "' where kd_pekerja =  '" & txtKdpekerja.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Pekerja Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ubah Data Pekerja Gagal Dilakukan" + ex.Message, "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub
    Sub ubahGaji()
        Try
            Call koneksi()
            Dim str As String
            str = "update datagaji set  kehadiran = '" & txtKehadiran.Text & "', total = '" & txtTotal.Text & "' where kd_gaji =  '" & txtKdgaji.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Gaji Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Input Data Gaji Gagal Dilakukan" + ex.Message, "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub
    'this is the end of barang query'
    'this is the start hapus query'
    Sub hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from databarang where kd_barang='" & txtKdbarang.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Barang Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data Barang Gagal Dihapus" + ex.Message, "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub
    Sub hapus2()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from datapekerja where kd_pekerja='" & txtKdpekerja.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Pekerja Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data Pekerja Gagal Dihapus" + ex.Message, "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub
    'this is the end of hapus query'
    'this is the start of button function on barang'
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If MessageBox.Show("Yakin ingin menyimpan data barang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call simpanBarang()
            Call bersihkan()
            Call tampilDatabarang()
        End If
    End Sub
    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If MessageBox.Show("Yakin ingin mengubah data barang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call ubahBarang()
            Call bersihkan()
            Call tampilDatabarang()
        End If
    End Sub
    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Yakin ingin menghapus data barang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call hapus()
            Call bersihkan()
            Call tampilDatabarang()
        End If
    End Sub
    Private Sub dgvDatabarang_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDataBarang.CellMouseClick
        Try
            txtKdbarang.Text = dgvDataBarang.Rows(e.RowIndex).Cells(0).Value
            txtBarang.Text = dgvDataBarang.Rows(e.RowIndex).Cells(1).Value
            txtJbarang.Text = dgvDataBarang.Rows(e.RowIndex).Cells(2).Value
            txtJumlah.Text = dgvDataBarang.Rows(e.RowIndex).Cells(3).Value
            txtCatatan.Text = dgvDataBarang.Rows(e.RowIndex).Cells(4).Value

        Catch ex As Exception

        End Try
    End Sub
    'this is the end for all of barang button and another function'
    'this is the start of pekerja section'
    Private Sub btnSimpan2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan2.Click
        If MessageBox.Show("Yakin ingin menyimpan data pekerja?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call simpanPekerja()
            Call simpanGajiPekerja()
            Call bersihkan2()
            Call tampilDatapekerja()
            Call tampilGaji()
        End If
    End Sub
    Private Sub btnEdit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit2.Click
        If MessageBox.Show("Yakin ingin mengubah pekerja?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call ubahPekerja()
            Call bersihkan2()
            Call tampilDatapekerja()
        End If
    End Sub
    Private Sub btnHapus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete2.Click
        If MessageBox.Show("Yakin ingin menghapus data pekerja?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call hapus2()
            Call bersihkan2()
            Call tampilDatapekerja()
        End If
    End Sub
    Private Sub dgvDatapekerja_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDatapekerja.CellMouseClick
        Try
            txtKdpekerja.Text = dgvDatapekerja.Rows(e.RowIndex).Cells(0).Value
            txtNamapekerja.Text = dgvDatapekerja.Rows(e.RowIndex).Cells(1).Value
            txtNoktp.Text = dgvDatapekerja.Rows(e.RowIndex).Cells(2).Value
            txtAnak.Text = dgvDatapekerja.Rows(e.RowIndex).Cells(3).Value
            txtIstri.Text = dgvDatapekerja.Rows(e.RowIndex).Cells(4).Value
            txtLainya.Text = dgvDatapekerja.Rows(e.RowIndex).Cells(5).Value

        Catch ex As Exception

        End Try
    End Sub

    'this is the end for all of barang button and another function'
    'this is the start of gaji '

    Private Sub dgvGaji_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvGaji.CellMouseClick
        Try
            txtKdgaji.Text = dgvGaji.Rows(e.RowIndex).Cells(0).Value
            txtNamapekerja2.Text = dgvGaji.Rows(e.RowIndex).Cells(1).Value
            txtKehadiran.Text = dgvGaji.Rows(e.RowIndex).Cells(2).Value
            txtTotal.Text = dgvGaji.Rows(e.RowIndex).Cells(3).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim JumlahKehadiran, Gaji, Total As Integer

        JumlahKehadiran = txtKehadiran.Text
        Gaji = txtGaji.Text

        Total = Gaji * JumlahKehadiran

        txtTotal.Text = Total
    End Sub

    Private Sub btnInput3_Click(sender As Object, e As EventArgs) Handles btnInput3.Click
        If MessageBox.Show("Yakin ingin mengubah pekerja?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call ubahGaji()
            Call bersihkan3()
            Call tampilGaji()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim tinggi As Integer
        For baris As Integer = 0 To dgvGaji.RowCount - 2
            tinggi += 10
            e.Graphics.DrawString(dgvGaji.Rows(baris).Cells(1).Value.ToString, New Drawing.Font("Arial", 8), Brushes.Black, 4, tinggi)
            e.Graphics.DrawString(dgvGaji.Rows(baris).Cells(2).Value.ToString, New Drawing.Font("Arial", 8), Brushes.Black, 300, tinggi)
            e.Graphics.DrawString(dgvGaji.Rows(baris).Cells(3).Value.ToString, New Drawing.Font("Arial", 8), Brushes.Black, 440, tinggi)

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tinggi As Integer
        With PrintDocument1
            tinggi = 10
            .PrinterSettings.DefaultPageSettings.Landscape = False
            .Print()
        End With
    End Sub

    Private Sub txtCariNama_TextChanged(sender As Object, e As EventArgs) Handles txtCariNama.TextChanged
        searchIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To dgvGaji.Rows.Count - 1
            searchIndex = (searchIndex + 1) Mod dgvGaji.Rows.Count
            Dim row As DataGridViewRow = dgvGaji.Rows(searchIndex)
            If row.Cells("namapekerja").Value Is Nothing Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Info")
                txtCariNama.Focus()
                Continue For
            End If

            If row.Cells("namapekerja").Value.ToString().Trim() = txtCariNama.Text Then
                dgvGaji.CurrentCell = row.Cells("namapekerja")
                dgvGaji.FirstDisplayedScrollingRowIndex = dgvGaji.Rows(row.Index).Index
                Return
            End If
        Next
    End Sub




    'this is the end for all of gaji function'
End Class