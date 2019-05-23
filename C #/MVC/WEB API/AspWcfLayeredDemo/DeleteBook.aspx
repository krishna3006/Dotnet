<%@ Page Title="" Language="C#" MasterPageFile="~/BMS.Master" AutoEventWireup="true" CodeBehind="DeleteBook.aspx.cs" Inherits="AspWcfLayeredDemo.DeleteBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="width: 70%">
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDelete" runat="server" Text="Delete Book Details"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" style="width: 114px">
                <asp:Label ID="lblBookID" runat="server" Text="Book ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="BtnDeleteBook" runat="server" OnClick="BtnDeleteBook_Click" Text="Delete Book" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="width: 114px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
