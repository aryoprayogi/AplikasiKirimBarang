<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.JenisPengirimanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimasiWaktuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PengirimanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KirimBarangSoftdevDataSet = New UASKIRIMBARANG.KirimBarangSoftdevDataSet()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdKotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaKotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPulauDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PengirimanTableAdapter = New UASKIRIMBARANG.KirimBarangSoftdevDataSetTableAdapters.PengirimanTableAdapter()
        Me.KotaTableAdapter = New UASKIRIMBARANG.KirimBarangSoftdevDataSetTableAdapters.KotaTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengirimanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KirimBarangSoftdevDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.UASKIRIMBARANG.My.Resources.Resources.admin_login1
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login admin"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(593, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(674, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(123, 310)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(552, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 231)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(552, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.UASKIRIMBARANG.My.Resources.Resources.Input_pengiriman1
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Input Pengiriman"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(671, 364)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 29)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(671, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "INSERT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TextBox5.Location = New System.Drawing.Point(505, 361)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(113, 20)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TextBox4.Location = New System.Drawing.Point(299, 361)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(147, 20)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TextBox3.Location = New System.Drawing.Point(48, 361)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(190, 20)
        Me.TextBox3.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JenisPengirimanDataGridViewTextBoxColumn, Me.EstimasiWaktuDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PengirimanBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(796, 311)
        Me.DataGridView1.TabIndex = 0
        '
        'JenisPengirimanDataGridViewTextBoxColumn
        '
        Me.JenisPengirimanDataGridViewTextBoxColumn.DataPropertyName = "jenisPengiriman"
        Me.JenisPengirimanDataGridViewTextBoxColumn.HeaderText = "jenisPengiriman"
        Me.JenisPengirimanDataGridViewTextBoxColumn.Name = "JenisPengirimanDataGridViewTextBoxColumn"
        '
        'EstimasiWaktuDataGridViewTextBoxColumn
        '
        Me.EstimasiWaktuDataGridViewTextBoxColumn.DataPropertyName = "estimasiWaktu"
        Me.EstimasiWaktuDataGridViewTextBoxColumn.HeaderText = "estimasiWaktu"
        Me.EstimasiWaktuDataGridViewTextBoxColumn.Name = "EstimasiWaktuDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'PengirimanBindingSource
        '
        Me.PengirimanBindingSource.DataMember = "Pengiriman"
        Me.PengirimanBindingSource.DataSource = Me.KirimBarangSoftdevDataSet
        '
        'KirimBarangSoftdevDataSet
        '
        Me.KirimBarangSoftdevDataSet.DataSetName = "KirimBarangSoftdevDataSet"
        Me.KirimBarangSoftdevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.UASKIRIMBARANG.My.Resources.Resources.Input_Kota1
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 424)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Input Kota"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(639, 336)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(105, 41)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "DELETE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(507, 336)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 41)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "INSERT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TextBox7.Location = New System.Drawing.Point(276, 357)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(172, 20)
        Me.TextBox7.TabIndex = 2
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TextBox6.Location = New System.Drawing.Point(34, 357)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(164, 20)
        Me.TextBox6.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdKotaDataGridViewTextBoxColumn, Me.NamaKotaDataGridViewTextBoxColumn, Me.NamaPulauDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.KotaBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(796, 303)
        Me.DataGridView2.TabIndex = 0
        '
        'IdKotaDataGridViewTextBoxColumn
        '
        Me.IdKotaDataGridViewTextBoxColumn.DataPropertyName = "idKota"
        Me.IdKotaDataGridViewTextBoxColumn.HeaderText = "idKota"
        Me.IdKotaDataGridViewTextBoxColumn.Name = "IdKotaDataGridViewTextBoxColumn"
        Me.IdKotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaKotaDataGridViewTextBoxColumn
        '
        Me.NamaKotaDataGridViewTextBoxColumn.DataPropertyName = "namaKota"
        Me.NamaKotaDataGridViewTextBoxColumn.HeaderText = "namaKota"
        Me.NamaKotaDataGridViewTextBoxColumn.Name = "NamaKotaDataGridViewTextBoxColumn"
        '
        'NamaPulauDataGridViewTextBoxColumn
        '
        Me.NamaPulauDataGridViewTextBoxColumn.DataPropertyName = "namaPulau"
        Me.NamaPulauDataGridViewTextBoxColumn.HeaderText = "namaPulau"
        Me.NamaPulauDataGridViewTextBoxColumn.Name = "NamaPulauDataGridViewTextBoxColumn"
        '
        'KotaBindingSource
        '
        Me.KotaBindingSource.DataMember = "Kota"
        Me.KotaBindingSource.DataSource = Me.KirimBarangSoftdevDataSet
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.UASKIRIMBARANG.My.Resources.Resources.updatestatus2
        Me.TabPage4.Controls.Add(Me.DataGridView3)
        Me.TabPage4.Controls.Add(Me.TextBox8)
        Me.TabPage4.Controls.Add(Me.Button8)
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.ComboBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(792, 424)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Update Status Kirim"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(792, 330)
        Me.DataGridView3.TabIndex = 4
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(50, 375)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(134, 20)
        Me.TextBox8.TabIndex = 3
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(546, 354)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(99, 41)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "UPDATE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(190, 370)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(58, 29)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Cari"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Paket sudah diterima kurir", "Paket sedang di antar ke kota tujuan", "Paket tiba di kota tujuan", "Paket sedang di antar ke alamat penerima", "Paket sudah tiba dan diterima"})
        Me.ComboBox1.Location = New System.Drawing.Point(274, 375)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'PengirimanTableAdapter
        '
        Me.PengirimanTableAdapter.ClearBeforeFill = True
        '
        'KotaTableAdapter
        '
        Me.KotaTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengirimanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KirimBarangSoftdevDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KirimBarangSoftdevDataSet As KirimBarangSoftdevDataSet
    Friend WithEvents PengirimanBindingSource As BindingSource
    Friend WithEvents PengirimanTableAdapter As KirimBarangSoftdevDataSetTableAdapters.PengirimanTableAdapter
    Friend WithEvents JenisPengirimanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimasiWaktuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents KotaBindingSource As BindingSource
    Friend WithEvents KotaTableAdapter As KirimBarangSoftdevDataSetTableAdapters.KotaTableAdapter
    Friend WithEvents IdKotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaKotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPulauDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TextBox8 As TextBox
End Class
