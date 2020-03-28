<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AdminMan.aspx.vb" Inherits="Cqu.AdminMan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>账号管理<p/>
    <br/>
    <asp:ListBox ID="ListBox1" runat="server" Height="153px" Width="258px"></asp:ListBox>
    <br/>
    <asp:Button ID="Button1" runat="server" Text="删除" Width="71px" />


    <asp:Button ID="Button2" runat="server" Text="新建" Width="76px" />



</asp:Content>
