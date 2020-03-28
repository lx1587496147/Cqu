<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GuLangAPI.aspx.vb" Inherits="Cqu.GuLangAPI" %>

 <% If Request.Item("token") = "" Or Not (Cqu.LoginData.Tokens.Contains(Request.Item("token"))) Then
         Server.Transfer("Login")
     Else
         If Request.Item("gtc") = "" Then
             If Request.Item("ctg") = "" Then
                 Response.Write("错误:空值")
             Else
                 Response.Write(Cqu.GuModule.ChineseToGu(Request.Item("ctg"), Request.Item("pwd")))
             End If
         Else
             Response.Write(Cqu.GuModule.GuToChinese(Request.Item("gtc"), Request.Item("pwd")))
         End If
     End If %>