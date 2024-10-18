Imports System.Data.SqlClient

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KirimBarangSoftdevDataSet.Kota' table. You can move, or remove it, as needed.
        Me.KotaTableAdapter.Fill(Me.KirimBarangSoftdevDataSet.Kota)
        'TODO: This line of code loads data into the 'KirimBarangSoftdevDataSet.Pengiriman' table. You can move, or remove it, as needed.
        Me.PengirimanTableAdapter.Fill(Me.KirimBarangSoftdevDataSet.Pengiriman)

        LoadDataGridView3()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PengirimanTableAdapter.Insert(TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.PengirimanTableAdapter.Fill(Me.KirimBarangSoftdevDataSet.Pengiriman)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selectedItem As String
        Dim result As System.Windows.Forms.DialogResult

        selectedItem = DataGridView1.SelectedCells(0).Value.ToString

        result = MessageBox.Show("Yakin jenis pengiriman " & selectedItem & " Akan Dihapus?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If result = System.Windows.Forms.DialogResult.OK Then
            PengirimanTableAdapter.DQPengiriman(selectedItem)

            Me.PengirimanTableAdapter.Fill(Me.KirimBarangSoftdevDataSet.Pengiriman)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim selectedItem As String
        Dim result As System.Windows.Forms.DialogResult

        selectedItem = DataGridView2.SelectedCells(0).Value.ToString

        result = MessageBox.Show("Yakin kota " & selectedItem & " Akan Dihapus?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If result = System.Windows.Forms.DialogResult.OK Then
            KotaTableAdapter.DQKota(selectedItem)

            Me.KotaTableAdapter.Fill(Me.KirimBarangSoftdevDataSet.Kota)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        KotaTableAdapter.Insert(TextBox6.Text, TextBox7.Text)
        Me.KotaTableAdapter.Fill(Me.KirimBarangSoftdevDataSet.Kota)
    End Sub


    'MEMBUAT TABLEADAPTER TABEL PENGIRIMAN MENJADI PUBLIC AGAR BISA DIPAKAI / DI PANGGIL DI FORM 1'
    Public Function GetPengirimanData() As DataTable
        Me.PengirimanTableAdapter.Fill(Me.KirimBarangSoftdevDataSet.Pengiriman)
        Return Me.KirimBarangSoftdevDataSet.Pengiriman
    End Function


    'MEMBUAT TABLEADAPTER TABEL KOTA MENJADI PUBLIC AGAR BISA DIPAKAI / DI PANGGIL DI FORM 1'
    Public Function GetKotaData() As DataTable
        Me.KotaTableAdapter.Fill(Me.KirimBarangSoftdevDataSet.Kota)
        Return Me.KirimBarangSoftdevDataSet.Kota
    End Function



    ' Metode untuk melakukan update statusPengiriman ke database berdasarkan idPesanan
    Private Sub UpdateStatusPengiriman(idPesanan As Integer, statusPengiriman As String)
        ' Buat koneksi ke database
        Dim connectionString As String = "Server=ASUS;Database=KirimBarangSoftdev;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            ' Query untuk update statusPengiriman berdasarkan idPesanan
            Dim query As String = "UPDATE Pesanan SET statusPengiriman = @StatusPengiriman WHERE idPesanan = @IdPesanan"

            ' Buat command dan tambahkan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@StatusPengiriman", statusPengiriman)
            command.Parameters.AddWithValue("@IdPesanan", idPesanan)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Status pengiriman berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Memastikan ada baris yang dipilih
        If DataGridView3.SelectedRows.Count > 0 Then
            ' Mendapatkan nilai idPesanan dari baris yang dipilih
            Dim idPesanan As Integer = Convert.ToInt32(DataGridView3.SelectedRows(0).Cells("idPesanan").Value)

            ' Mendapatkan nilai statusPengiriman yang dipilih dari ComboBox1
            Dim statusPengiriman As String = ComboBox1.SelectedItem.ToString()

            ' Memanggil metode untuk melakukan update ke database
            UpdateStatusPengiriman(idPesanan, statusPengiriman)

            ' Memuat ulang DataGridView3 setelah update
            LoadDataGridView3()
        Else
            MessageBox.Show("Pilih satu baris untuk melakukan update status pengiriman.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub LoadDataGridView3()
        ' Buat koneksi ke database
        Dim connectionString As String = "Server=ASUS;Database=KirimBarangSoftdev;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            ' Query untuk menggabungkan tabel Pembayaran dan Pesanan
            Dim query As String = "SELECT Pembayaran.idPembayaran, Pembayaran.idPesanan, Pesanan.statusPengiriman AS status " &
                                  "FROM Pembayaran " &
                                  "JOIN Pesanan ON Pembayaran.idPesanan = Pesanan.idPesanan"

            ' Buat command dan tambahkan parameter jika diperlukan
            Dim command As New SqlCommand(query, connection)

            ' Buat adapter dan DataTable untuk menyimpan hasil query
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            Try
                connection.Open()
                adapter.Fill(dataTable)
                DataGridView3.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim idPesananFilter As Integer

        ' Cek apakah input dari TextBox8 bisa diubah menjadi Integer
        If Integer.TryParse(TextBox8.Text, idPesananFilter) Then
            LoadDataGridView3(idPesananFilter)
        Else
            ' Jika TextBox8 kosong, load semua data
            If TextBox8.Text.Trim() = "" Then
                LoadDataGridView3()
            Else
                MessageBox.Show("Masukkan nilai yang valid untuk idPesanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    ' Metode untuk memuat data ke DataGridView3 dengan atau tanpa filter idPesanan
    Private Sub LoadDataGridView3(Optional idPesananFilter As Integer = 0)
        ' Buat koneksi ke database
        Dim connectionString As String = "Server=ASUS;Database=KirimBarangSoftdev;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            ' Query untuk menggabungkan tabel Pembayaran dan Pesanan dengan atau tanpa filter idPesanan
            Dim query As String

            If idPesananFilter > 0 Then
                query = "SELECT Pembayaran.idPembayaran, Pembayaran.idPesanan, Pesanan.statusPengiriman AS status " &
                    "FROM Pembayaran " &
                    "JOIN Pesanan ON Pembayaran.idPesanan = Pesanan.idPesanan " &
                    "WHERE Pesanan.idPesanan = @IdPesanan"
            Else
                query = "SELECT Pembayaran.idPembayaran, Pembayaran.idPesanan, Pesanan.statusPengiriman AS status " &
                    "FROM Pembayaran " &
                    "JOIN Pesanan ON Pembayaran.idPesanan = Pesanan.idPesanan"
            End If

            ' Buat command dan tambahkan parameter jika ada filter idPesanan
            Dim command As New SqlCommand(query, connection)

            If idPesananFilter > 0 Then
                command.Parameters.AddWithValue("@IdPesanan", idPesananFilter)
            End If

            ' Buat adapter dan DataTable untuk menyimpan hasil query
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            Try
                connection.Open()
                adapter.Fill(dataTable)
                DataGridView3.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim backk As New Form1
        backk.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 1
    End Sub
End Class