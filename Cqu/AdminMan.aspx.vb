Public Class AdminMan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem Is Nothing Then
            Response.Write("<script>alert('eee');window.opener.location.href=window.opener.location.href;</script>")
        End If
    End Sub
End Class