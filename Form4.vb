Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports UASKIRIMBARANG.KirimBarangSoftdevDataSetTableAdapters

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        alamatPengirim = TextBox3.Text
        kotaAsal = ComboBox1.SelectedItem



        ' Mendapatkan idKotaPengirim dari ComboBox3
        Dim idKotaPengirim As Integer = -1 ' Default jika tidak ada yang dipilih
        Dim selectedKotaPengirim As String = ComboBox1.SelectedItem.ToString()

        ' Menggunakan table adapter untuk mendapatkan idKota berdasarkan namaKota
        Try
            ' Mendapatkan idKotaPengirim
            Dim adapterKota As New KirimBarangSoftdevDataSetTableAdapters.KotaTableAdapter()
            Dim dataTableKotaPengirim As KirimBarangSoftdevDataSet.KotaDataTable = adapterKota.GetDataByNamaKota(selectedKotaPengirim)

            ' Pastikan ada hasil yang ditemukan untuk pengirim
            If dataTableKotaPengirim.Rows.Count > 0 Then
                Dim rowPengirim As KirimBarangSoftdevDataSet.KotaRow = DirectCast(dataTableKotaPengirim.Rows(0), KirimBarangSoftdevDataSet.KotaRow)
                idKotaPengirim = rowPengirim.idKota
            Else
                MessageBox.Show("Nama kota pengirim tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Memasukkan data ke dalam tabel DetailPengirim menggunakan table adapter
            Try
                ' Memasukkan data ke dalam tabel DetailPengirim
                Dim adapterDetailPengirim As New KirimBarangSoftdevDataSetTableAdapters.DetailPengirimTableAdapter()
                adapterDetailPengirim.Insert(idKotaPengirim, TextBox1.Text, TextBox3.Text, TextBox2.Text)

                ' Memberitahu user bahwa data berhasil disimpan
                MessageBox.Show("Data berhasil disimpan ke dalam tabel DetailPengirim.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Menangani kesalahan jika ada
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            ' Menangani kesalahan jika ada
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        TabControl1.SelectedIndex = 1
    End Sub


    'LOAD DATA COMBOBOX PENGIRIMAN'
    Private Sub LoadDataToComboBoxPengiriman()
        Try
            ' Buat instance dari Form3 dan panggil metode GetPengirimanData
            Dim form3 As New Form3()
            Dim pengirimanTable As DataTable = form3.GetPengirimanData()

            ' Bersihkan item ComboBox sebelum menambahkan item baru
            ComboBox4.Items.Clear()

            ' Iterasi melalui setiap baris dalam tabel Pengiriman
            For Each row As DataRow In pengirimanTable.Rows
                ' Ambil nilai dari kolom yang dibutuhkan
                Dim jenisPengiriman As String = row("jenisPengiriman").ToString()
                Dim estimasiWaktu As String = row("estimasiWaktu").ToString()
                Dim harga As Decimal = Convert.ToDecimal(row("harga"))

                ' Format data sesuai kebutuhan
                Dim formattedHarga As String = harga.ToString("N0") ' Menampilkan harga tanpa desimal

                Dim item As String = String.Format("{0} ({1} : Rp{2}/kg)", jenisPengiriman, estimasiWaktu, formattedHarga)

                ' Tambahkan item yang telah diformat ke ComboBox
                ComboBox4.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    'LOAD DATA COMBOBOX KOTA'
    Private Sub LoadDataToComboBoxKota()
        Try
            ' Buat instance dari Form3 dan panggil metode GetKotaData
            Dim form3 As New Form3()
            Dim kotaTable As DataTable = form3.GetKotaData()

            ' Bersihkan item ComboBox sebelum menambahkan item baru
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()

            ' Iterasi melalui setiap baris dalam tabel Kota
            For Each row As DataRow In kotaTable.Rows
                ' Ambil nilai dari kolom yang dibutuhkan
                Dim namaKota As String = row("namaKota").ToString()

                ' Tambahkan item yang telah diformat ke ComboBox
                ComboBox1.Items.Add(namaKota)
                ComboBox2.Items.Add(namaKota)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToComboBoxKota()
        LoadDataToComboBoxPengiriman()
        TextBox9.Text = loginEmail
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        alamatPenerima = TextBox6.Text
        kotaTujuan = ComboBox2.SelectedItem


        ' Mendapatkan idKotaPengirim dari ComboBox3
        Dim idKotaPenerima As Integer = -1 ' Default jika tidak ada yang dipilih
        Dim selectedKotaPenerima As String = ComboBox2.SelectedItem.ToString()

        ' Menggunakan table adapter untuk mendapatkan idKota berdasarkan namaKota
        Try
            ' Mendapatkan idKotaPengirim
            Dim adapterKota As New KirimBarangSoftdevDataSetTableAdapters.KotaTableAdapter()
            Dim dataTableKotaPenerima As KirimBarangSoftdevDataSet.KotaDataTable = adapterKota.GetDataByNamaKota(selectedKotaPenerima)

            ' Pastikan ada hasil yang ditemukan untuk pengirim
            If dataTableKotaPenerima.Rows.Count > 0 Then
                Dim rowPenerima As KirimBarangSoftdevDataSet.KotaRow = DirectCast(dataTableKotaPenerima.Rows(0), KirimBarangSoftdevDataSet.KotaRow)
                idKotaPenerima = rowPenerima.idKota
            Else
                MessageBox.Show("Nama kota penerima tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Memasukkan data ke dalam tabel DetailPengirim menggunakan table adapter
            Try
                ' Memasukkan data ke dalam tabel DetailPengirim
                Dim adapterDetailPenerima As New KirimBarangSoftdevDataSetTableAdapters.DetailPenerimaTableAdapter()
                adapterDetailPenerima.Insert(idKotaPenerima, TextBox4.Text, TextBox6.Text, TextBox5.Text)

                ' Memberitahu user bahwa data berhasil disimpan
                MessageBox.Show("Data berhasil disimpan ke dalam tabel DetailPenerima.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Menangani kesalahan jika ada
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            ' Menangani kesalahan jika ada
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        TabControl1.SelectedIndex = 2
    End Sub


    Private Function GetMaxIdFromTable(tableName As String, columnName As String) As Integer
        Dim maxId As Integer = -1

        ' Membuat koneksi ke database
        Dim connectionString As String = "Server=ASUS;Database=KirimBarangSoftdev;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            Dim query As String = $"SELECT MAX({columnName}) FROM {tableName}"
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    maxId = Convert.ToInt32(result)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using

        Return maxId
    End Function

    Public PublicLoginEmail As String



    Private Sub comboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ' Menggunakan SelectedIndex untuk mengecek item yang dipilih
        Select Case ComboBox3.SelectedIndex
            Case 0
                hargaJenisBarang = 10000 ' Jika item pertama dipilih
            Case 1
                hargaJenisBarang = 0 ' Jika item kedua dipilih
                ' Anda dapat menambahkan case lain jika ada lebih banyak pilihan
        End Select
    End Sub




    ' MENDAPATKAN HANYA HARGA DARI COMBOBOX JENISPENGIRIMAN
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ' Get the selected item from ComboBox
        Dim selectedItem As String = ComboBox4.SelectedItem.ToString()

        ' Extract the numeric value after "Rp" using regular expression
        Dim regex As New System.Text.RegularExpressions.Regex("Rp([\d,.]+)")
        Dim match As System.Text.RegularExpressions.Match = regex.Match(selectedItem)

        If match.Success Then
            ' Remove any commas from the matched string
            Dim valueStr As String = match.Groups(1).Value.Replace(".", String.Empty)
            ' Convert the cleaned string to an integer and store it in the public variable
            hargaKirim = Convert.ToInt32(valueStr)
        End If
    End Sub


    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim totalBeratBarang As Decimal
        If Decimal.TryParse(TextBox7.Text, totalBeratBarang) Then
            Dim kodePromo As String = TextBox8.Text.Trim()
            Dim pesanPeringatan As String = ""

            ' Menentukan pesan peringatan berdasarkan kode promo dan totalBeratBarang
            Select Case kodePromo
                Case "SMALL20"
                    If totalBeratBarang > 4 Then
                        pesanPeringatan = "Kode promo SMALL20 dengan berat barang tidak sesuai. Berat barang harus <5 Kg"
                    End If
                Case "MAKINMURAH"
                    If totalBeratBarang < 5 OrElse totalBeratBarang > 15 Then
                        pesanPeringatan = "Kode promo MAKINMURAH dengan berat barang tidak sesuai. Berat barang harus 5-15 Kg"
                    End If
                Case "BIGCOUNT"
                    If totalBeratBarang < 16 Then
                        pesanPeringatan = "Kode promo BIGCOUNT dengan berat barang tidak sesuai. Berat barang harus >15 Kg"
                    End If
            End Select

            ' Menampilkan pesan peringatan jika ada
            If Not String.IsNullOrEmpty(pesanPeringatan) Then
                MessageBox.Show(pesanPeringatan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            ' Jika input tidak valid (bukan angka), kosongkan TextBox atau berikan pesan sesuai kebutuhan
            ' Contoh:
            ' TextBox7.Text = ""
            ' MessageBox.Show("Masukkan berat barang dalam bentuk angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        jenisBarangg = ComboBox3.SelectedItem
        jenisPengirimann = ComboBox4.SelectedItem
        totalBeratBarang = TextBox7.Text
        kodePromo = TextBox8.Text
        ' Menentukan diskon berdasarkan kode promo
        Dim diskon As Double = 1.0 ' Nilai default jika tidak ada kode promo yang cocok

        Select Case kodePromo
            Case "SMALL20"
                diskon = 0.8 ' Diskon 20%
            Case "MAKINMURAH"
                diskon = 0.75 ' Diskon 25%
            Case "BIGCOUNT"
                diskon = 0.7 ' Diskon 30%
            Case Else
                ' Tidak ada diskon untuk kode promo lainnya atau kode promo tidak valid
                diskon = 1.0 ' Tidak ada diskon
        End Select


        ' Ambil jenisPengiriman dari ComboBox4 sebelum tanda kurung buka '('
        Dim selectedJenisPengiriman As String = ComboBox4.SelectedItem.ToString()
        Dim jenisPengiriman As String = selectedJenisPengiriman.Split("("c)(0).Trim()

        ' Ambil email dari Form2
        Dim loginEmail As String
        ' loginEmail = form2.passEmail()

        ' Cetak hasil dari loginEmail di MessageBox
        ' MessageBox.Show("Nilai dari loginEmail adalah: " & loginEmail)

        ' Dapatkan idPengirim (nilai MAX dari tabel DetailPengirim)
        Dim idPengirim As Integer = GetMaxIdFromTable("DetailPengirim", "idPengirim")

        ' Dapatkan idPenerima (nilai MAX dari tabel DetailPenerima)
        Dim idPenerima As Integer = GetMaxIdFromTable("DetailPenerima", "idPenerima")

        ' Ambil beratBarang dari TextBox7
        Dim beratBarang As Decimal = Convert.ToDecimal(TextBox7.Text)

        ' Ambil jenisBarang dari ComboBox3 sebelum tanda kurung buka '('
        Dim selectedJenisBarang As String = ComboBox3.SelectedItem.ToString()
        Dim jenisBarang As String = selectedJenisBarang.Split("("c)(0).Trim()

        ' Set statusPengiriman dengan teks tertentu
        Dim statusPengiriman As String = "Kurir sedang dalam perjalanan menjemput paket"

        ' Insert data ke tabel Pesanan
        Try
            Dim adapterPesanan As New KirimBarangSoftdevDataSetTableAdapters.PesananTableAdapter()
            adapterPesanan.Insert(jenisPengiriman, TextBox9.Text, idPengirim, idPenerima, beratBarang, jenisBarang, statusPengiriman)

            ' Memberitahu user bahwa data berhasil disimpan
            MessageBox.Show("Data berhasil disimpan ke dalam tabel Pesanan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Menangani kesalahan jika ada
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Query untuk mendapatkan namaPulau dari kotaAsal dan kotaTujuan
        Try
            Dim adapterKota As New KirimBarangSoftdevDataSetTableAdapters.KotaTableAdapter()
            Dim kotaAsalTable As KirimBarangSoftdevDataSet.KotaDataTable = adapterKota.GetDataByNamaKota(kotaAsal)
            Dim kotaTujuanTable As KirimBarangSoftdevDataSet.KotaDataTable = adapterKota.GetDataByNamaKota(kotaTujuan)

            If kotaAsalTable.Rows.Count > 0 AndAlso kotaTujuanTable.Rows.Count > 0 Then
                Dim namaPulauAsal As String = kotaAsalTable(0).namaPulau
                Dim namaPulauTujuan As String = kotaTujuanTable(0).namaPulau

                ' Menentukan totalHarga berdasarkan namaPulau
                If namaPulauAsal <> namaPulauTujuan Then
                    totalHarga = (50000 + (hargaKirim * totalBeratBarang) + hargaJenisBarang) * diskon
                Else
                    totalHarga = (0 + (hargaKirim * totalBeratBarang) + hargaJenisBarang) * diskon
                End If

                ' Cetak totalHarga di MessageBox untuk verifikasi
                MessageBox.Show("Total Harga: " & totalHarga, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Kota asal atau kota tujuan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Catch ex As Exception
            ' Menangani kesalahan jika ada
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Menampilkan form invoice
        Dim invoice As New Form5
        invoice.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kembalii As New Form1
        kembalii.Show()
        kembalii.TabControl1.SelectedIndex = 1
        Me.Close()

    End Sub
End Class