<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SQImage.aspx.vb" Inherits="Cqu.SQImage" %>
<% If Request.Item("token") = "" Or Not (Cqu.LoginData.Tokens.Contains(Request.Item("token"))) Then
        Server.Transfer("Login")
    End If%>
<%  Dim random As String = CStr(Int(Rnd() * 87))
    Response.ContentType = "application/x-zip-compressed"
    Response.AddHeader("Content-Disposition", "attachment;filename=setu.jpg")
    Response.TransmitFile("D:\Lzj's Item\gua\hiahia\001\" & random & ".jpg")%>
