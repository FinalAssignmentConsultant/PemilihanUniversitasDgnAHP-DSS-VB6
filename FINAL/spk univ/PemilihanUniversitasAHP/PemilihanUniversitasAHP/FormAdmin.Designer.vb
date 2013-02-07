<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnHapusUniv = New System.Windows.Forms.Button
        Me.btnTambahUniv = New System.Windows.Forms.Button
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.btnHapusKrit = New System.Windows.Forms.Button
        Me.btnTambahKrit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnKluarAdmin = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 310)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pengaturan Kriteria dan Universitas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnHapusUniv)
        Me.GroupBox3.Controls.Add(Me.btnTambahUniv)
        Me.GroupBox3.Controls.Add(Me.ListBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(318, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(282, 255)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Universitas"
        '
        'btnHapusUniv
        '
        Me.btnHapusUniv.Location = New System.Drawing.Point(190, 217)
        Me.btnHapusUniv.Name = "btnHapusUniv"
        Me.btnHapusUniv.Size = New System.Drawing.Size(75, 23)
        Me.btnHapusUniv.TabIndex = 4
        Me.btnHapusUniv.Text = "&Hapus"
        Me.btnHapusUniv.UseVisualStyleBackColor = True
        '
        'btnTambahUniv
        '
        Me.btnTambahUniv.Location = New System.Drawing.Point(101, 217)
        Me.btnTambahUniv.Name = "btnTambahUniv"
        Me.btnTambahUniv.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahUniv.TabIndex = 3
        Me.btnTambahUniv.Text = "&Tambah"
        Me.btnTambahUniv.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(17, 22)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(248, 186)
        Me.ListBox2.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.btnHapusKrit)
        Me.GroupBox2.Controls.Add(Me.btnTambahKrit)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 255)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kriteria"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(17, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 186)
        Me.ListBox1.TabIndex = 3
        '
        'btnHapusKrit
        '
        Me.btnHapusKrit.Location = New System.Drawing.Point(190, 217)
        Me.btnHapusKrit.Name = "btnHapusKrit"
        Me.btnHapusKrit.Size = New System.Drawing.Size(75, 23)
        Me.btnHapusKrit.TabIndex = 1
        Me.btnHapusKrit.Text = "&Hapus"
        Me.btnHapusKrit.UseVisualStyleBackColor = True
        '
        'btnTambahKrit
        '
        Me.btnTambahKrit.Location = New System.Drawing.Point(101, 217)
        Me.btnTambahKrit.Name = "btnTambahKrit"
        Me.btnTambahKrit.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahKrit.TabIndex = 0
        Me.btnTambahKrit.Text = "&Tambah"
        Me.btnTambahKrit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome Admin..."
        '
        'btnKluarAdmin
        '
        Me.btnKluarAdmin.Location = New System.Drawing.Point(575, 405)
        Me.btnKluarAdmin.Name = "btnKluarAdmin"
        Me.btnKluarAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btnKluarAdmin.TabIndex = 2
        Me.btnKluarAdmin.Text = "&Keluar"
        Me.btnKluarAdmin.UseVisualStyleBackColor = True
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 440)
        Me.Controls.Add(Me.btnKluarAdmin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAdmin"
        Me.Text = "Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnKluarAdmin As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnHapusKrit As System.Windows.Forms.Button
    Friend WithEvents btnTambahKrit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnHapusUniv As System.Windows.Forms.Button
    Friend WithEvents btnTambahUniv As System.Windows.Forms.Button
End Class
