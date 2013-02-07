<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xFormInfoPreferensi
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
        Me.lblAngka = New System.Windows.Forms.Label
        Me.lblInfo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblAngka
        '
        Me.lblAngka.AutoSize = True
        Me.lblAngka.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngka.Location = New System.Drawing.Point(108, 9)
        Me.lblAngka.Name = "lblAngka"
        Me.lblAngka.Size = New System.Drawing.Size(30, 31)
        Me.lblAngka.TabIndex = 0
        Me.lblAngka.Text = "1"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(15, 52)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(39, 13)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Label1"
        '
        'FormInfoPreferensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 161)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblAngka)
        Me.Name = "FormInfoPreferensi"
        Me.Text = "FormInfoPreferensi"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAngka As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
End Class
