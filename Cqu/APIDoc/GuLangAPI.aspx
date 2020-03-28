<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GuLangAPI.aspx.vb" Inherits="Cqu.GuLangAPI1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>API使用教程:</h1>
    <a>GULangAPI.aspx?token=<% Response.Write(IIf(Request.Item("token") = "", "（你的Token）", Request.Item("token"))) %>&xxx</a>
    <h2>例子:</h2>
    <a>GULangAPI.aspx?token=<% Response.Write(IIf(Request.Item("token") = "", "（你的Token）", Request.Item("token"))) %>&ctg=呵呵呵</a>
    <br/>
    <p>返回:<% Response.Write(Cqu.ChineseToGu("呵呵呵")) %></p>
    <a>GULangAPI.aspx?token=<% Response.Write(IIf(Request.Item("token") = "", "（你的Token）", Request.Item("token"))) %>&amp;gtc=<% Response.Write(Cqu.ChineseToGu("哈哈哈")) %></a>
    <br/>
    <p>返回:哈哈哈</p>
</asp:Content>
