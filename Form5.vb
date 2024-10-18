Imports System.Data.SqlClient

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Text = alamatPengirim
        TextBox5.Text = alamatPenerima
        TextBox6.Text = jenisBarangg
        TextBox7.Text = jenisPengirimann
        TextBox8.Text = totalBeratBarang & " KG"
        TextBox3.Text = "Rp." & totalHarga

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

    Private Function AmbilNilaiHarga(text As String) As Integer
        ' Menghapus karakter 'Rp.' dan spasi dari string harga
        Dim nilai As Integer
        If Integer.TryParse(text.Replace("Rp.", "").Trim(), nilai) Then
            Return nilai
        Else
            Return 0 ' Nilai default jika tidak dapat di-parse
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pesann As New Form4
        pesann.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Ambil nilai max idPesanan dari tabel Pesanan
            Dim idPesanan As Integer = GetMaxIdFromTable("Pesanan", "idPesanan")

            ' Ambil tanggal transaksi hari ini
            Dim tanggalTransaksi As DateTime = DateTime.Now

            ' Ambil nilai totalHarga dari TextBox3.Text
            Dim totalHarga As Integer = AmbilNilaiHarga(TextBox3.Text)

            ' Simpan ke dalam tabel Pembayaran
            Dim query As String = "INSERT INTO Pembayaran (idPesanan, tanggalTransaksi, totalHarga) VALUES (@idPesanan, @tanggalTransaksi, @totalHarga)"
            Using connection As New SqlConnection("Server=ASUS;Database=KirimBarangSoftdev;Trusted_Connection=True;")
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idPesanan", idPesanan)
                    command.Parameters.AddWithValue("@tanggalTransaksi", tanggalTransaksi)
                    command.Parameters.AddWithValue("@totalHarga", totalHarga)

                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil disimpan ke dalam tabel Pembayaran.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Buat instance Form1 dan set nilai login
        Dim orderhistory As New Form1
        orderhistory.IsLoggedIn = True ' Set flag login

        ' Pindah ke tab yang diinginkan
        orderhistory.TabControl1.SelectedIndex = 3

        ' Tampilkan form dan muat data ke DataGridView
        orderhistory.Show()
        orderhistory.LoadDataGridView()

        ' Tutup form saat ini
        Me.Close()
    End Sub
End Class