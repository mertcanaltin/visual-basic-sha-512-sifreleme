Imports System.Security.Cryptography
Public Class Sifreİslemleri
    Private Function SHA_512Hash(Sifre As String) As String
        Dim hashServis As New SHA512CryptoServiceProvider
        Dim byteSifre() As Byte = Text.Encoding.UTF8.GetBytes(Sifre) 'BYTE DÖNÜŞTÜRÜR
        byteSifre = hashServis.ComputeHash(byteSifre)
        Dim Sonuc As String = Nothing
        For Each eleman As Byte In byteSifre ' byte sifre bütün elemanlar için döner 
            Sonuc &= eleman.ToString("x2") 'x2 formatı 
        Next
        Return Sonuc

    End Function

    Private Function SifreUret(Optional uzunluk As Integer = 5) As String 'option hale getirir
        Dim sıfre As String = Nothing ' geriye döndüreceğim değer 
        Dim kaynak As String = "abcdefghijklmnopstuvwxyzABCDEFGHIJKLMNOPSTUVWXYZ0123456789.,?!;"
        Dim rast As New Random
        For i = 1 To uzunluk
            sıfre &= kaynak(rast.Next(0, kaynak.Length))
        Next
        Return sıfre
    End Function

    Public Function Sifreleme(ByRef sifre As String, Optional ByVal yeni As Boolean = False, Optional ByVal uzunluk As Integer = 5) As String
        'opsiyonel değişkenler sonda tanımlanır eğer bütün parametreler opsiyonelse istediğin gibi tanımlayabilirsin 
        Dim sonuc As String
        If yeni Then
            sifre = SifreUret(uzunluk)
        End If
        sonuc = SHA_512Hash(sifre)
        Return sonuc
    End Function
End Class
