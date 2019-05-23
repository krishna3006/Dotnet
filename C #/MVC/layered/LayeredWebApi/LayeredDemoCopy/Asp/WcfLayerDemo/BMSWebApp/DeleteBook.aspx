<%@ Page Title="" Language="C#" MasterPageFile="~/BookManagementSystem.Master" AutoEventWireup="true" CodeBehind="DeleteBook.aspx.cs" Inherits="BMSWebApp.DeleteBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="left" cellpadding="5" cellspacing="5" style="width: 70%; border-style: solid; border-width: 5px">
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Underline="True" Text="Delete Book Details"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblBookid" runat="server" Text="Book ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="Delete Book" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
