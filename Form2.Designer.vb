<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.CmbKelas = New System.Windows.Forms.ComboBox()
        Me.CmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CmbMataPelajaran = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Jpan", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tampilkan Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kelas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(168, 126)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(238, 20)
        Me.TxtNama.TabIndex = 4
        '
        'CmbKelas
        '
        Me.CmbKelas.FormattingEnabled = True
        Me.CmbKelas.Items.AddRange(New Object() {"XII IPA", "XII IPS"})
        Me.CmbKelas.Location = New System.Drawing.Point(167, 200)
        Me.CmbKelas.Name = "CmbKelas"
        Me.CmbKelas.Size = New System.Drawing.Size(238, 21)
        Me.CmbKelas.TabIndex = 5
        '
        'CmbJenisKelamin
        '
        Me.CmbJenisKelamin.FormattingEnabled = True
        Me.CmbJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.CmbJenisKelamin.Location = New System.Drawing.Point(165, 274)
        Me.CmbJenisKelamin.Name = "CmbJenisKelamin"
        Me.CmbJenisKelamin.Size = New System.Drawing.Size(240, 21)
        Me.CmbJenisKelamin.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 64)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tampil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(412, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CmbMataPelajaran
        '
        Me.CmbMataPelajaran.FormattingEnabled = True
        Me.CmbMataPelajaran.Items.AddRange(New Object() {"Agama", "Bahasa Indonesia", "Bahasa Inggris", "Bahasa Korea", "Biologi", "Fisika", "Kimia", "Matematika", "Peminatan Matematika", "Penjaskes", "PKN", "Prakarya", "Pramuka", "Sejarah Indonesia", "Seni Budaya", "Sastra Inggris", "TIK"})
        Me.CmbMataPelajaran.Location = New System.Drawing.Point(165, 346)
        Me.CmbMataPelajaran.Name = "CmbMataPelajaran"
        Me.CmbMataPelajaran.Size = New System.Drawing.Size(241, 21)
        Me.CmbMataPelajaran.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mata Pelajaran"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(547, 524)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbMataPelajaran)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbJenisKelamin)
        Me.Controls.Add(Me.CmbKelas)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents CmbKelas As System.Windows.Forms.ComboBox
    Friend WithEvents CmbJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CmbMataPelajaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
