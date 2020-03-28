Imports System.Runtime.InteropServices

Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub PasswordRecovery1_SendingMail(sender As Object, e As MailMessageEventArgs) Handles PasswordRecovery1.SendingMail

    End Sub
    Public Event cao(sender As Object, e As EventArgs)
    Private Sub PasswordRecovery1_VerifyingAnswer(sender As Object, e As LoginCancelEventArgs) Handles PasswordRecovery1.VerifyingAnswer
        Dim ee As String = PasswordRecovery1.Answer
        For Each usr In Users
            If usr.SafeAnswer.ToLower() = ee.ToLower() Then
                e.Cancel = True
            End If
        Next
    End Sub

    Private Sub PasswordRecovery1_VerifyingUser(sender As Object, e As LoginCancelEventArgs) Handles PasswordRecovery1.VerifyingUser
        Dim ee As String = PasswordRecovery1.UserName
        For Each usr In Users
            If usr.SafeAnswer.ToLower() = ee.ToLower() Then
                e.Cancel = True
            End If
        Next
    End Sub
End Class