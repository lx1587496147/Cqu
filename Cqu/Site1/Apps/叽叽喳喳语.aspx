<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="叽叽喳喳语.aspx.vb" Inherits="Cqu.叽叽喳喳语" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>叽叽喳喳语翻译器Web版</h2>
    <asp:TextBox ID="TextBox1" runat="server" Height="128px" Width="212px"></asp:TextBox><br/>
    <asp:Button ID="Button1" runat="server" Text="翻译成中文" Width="105px" /><asp:Button ID="Button2" runat="server" Text="翻译成叽叽喳喳语" Width="135px" /><br/>
    <asp:Label ID="Label1" runat="server" Text="密码（默认为空）:"></asp:Label><br/>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
    <asp:Label ID="Label2" runat="server" Text="结果"></asp:Label><br>
    <asp:TextBox ID="TextBox2" runat="server" Height="119px" Width="216px"></asp:TextBox>
</asp:Content>
