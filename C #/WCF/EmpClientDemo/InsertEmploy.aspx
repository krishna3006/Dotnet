<%@ Page Title="" Language="C#" MasterPageFile="~/EmployCrud.Master" AutoEventWireup="true" CodeBehind="InsertEmploy.aspx.cs" Inherits="EmpClientDemo.InsertEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td style="width: 81px">
                <asp:Label ID="lblEmployno" runat="server" Text="Employ No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmployNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 81px">
                <asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 81px">
                <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 81px">
                <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 24px; width: 81px">
                <asp:Label ID="lblBasic" runat="server" Text="Basic"></asp:Label>
            </td>
            <td style="height: 24px">
                <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
            </td>
        </tr>
    </table>
</asp:Content>
