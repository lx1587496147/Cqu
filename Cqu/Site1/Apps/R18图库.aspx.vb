Imports System.Drawing
Imports System.IO

Public Class R18图库
    Inherits System.Web.UI.Page
    Public Sub Loadsetu()
        Dim random As String = CStr(Int(Rnd() * 87))
        Response.Write("<img src=" & Chr(34) & "data:image/jpeg;base64," & ImgToBase64String("D:\Lzj's Item\gua\hiahia\001\" & random & ".jpg") & Chr(34) & "/>")
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Function ImgToBase64String(Imagefilename As String) As String

        Try
            Dim bmp As Bitmap = New Bitmap(Imagefilename)
            Dim MS As MemoryStream = New MemoryStream()
            bmp.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arr(MS.Length) As Byte
            MS.Position = 0
            MS.Read(arr, 0, Int(MS.Length))
            MS.Close()
            Return Convert.ToBase64String(arr)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class