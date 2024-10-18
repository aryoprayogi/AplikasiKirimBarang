Imports System.Data.SqlClient

Public Class Form2
    Public form4 As New Form4()

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Home As New Form1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Home As New Form1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Mendapatkan teks dari TextBox2 dan TextBox3
        Dim password As String = TextBox2.Text.Trim()
        Dim confirmPassword As String = TextBox3.Text.Trim()

        ' Memeriksa apakah password dan konfirmasi password sama
        If password = confirmPassword Then
            ' Menyimpan data ke dalam tabel Customer menggunakan table adapter
            Try
                ' Mengakses table adapter dan dataset
                Dim adapter As New KirimBarangSoftdevDataSetTableAdapters.CustomerTableAdapter()
                Dim dataset As New KirimBarangSoftdevDataSet.CustomerDataTable()

                ' Memasukkan data baru ke dalam dataset
                dataset.AddCustomerRow(TextBox1.Text, password) ' Menggunakan TextBox1 untuk email

                ' Menyimpan perubahan ke database
                adapter.Update(dataset)

                ' Memberitahu user bahwa data berhasil disimpan
                MessageBox.Show("Data berhasil disimpan ke dalam tabel Customer.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Menangani kesalahan jika ada
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Menampilkan pesan jika password tidak cocok
            MessageBox.Show("Password konfirmasi Anda tidak sesuai, silahkan coba lagi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' Variabel publik untuk menyimpan nilai email
    'Public PublicLoginEmail As String


    Private Function GetDataByEmail(email As String) As KirimBarangSoftdevDataSet.CustomerDataTable
        Dim adapter As New KirimBarangSoftdevDataSetTableAdapters.CustomerTableAdapter()
        Dim customerDataTable As New KirimBarangSoftdevDataSet.CustomerDataTable()

        ' Menggunakan query SQL untuk mengambil data berdasarkan email
        adapter.FillByEmail(customerDataTable, email)

        Return customerDataTable
    End Function

    ' Variabel publik untuk menyimpan nilai email
    Public PublicLoginEmail As String = ""

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm2 As New Form2

        ' Mendapatkan teks dari TextBox4 dan TextBox6
        loginEmail = TextBox4.Text.Trim()
        Dim loginPassword As String = TextBox6.Text.Trim()

        Try
            ' Simpan nilai email ke variabel publik
            PublicLoginEmail = loginEmail

            ' Mengambil data customer berdasarkan email menggunakan fungsi GetDataByEmail
            Dim customerDataTable As KirimBarangSoftdevDataSet.CustomerDataTable = GetDataByEmail(loginEmail)

            ' Memeriksa hasil query untuk login
            If customerDataTable.Rows.Count > 0 Then
                Dim customerRow As KirimBarangSoftdevDataSet.CustomerRow = customerDataTable(0)

                ' Memeriksa password
                If loginPassword = customerRow.password Then
                    ' Login berhasil, arahkan ke Tab 1 di Form1
                    Dim form1 As New Form1()
                    form1.IsLoggedIn = True ' Set flag login
                    form1.Show()
                    form1.TabControl1.SelectedIndex = 1 ' Index Tab yang ingin ditampilkan

                    Me.Close() ' Tutup Form2 setelah login berhasil
                Else
                    ' Password salah
                    MessageBox.Show("Password salah. Silakan coba lagi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                ' Email tidak ditemukan
                MessageBox.Show("Email tidak terdaftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            ' Menangani kesalahan lainnya
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class