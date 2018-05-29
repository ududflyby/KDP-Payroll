<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.s = New System.Windows.Forms.TabPage()
        Me.dgvDataBarang = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.txtJbarang = New System.Windows.Forms.TextBox()
        Me.txtBarang = New System.Windows.Forms.TextBox()
        Me.txtKdbarang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.btnEdit2 = New System.Windows.Forms.Button()
        Me.btnSimpan2 = New System.Windows.Forms.Button()
        Me.dgvDatapekerja = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLainya = New System.Windows.Forms.TextBox()
        Me.txtIstri = New System.Windows.Forms.TextBox()
        Me.txtAnak = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoktp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNamapekerja = New System.Windows.Forms.TextBox()
        Me.txtKdpekerja = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtKdgaji = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtGaji = New System.Windows.Forms.TextBox()
        Me.txtKehadiran = New System.Windows.Forms.TextBox()
        Me.txtNamapekerja2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnInput3 = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.dgvGaji = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCariNama = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.s.SuspendLayout()
        CType(Me.dgvDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDatapekerja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvGaji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.s)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(999, 509)
        Me.TabControl1.TabIndex = 0
        '
        's
        '
        Me.s.Controls.Add(Me.Label22)
        Me.s.Controls.Add(Me.txtJumlah)
        Me.s.Controls.Add(Me.dgvDataBarang)
        Me.s.Controls.Add(Me.btnDelete)
        Me.s.Controls.Add(Me.btnEdit)
        Me.s.Controls.Add(Me.btnInput)
        Me.s.Controls.Add(Me.txtCatatan)
        Me.s.Controls.Add(Me.txtJbarang)
        Me.s.Controls.Add(Me.txtBarang)
        Me.s.Controls.Add(Me.txtKdbarang)
        Me.s.Controls.Add(Me.Label10)
        Me.s.Controls.Add(Me.Label9)
        Me.s.Controls.Add(Me.Label8)
        Me.s.Controls.Add(Me.Label7)
        Me.s.Location = New System.Drawing.Point(4, 25)
        Me.s.Name = "s"
        Me.s.Padding = New System.Windows.Forms.Padding(3)
        Me.s.Size = New System.Drawing.Size(991, 480)
        Me.s.TabIndex = 0
        Me.s.Text = "Data Barang"
        Me.s.UseVisualStyleBackColor = True
        '
        'dgvDataBarang
        '
        Me.dgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataBarang.Location = New System.Drawing.Point(29, 219)
        Me.dgvDataBarang.Name = "dgvDataBarang"
        Me.dgvDataBarang.ReadOnly = True
        Me.dgvDataBarang.RowTemplate.Height = 24
        Me.dgvDataBarang.Size = New System.Drawing.Size(939, 246)
        Me.dgvDataBarang.TabIndex = 11
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(564, 55)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(483, 55)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 34)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(402, 55)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 34)
        Me.btnInput.TabIndex = 8
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'txtCatatan
        '
        Me.txtCatatan.Location = New System.Drawing.Point(139, 175)
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(214, 22)
        Me.txtCatatan.TabIndex = 7
        '
        'txtJbarang
        '
        Me.txtJbarang.Location = New System.Drawing.Point(139, 121)
        Me.txtJbarang.Name = "txtJbarang"
        Me.txtJbarang.Size = New System.Drawing.Size(214, 22)
        Me.txtJbarang.TabIndex = 6
        '
        'txtBarang
        '
        Me.txtBarang.Location = New System.Drawing.Point(139, 61)
        Me.txtBarang.Name = "txtBarang"
        Me.txtBarang.Size = New System.Drawing.Size(214, 22)
        Me.txtBarang.TabIndex = 5
        '
        'txtKdbarang
        '
        Me.txtKdbarang.Location = New System.Drawing.Point(139, 10)
        Me.txtKdbarang.Name = "txtKdbarang"
        Me.txtKdbarang.Size = New System.Drawing.Size(214, 22)
        Me.txtKdbarang.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Catatan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Jenis Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nama Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Kode Barang"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDelete2)
        Me.TabPage2.Controls.Add(Me.btnEdit2)
        Me.TabPage2.Controls.Add(Me.btnSimpan2)
        Me.TabPage2.Controls.Add(Me.dgvDatapekerja)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.txtNoktp)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtNamapekerja)
        Me.TabPage2.Controls.Add(Me.txtKdpekerja)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(991, 480)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Pekerja Lapangan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDelete2
        '
        Me.btnDelete2.Location = New System.Drawing.Point(240, 329)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete2.TabIndex = 10
        Me.btnDelete2.Text = "Delete"
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'btnEdit2
        '
        Me.btnEdit2.Location = New System.Drawing.Point(148, 329)
        Me.btnEdit2.Name = "btnEdit2"
        Me.btnEdit2.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit2.TabIndex = 9
        Me.btnEdit2.Text = "Edit"
        Me.btnEdit2.UseVisualStyleBackColor = True
        '
        'btnSimpan2
        '
        Me.btnSimpan2.Location = New System.Drawing.Point(54, 329)
        Me.btnSimpan2.Name = "btnSimpan2"
        Me.btnSimpan2.Size = New System.Drawing.Size(75, 30)
        Me.btnSimpan2.TabIndex = 8
        Me.btnSimpan2.Text = "Input"
        Me.btnSimpan2.UseVisualStyleBackColor = True
        '
        'dgvDatapekerja
        '
        Me.dgvDatapekerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatapekerja.Location = New System.Drawing.Point(384, 6)
        Me.dgvDatapekerja.Name = "dgvDatapekerja"
        Me.dgvDatapekerja.ReadOnly = True
        Me.dgvDatapekerja.RowTemplate.Height = 24
        Me.dgvDatapekerja.Size = New System.Drawing.Size(601, 468)
        Me.dgvDatapekerja.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLainya)
        Me.GroupBox2.Controls.Add(Me.txtIstri)
        Me.GroupBox2.Controls.Add(Me.txtAnak)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 151)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Keluarga"
        '
        'txtLainya
        '
        Me.txtLainya.Location = New System.Drawing.Point(115, 103)
        Me.txtLainya.Name = "txtLainya"
        Me.txtLainya.Size = New System.Drawing.Size(210, 22)
        Me.txtLainya.TabIndex = 9
        '
        'txtIstri
        '
        Me.txtIstri.Location = New System.Drawing.Point(115, 69)
        Me.txtIstri.Name = "txtIstri"
        Me.txtIstri.Size = New System.Drawing.Size(210, 22)
        Me.txtIstri.TabIndex = 8
        '
        'txtAnak
        '
        Me.txtAnak.Location = New System.Drawing.Point(115, 33)
        Me.txtAnak.Name = "txtAnak"
        Me.txtAnak.Size = New System.Drawing.Size(210, 22)
        Me.txtAnak.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Lainya"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Istri"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Anak"
        '
        'txtNoktp
        '
        Me.txtNoktp.Location = New System.Drawing.Point(137, 100)
        Me.txtNoktp.Name = "txtNoktp"
        Me.txtNoktp.Size = New System.Drawing.Size(210, 22)
        Me.txtNoktp.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "No. Ktp"
        '
        'txtNamapekerja
        '
        Me.txtNamapekerja.Location = New System.Drawing.Point(137, 54)
        Me.txtNamapekerja.Name = "txtNamapekerja"
        Me.txtNamapekerja.Size = New System.Drawing.Size(210, 22)
        Me.txtNamapekerja.TabIndex = 3
        '
        'txtKdpekerja
        '
        Me.txtKdpekerja.Location = New System.Drawing.Point(137, 13)
        Me.txtKdpekerja.Name = "txtKdpekerja"
        Me.txtKdpekerja.Size = New System.Drawing.Size(210, 22)
        Me.txtKdpekerja.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nama Pekerja"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Kode Pekerja"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.txtCariNama)
        Me.TabPage3.Controls.Add(Me.txtKdgaji)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.txtTotal)
        Me.TabPage3.Controls.Add(Me.txtGaji)
        Me.TabPage3.Controls.Add(Me.txtKehadiran)
        Me.TabPage3.Controls.Add(Me.txtNamapekerja2)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.btnInput3)
        Me.TabPage3.Controls.Add(Me.btnHitung)
        Me.TabPage3.Controls.Add(Me.dgvGaji)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(991, 480)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gaji"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtKdgaji
        '
        Me.txtKdgaji.Location = New System.Drawing.Point(210, 9)
        Me.txtKdgaji.Name = "txtKdgaji"
        Me.txtKdgaji.Size = New System.Drawing.Size(202, 22)
        Me.txtKdgaji.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(31, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 17)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Kode Gaji"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(210, 178)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(202, 22)
        Me.txtTotal.TabIndex = 11
        '
        'txtGaji
        '
        Me.txtGaji.Location = New System.Drawing.Point(210, 139)
        Me.txtGaji.Name = "txtGaji"
        Me.txtGaji.ReadOnly = True
        Me.txtGaji.Size = New System.Drawing.Size(202, 22)
        Me.txtGaji.TabIndex = 10
        Me.txtGaji.Text = "50000"
        '
        'txtKehadiran
        '
        Me.txtKehadiran.Location = New System.Drawing.Point(210, 95)
        Me.txtKehadiran.Name = "txtKehadiran"
        Me.txtKehadiran.Size = New System.Drawing.Size(202, 22)
        Me.txtKehadiran.TabIndex = 9
        '
        'txtNamapekerja2
        '
        Me.txtNamapekerja2.Location = New System.Drawing.Point(210, 50)
        Me.txtNamapekerja2.Name = "txtNamapekerja2"
        Me.txtNamapekerja2.Size = New System.Drawing.Size(202, 22)
        Me.txtNamapekerja2.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(543, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Cetak"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnInput3
        '
        Me.btnInput3.Location = New System.Drawing.Point(439, 216)
        Me.btnInput3.Name = "btnInput3"
        Me.btnInput3.Size = New System.Drawing.Size(75, 29)
        Me.btnInput3.TabIndex = 6
        Me.btnInput3.Text = "Input"
        Me.btnInput3.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(337, 216)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 29)
        Me.btnHitung.TabIndex = 5
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'dgvGaji
        '
        Me.dgvGaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGaji.Location = New System.Drawing.Point(6, 291)
        Me.dgvGaji.Name = "dgvGaji"
        Me.dgvGaji.ReadOnly = True
        Me.dgvGaji.RowTemplate.Height = 24
        Me.dgvGaji.Size = New System.Drawing.Size(979, 183)
        Me.dgvGaji.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(31, 178)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 17)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Total"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(31, 139)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 17)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Gaji Per Hari"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(31, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 17)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Jumlah Kehadiran"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(31, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Nama Pekerja"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(991, 480)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "About"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(847, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CV Karya Dipa Payroll Management System 0.0.1 (BETA)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 167)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kelompok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mukhsinul Akhlaq"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Abdi Dermawan Margono"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mahmud Supriyadi"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Abdurrahman"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Luthfy Gumelar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PrintDocument1
        '
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(446, 10)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(214, 22)
        Me.txtJumlah.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(359, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 17)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Jumlah"
        '
        'txtCariNama
        '
        Me.txtCariNama.Location = New System.Drawing.Point(337, 263)
        Me.txtCariNama.Name = "txtCariNama"
        Me.txtCariNama.Size = New System.Drawing.Size(202, 22)
        Me.txtCariNama.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(543, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 533)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form2"
        Me.Text = "C.V Karya Dipa | Menu Utama"
        Me.TabControl1.ResumeLayout(False)
        Me.s.ResumeLayout(False)
        Me.s.PerformLayout()
        CType(Me.dgvDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDatapekerja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvGaji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents s As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDataBarang As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents txtCatatan As TextBox
    Friend WithEvents txtJbarang As TextBox
    Friend WithEvents txtBarang As TextBox
    Friend WithEvents txtKdbarang As TextBox
    Friend WithEvents txtNamapekerja As TextBox
    Friend WithEvents txtKdpekerja As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvDatapekerja As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtLainya As TextBox
    Friend WithEvents txtIstri As TextBox
    Friend WithEvents txtAnak As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNoktp As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnDelete2 As Button
    Friend WithEvents btnEdit2 As Button
    Friend WithEvents btnSimpan2 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnInput3 As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents dgvGaji As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtGaji As TextBox
    Friend WithEvents txtKehadiran As TextBox
    Friend WithEvents txtNamapekerja2 As TextBox
    Friend WithEvents txtKdgaji As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label22 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtCariNama As TextBox
    Friend WithEvents Button1 As Button
End Class
