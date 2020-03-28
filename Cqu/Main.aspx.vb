Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Tokens.Contains(Request.Item("Token")) Then

        Else
            Response.ClearContent()
            Response.Write("<p>Http400请求无效错误:<br/>Token不正确</p>")
            Response.End()
        End If
    End Sub
    Public Sub Eunmapp()
        Dim fd2 As New IO.DirectoryInfo(Server.HtmlEncode(Request.PhysicalApplicationPath) & "Site1\Apps")
        For Each fdss In fd2.EnumerateFiles()
            If fdss.Extension = ".aspx" Then
                Response.Write(String.Format("<p><a href=" & Chr(34) & "{1}" & Chr(34) & " class=" & Chr(34) & "btn btn-primary btn-lg" & Chr(34) & ">{0}</a></p>", fdss.Name.Replace(".aspx", ""), "Site1/Apps/" & fdss.Name))
            End If
        Next
    End Sub
    Public Sub Eunmapi()
        Dim fd As New IO.DirectoryInfo(Server.HtmlEncode(Request.PhysicalApplicationPath) & "Site1\APIs")
        For Each fdss In fd.EnumerateFiles()
            If fdss.Extension = ".aspx" Then
                Response.Write(String.Format("<p><a href=" & Chr(34) & "{1}" & Chr(34) & " class=" & Chr(34) & "btn btn-primary btn-lg" & Chr(34) & ">{0}</a></p>", fdss.Name.Replace(".aspx", ""), "Site1/APIs/" & fdss.Name))
                Response.Write(String.Format("<p><a href=" & Chr(34) & "{1}" & Chr(34) & " class=" & Chr(34) & "btn btn-primary btn-lg" & Chr(34) & ">{0}</a></p>", fdss.Name.Replace(".aspx", "") & "帮助", "APIDoc/" & fdss.Name))
            End If
        Next
    End Sub
    Protected Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Request.Cookies.Remove("token")
        Tokens.Remove(Request.Item("token"))
        Server.Transfer("login.aspx")
    End Sub
End Class