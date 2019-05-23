<%@ Page Title="" Language="C#" MasterPageFile="~/Demo.Master" AutoEventWireup="true" CodeBehind="Logindemo.aspx.cs" Inherits="WebApplication1.Logindemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="Login1" runat="server" Height="116px" OnAuthenticate="Login1_Authenticate" Width="183px">
</asp:Login>
</asp:Content>
