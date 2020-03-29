Public Class 叽叽喳喳语
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim text1 As String = Trim(TextBox1.Text).Replace("喳", "0").Replace("叽", "1")
            Dim text2 As String = TextBox3.Text
            Dim array As String() = Split(text1, " ")
            Dim mb(array.Length - 1) As Byte
            For i = 0 To array.Length - 1
                mb(i) = Convert.ToByte(array(i), 2)
            Next
            If text2 = "" Then
                TextBox2.Text = Encoding.Default.GetString(mb)
            End If
        Catch
            TextBox2.Text = "错误"
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim text1 As String = Trim(TextBox1.Text)
            Dim text2 As String = TextBox3.Text
            Dim mb As Byte() = Encoding.Default.GetBytes(text1)
            Dim strbulider As New StringBuilder()
            For Each wa In mb
                Dim temp As String = Convert.ToString(wa, 2).Replace("0", "喳").Replace("1", "叽")
                strbulider.Append(temp & " ")
            Next
            If text2 = "" Then
                TextBox2.Text = strbulider.ToString()
            End If
        Catch
            TextBox2.Text = "错误"
        End Try
    End Sub
End Class