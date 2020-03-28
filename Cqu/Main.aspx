<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Main.aspx.vb" Inherits="Cqu.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%Response.Write("你的Token是" & Request.Item("token")) %>
    <p>下列是可用的API</p>
    <div class="Apis">
        <% Eunmapi()
            %>
    </div>
    <br/>
    <p>下列是可用的APP</p>
    <div class="Apps">
        <% Eunmapp()%>
    </div>
    <br/>
    <br/>
    <br/>
    <asp:button ID="Logout" Text="注销" class="btn btn-primary btn-lg" runat="server" />
</asp:Content>
