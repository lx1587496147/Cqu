Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.Item("Guest") = "True" Then
            Dim cookie As New HttpCookie("Token")
            cookie.Value = ("Guest".GetHashCode() Xor Int(Rnd() * 315512)).GetHashCode()
            cookie.Expires = Date.Now + New TimeSpan(1, 0, 0)
            Response.Cookies.Add(cookie)
            Tokens.Add(cookie.Value)
            Server.Transfer("Main.aspx", True)
        End If
    End Sub

    Private Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        Dim username As String = Login1.UserName
        Dim password As String = Login1.Password
        e.Authenticated = False
        For Each usr In Users
            If usr.Password = password Then
                If usr.Username = username Then
                    If usr.IsDisable Then
                        Response.Write("<script>alert(" & Chr(34) & "你的账号被禁用了:(" & Chr(34) & ");</script>")
                    Else
                        Dim cookie As New HttpCookie("Token")
                        cookie.Value = (username.GetHashCode() Xor password.GetHashCode()).GetHashCode()
                        cookie.Expires = Date.Now + New TimeSpan(128, 0, 0)
                        Response.Cookies.Add(cookie)
                        e.Authenticated = True
                        Exit For
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Login1_LoggedIn(sender As Object, e As EventArgs) Handles Login1.LoggedIn
        Dim username As String = Login1.UserName
        Dim password As String = Login1.Password
        Tokens.Add((username.GetHashCode() Xor password.GetHashCode()).GetHashCode())
        Server.Transfer("Main.aspx?Token=" & (username.GetHashCode() Xor password.GetHashCode()).GetHashCode(), True)
    End Sub

End Class