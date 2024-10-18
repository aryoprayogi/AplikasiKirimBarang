Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pageSignUp As New Form2
        pageSignUp.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pageLogin As New Form2
        Form2.Show()
        Form2.TabControl1.SelectedIndex = 1
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim loginadmin As New Form3
        loginadmin.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim promo As New Form1
        Me.TabControl1.SelectedIndex = 1
    End Sub

    Public IsLoggedIn As Boolean = False ' Flag untuk status login

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        ' Jika pengguna sudah login dan mencoba memilih tab index ke 0
        If IsLoggedIn AndAlso e.TabPageIndex = 0 Then
            MessageBox.Show("Anda sudah login, silahkan logout terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True ' Membatalkan pemilihan tab
        End If
    End Sub

    ' Variabel publik untuk menyimpan nilai email
    Public PublicLoginEmail As String = ""

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pageOrder As New Form4
        pageOrder.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Membuka Form4
        Dim form4 As New Form4()
        form4.Show()
        Me.Close()

        ' Mengisi TextBox8 di Form4 dengan teks 'SMALL20'
        form4.TextBox8.Text = "SMALL20"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Membuka Form4
        Dim form4 As New Form4()
        form4.Show()
        Me.Close()

        ' Mengisi TextBox8 di Form4 dengan teks 'SMALL20'
        form4.TextBox8.Text = "MAKINMURAH"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ' Membuka Form4
        Dim form4 As New Form4()
        form4.Show()
        Me.Close()

        ' Mengisi TextBox8 di Form4 dengan teks 'SMALL20'
        form4.TextBox8.Text = "BIGCOUNT"
    End Sub



    ' Metode untuk memuat data ke DataGridView
    Public Sub LoadDataGridView()
        ' Buat koneksi ke database
        Dim connectionString As String = "Server=ASUS;Database=KirimBarangSoftdev;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            ' Query untuk menggabungkan tabel Pesanan dan Pembayaran
            Dim query As String = "SELECT Pesanan.email, Pembayaran.tanggalTransaksi, Pembayaran.totalHarga, Pesanan.jenisBarang, Pesanan.beratBarang, Pesanan.jenisPengiriman, Pesanan.statusPengiriman " &
                                  "FROM Pesanan " &
                                  "JOIN Pembayaran ON Pesanan.idPesanan = Pembayaran.idPesanan " &
                                  "WHERE Pesanan.email = @LoginEmail"

            ' Buat command dan tambahkan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@LoginEmail", loginEmail)

            ' Buat adapter dan DataTable untuk menyimpan hasil query
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            Try
                connection.Open()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsLoggedIn Then
            LoadDataGridView()
        End If

        LoadDataToComboBoxKota()
        LoadDataToComboBoxPengiriman()
    End Sub




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



    'LOAD DATA COMBOBOX PENGIRIMAN'
    Private Sub LoadDataToComboBoxPengiriman()
        Try
            ' Buat instance dari Form3 dan panggil metode GetPengirimanData
            Dim form3 As New Form3()
            Dim pengirimanTable As DataTable = form3.GetPengirimanData()

            ' Bersihkan item ComboBox sebelum menambahkan item baru
            ComboBox3.Items.Clear()

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
                ComboBox3.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' MENDAPATKAN HANYA HARGA DARI COMBOBOX JENISPENGIRIMAN
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ' Get the selected item from ComboBox
        Dim selectedItem As String = ComboBox3.SelectedItem.ToString()

        ' Extract the numeric value after "Rp" using regular expression
        Dim regex As New System.Text.RegularExpressions.Regex("Rp([\d,.]+)")
        Dim match As System.Text.RegularExpressions.Match = regex.Match(selectedItem)

        If match.Success Then
            ' Remove any commas from the matched string
            Dim valueStr As String = match.Groups(1).Value.Replace(".", String.Empty)
            ' Convert the cleaned string to an integer and store it in the public variable
            hargaKirimCek = Convert.ToInt32(valueStr)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        kotaAsalCek = ComboBox1.SelectedItem
        kotaTujuanCek = ComboBox2.SelectedItem
        totalBeratBarangCek = TextBox1.Text

        Try
            Dim adapterKota As New KirimBarangSoftdevDataSetTableAdapters.KotaTableAdapter()
            Dim kotaAsalTable As KirimBarangSoftdevDataSet.KotaDataTable = adapterKota.GetDataByNamaKota(kotaAsalCek)
            Dim kotaTujuanTable As KirimBarangSoftdevDataSet.KotaDataTable = adapterKota.GetDataByNamaKota(kotaTujuanCek)

            If kotaAsalTable.Rows.Count > 0 AndAlso kotaTujuanTable.Rows.Count > 0 Then
                Dim namaPulauAsal As String = kotaAsalTable(0).namaPulau
                Dim namaPulauTujuan As String = kotaTujuanTable(0).namaPulau

                ' Menentukan totalHarga berdasarkan namaPulau
                If namaPulauAsal <> namaPulauTujuan Then
                    totalhargaCek = 50000 + (hargaKirimCek * totalBeratBarangCek)
                Else
                    totalhargaCek = 0 + (hargaKirimCek * totalBeratBarangCek)
                End If

                ' Cetak totalHarga
                TextBox2.Text = "Rp." & totalhargaCek

            Else
                MessageBox.Show("Kota asal atau kota tujuan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Catch ex As Exception
            ' Menangani kesalahan jika ada
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

    End Sub


End Class
