<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GuLang.aspx.vb" Inherits="Cqu.GuLang_Tr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>咕语翻译器Web版</h2>
    <asp:TextBox ID="TextBox1" runat="server" Height="128px" Width="212px"></asp:TextBox><br/>
    <asp:Button ID="Button1" runat="server" Text="翻译成中文" Width="105px" /><asp:Button ID="Button2" runat="server" Text="翻译成咕语" Width="105px" /><br/>
    <asp:Label ID="Label1" runat="server" Text="密码（默认为空）:"></asp:Label><br/>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
    <asp:Label ID="Label2" runat="server" Text="结果"></asp:Label><br>
    <asp:TextBox ID="TextBox2" runat="server" Height="119px" Width="216px"></asp:TextBox>
</asp:Content>
