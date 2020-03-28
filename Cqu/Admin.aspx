<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Admin.aspx.vb" Inherits="Cqu.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%If Cqu.LoginData.AdminPassword = "Admin" Then
            Response.Write("<h1>警告：目前管理员密码为默认密码</h1><br/>")
        End If %>
    <h1>后台管理系统</h1>
    <%Response.Write("哇哇现在是第" & CStr(Today.DayOfYear) & "天") %>
    <asp:Login ID="Login1" runat="server">
    </asp:Login>
</asp:Content>
