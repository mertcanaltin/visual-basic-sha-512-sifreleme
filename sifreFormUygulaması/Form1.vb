Imports Sifrelemeİslemleri
Public Class Form1
    Private Sub SifreleButton1_Click(sender As Object, e As EventArgs) Handles SifreleButton1.Click
        Dim Password As String = sifreTextBox1.Text
        Dim hashSifre As String
        Dim Sifrelemeyap As New Sifreİslemleri
        hashSifre = Sifrelemeyap.Sifreleme(Password, YeniCheckBox1.Checked, 7)
        sifreTextBox1.Text = Password
        sha512TextBox2.Text = hashSifre
    End Sub

    Private Sub YeniCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles YeniCheckBox1.CheckedChanged
        sifreTextBox1.ReadOnly = YeniCheckBox1.Checked

    End Sub
End Class
