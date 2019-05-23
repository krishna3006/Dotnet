<%@ Page Title="" Language="C#" MasterPageFile="~/EmployCrud.Master" AutoEventWireup="true" CodeBehind="SearchEmploy.aspx.cs" Inherits="EmpClientDemo.SearchEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style1">
    <tr>
        <td style="width: 71px">
            <asp:Label ID="lblEmployNo" runat="server" Text="Employno"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtEmployno" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 71px">
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 71px">
            <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 71px">
            <asp:Label ID="lblDesignation" runat="server" Text="Designation "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 71px">
            <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
        </td>
    </tr>
</table>
</asp:Content>
