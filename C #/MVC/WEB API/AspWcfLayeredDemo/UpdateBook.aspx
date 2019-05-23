<%@ Page Title="" Language="C#" MasterPageFile="~/BMS.Master" AutoEventWireup="true" CodeBehind="UpdateBook.aspx.cs" Inherits="AspWcfLayeredDemo.UpdateBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="width: 70%">
    <tr>
        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblUpdate" runat="server" Text="UpdateBookDetails"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 62px">
            <asp:Label ID="lblBookID" runat="server" Text="BookID"></asp:Label>
        </td>
        <td style="width: 229px">
            <asp:TextBox ID="txtBookid" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 62px">
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
        </td>
        <td style="width: 229px">
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 62px">
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
        </td>
        <td style="width: 229px">
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 62px">
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
        </td>
        <td style="width: 229px">
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 62px">
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
        </td>
        <td style="width: 229px">
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
