<%@ Page Title="" Language="C#" MasterPageFile="~/EmployCrud.Master" AutoEventWireup="true" CodeBehind="UpdateEmploy.aspx.cs" Inherits="EmpClientDemo.UpdateEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td style="width: 91px">
                <asp:Label ID="lblEmployno" runat="server" Text="EmployNo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmployno" runat="server" AutoPostBack="True" OnTextChanged="txtEmployno_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 91px">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 91px">
                <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 91px">
                <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 91px">
                <asp:Label ID="lblBasic" runat="server" Text="Basic"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            </td>
        </tr>
    </table>
</asp:Content>
