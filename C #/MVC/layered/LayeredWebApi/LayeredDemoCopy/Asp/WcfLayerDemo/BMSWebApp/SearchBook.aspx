<%@ Page Title="" Language="C#" MasterPageFile="~/BookManagementSystem.Master" AutoEventWireup="true" CodeBehind="SearchBook.aspx.cs" Inherits="BMSWebApp.SearchBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="left" cellpadding="5" cellspacing="5" style="width: 70%; border-style: solid; border-width: 5px">
    <tr>
        <td colspan="2">
            <asp:Label ID="Label4" runat="server" BackColor="#CCCCFF" Font-Bold="True" Text="Search Book Details"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblBookid" runat="server" Text="Book Id"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtBookid" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblprice" runat="server" Text="Price"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDescriptiom" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnsearch" runat="server"  Text="Search Book" OnClick="btnsearch_Click" />
            &nbsp;&nbsp;
                </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
