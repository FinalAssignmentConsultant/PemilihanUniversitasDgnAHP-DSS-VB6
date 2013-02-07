<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusUniversitas
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBatalUniversitas = New System.Windows.Forms.Button
        Me.btnHapusUniversitas = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 116)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hapus Universitas"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(135, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 17)
        Me.ListBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama Universitas"
        '
        'btnBatalUniversitas
        '
        Me.btnBatalUniversitas.Location = New System.Drawing.Point(213, 148)
        Me.btnBatalUniversitas.Name = "btnBatalUniversitas"
        Me.btnBatalUniversitas.Size = New System.Drawing.Size(75, 23)
        Me.btnBatalUniversitas.TabIndex = 9
        Me.btnBatalUniversitas.Text = "&Batal"
        Me.btnBatalUniversitas.UseVisualStyleBackColor = True
        '
        'btnHapusUniversitas
        '
        Me.btnHapusUniversitas.Location = New System.Drawing.Point(132, 148)
        Me.btnHapusUniversitas.Name = "btnHapusUniversitas"
        Me.btnHapusUniversitas.Size = New System.Drawing.Size(75, 23)
        Me.btnHapusUniversitas.TabIndex = 8
        Me.btnHapusUniversitas.Text = "&Hapus"
        Me.btnHapusUniversitas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 185)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBatalUniversitas)
        Me.Controls.Add(Me.btnHapusUniversitas)
        Me.Name = "Form1"
        Me.Text = "FormHapusUniversitas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatalUniversitas As System.Windows.Forms.Button
    Friend WithEvents btnHapusUniversitas As System.Windows.Forms.Button
End Class
