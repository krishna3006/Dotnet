<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpSearch.aspx.cs" Inherits="Searchemp.EmpSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 195px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;<asp:Label ID="lblEmployNo" runat="server" Text="EmployNo"></asp:Label>
                        &nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtEmployno" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;<asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                        &nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;<asp:Label ID="lblDept" runat="server" Text="Department"></asp:Label>
                        &nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label>
                    </td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtDesig" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblbasic" runat="server" Text="Basic"></asp:Label>
                    </td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;
                        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
