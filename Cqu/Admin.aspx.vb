Public Class WebForm2
    Inherits System.Web.UI.Page
    Private Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        If Login1.UserName = "Admin" Then
            If Login1.Password = AdminPassword Then
                If AdminPassword = "Admin" Then
                    e.Authenticated = True
                Else
                    e.Authenticated = True
                End If
            End If
        Else
            e.Authenticated = False
        End If
    End Sub

    Private Sub Login1_LoggedIn(sender As Object, e As EventArgs) Handles Login1.LoggedIn
        Dim username As String = Login1.UserName
        Dim password As String = Login1.Password
        Tokens.Add((username.GetHashCode() Xor password.GetHashCode()).GetHashCode())
        Server.Transfer("Main.aspx?Token=" & (username.GetHashCode() Xor password.GetHashCode()).GetHashCode(), True)
    End Sub
End Class