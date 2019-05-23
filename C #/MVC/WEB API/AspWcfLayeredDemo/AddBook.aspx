<%@ Page Title="" Language="C#" MasterPageFile="~/BMS.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="AspWcfLayeredDemo.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="width: 100%">
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblAddBookDetails" runat="server" Font-Bold="True" Text="Add Book Details"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" style="width: 87px">
                <asp:Label ID="lblBookID" runat="server" Text="Book ID"></asp:Label>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtBookId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="width: 87px">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" style="width: 87px">
                <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" style="width: 87px">
                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;
                <asp:Button ID="btnAddBook" runat="server" OnClick="btnAddBook_Click" Text="Add Book" />
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
