Public Module LoginData
    Public Tokens As New List(Of String)
    Public Users As New List(Of User)
    Public Structure User
        Public Password, Username, SafeAsk, SafeAnswer, Email As String
        Public IsDisable As Boolean
    End Structure
    Public AdminPassword As String = "Admin"
End Module
Public Class _Default
    Inherits Page

    Protected Sub Login1_LoginError1(sender As Object, e As EventArgs)

    End Sub

    Private Sub _Default_Init(sender As Object, e As EventArgs) Handles Me.Init
        If Request.Item("Id") = "" Then
            Server.Transfer("Default.aspx?Id=" & Rnd() * 314159)
        End If
    End Sub
End Class