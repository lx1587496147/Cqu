Public Class Reg
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub CreateUserWizard1_CreatingUser(sender As Object, e As LoginCancelEventArgs) Handles CreateUserWizard1.CreatingUser
        Dim ctl As CreateUserWizard = CreateUserWizard1
        Dim username As String = ctl.UserName
        Dim password As String = ctl.Password
        Dim Email As String = ctl.Email
        Dim SafeAsk As String = ctl.Question
        Dim SafeAnswer As String = ctl.Answer
        Dim nuser As New User()
        nuser.Username = username
        nuser.Password = password
        nuser.SafeAsk = SafeAsk
        nuser.SafeAnswer = SafeAnswer
        nuser.Email = Email
        Users.Add(nuser)
        e.Cancel = False
        Server.Transfer("Login.aspx")
    End Sub

    Private Sub CreateUserWizard1_SendingMail(sender As Object, e As MailMessageEventArgs) Handles CreateUserWizard1.SendingMail

    End Sub
End Class