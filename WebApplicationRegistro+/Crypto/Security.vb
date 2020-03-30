Public Class Security
    Public Function Crypt(ByVal passw As String) As String
        Dim hash As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(passw)
        ByteString = hash.ComputeHash(ByteString)

        Dim finalString As String = Nothing

        For Each bt As Byte In ByteString
            finalString &= bt.ToString("x2")
        Next
        Return finalString
    End Function


End Class
