<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Cqu._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="Login">
        <h1>注册账号并获取令牌</h1>
        <p class="lead">本站许多api需要一个令牌才能访问（请不要尝试使用逆向api）</p>
        <p><a href="/Login.aspx" class="btn btn-primary btn-lg">登陆</a></p>
        <br/>
        <p><a href="/Reg.aspx" class="btn btn-primary btn-lg">注册</a></p>
    </div>
    <div class="jumbotron">
        <h1>关于我们</h1>
        <p class="lead">哇哇原来这里还能写简介欸，我以前都不知道</p>
        <p><a href="/About.aspx" class="btn btn-primary btn-lg">加入我们</a></p>
    </div>

</asp:Content>
