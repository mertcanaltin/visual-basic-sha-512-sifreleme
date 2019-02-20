<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.sifreTextBox1 = New System.Windows.Forms.TextBox()
        Me.sha512TextBox2 = New System.Windows.Forms.TextBox()
        Me.SifreleButton1 = New System.Windows.Forms.Button()
        Me.YeniCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sifre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SHA512"
        '
        'sifreTextBox1
        '
        Me.sifreTextBox1.Location = New System.Drawing.Point(9, 50)
        Me.sifreTextBox1.Name = "sifreTextBox1"
        Me.sifreTextBox1.Size = New System.Drawing.Size(356, 20)
        Me.sifreTextBox1.TabIndex = 2
        '
        'sha512TextBox2
        '
        Me.sha512TextBox2.Location = New System.Drawing.Point(9, 103)
        Me.sha512TextBox2.Multiline = True
        Me.sha512TextBox2.Name = "sha512TextBox2"
        Me.sha512TextBox2.Size = New System.Drawing.Size(356, 140)
        Me.sha512TextBox2.TabIndex = 3
        '
        'SifreleButton1
        '
        Me.SifreleButton1.Location = New System.Drawing.Point(109, 274)
        Me.SifreleButton1.Name = "SifreleButton1"
        Me.SifreleButton1.Size = New System.Drawing.Size(178, 56)
        Me.SifreleButton1.TabIndex = 4
        Me.SifreleButton1.Text = "Şifrele"
        Me.SifreleButton1.UseVisualStyleBackColor = True
        '
        'YeniCheckBox1
        '
        Me.YeniCheckBox1.AutoSize = True
        Me.YeniCheckBox1.Location = New System.Drawing.Point(271, 12)
        Me.YeniCheckBox1.Name = "YeniCheckBox1"
        Me.YeniCheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.YeniCheckBox1.TabIndex = 5
        Me.YeniCheckBox1.Text = "Yeni Şifre Üret"
        Me.YeniCheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 342)
        Me.Controls.Add(Me.YeniCheckBox1)
        Me.Controls.Add(Me.SifreleButton1)
        Me.Controls.Add(Me.sha512TextBox2)
        Me.Controls.Add(Me.sifreTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sifreleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sifreTextBox1 As TextBox
    Friend WithEvents sha512TextBox2 As TextBox
    Friend WithEvents SifreleButton1 As Button
    Friend WithEvents YeniCheckBox1 As CheckBox
End Class
