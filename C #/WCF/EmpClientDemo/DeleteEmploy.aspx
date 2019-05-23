<%@ Page Title="" Language="C#" MasterPageFile="~/EmployCrud.Master" AutoEventWireup="true" CodeBehind="DeleteEmploy.aspx.cs" Inherits="EmpClientDemo.DeleteEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td style="width: 79px">
                <asp:Label ID="lblEmployNo" runat="server" Text="EmployNo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmployNo" runat="server" AutoPostBack="True" OnTextChanged="txtEmployNo_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <td style="width: 79px">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">
                <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">
                <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">
                <asp:Label ID="lblBasic" runat="server" Text="Basic"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 12px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
