Public Class GuLang_Tr
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim wawwa As String = TextBox1.Text.Trim(" "c)
        If wawwa = "" Then
            Response.Write("<script>alert(" & Chr(34) & "你输入空文本干啥？" & Chr(34) & ");</script>")
        Else
            TextBox2.Text = ChineseToGu(wawwa, TextBox3.Text.Trim(" "))
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wawwa As String = TextBox1.Text.Trim(" "c)
        If wawwa = "" Then
            Response.Write("<script>alert(" & Chr(34) & "你输入空文本干啥？" & Chr(34) & ");</script>")
        ElseIf Not (wawwa.StartsWith("咕~")) Then
            Response.Write("<script>alert(" & Chr(34) & "这是咕语？？？？" & Chr(34) & ");</script>")
        Else
            TextBox2.Text = GuToChinese(wawwa, TextBox3.Text.Trim(" "))
        End If
    End Sub
End Class