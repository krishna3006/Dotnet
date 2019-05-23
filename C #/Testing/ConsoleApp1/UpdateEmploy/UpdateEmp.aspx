<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateEmp.aspx.cs" Inherits="UpdateEmploy.UpdateEmp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 223px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;<table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;
                        <asp:Label ID="lblEmployno" runat="server" Text="EmployNo"></asp:Label>
                        &nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtEmployno" runat="server" AutoPostBack="True" OnTextChanged="txtEmployno_TextChanged"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;
                        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                        &nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;
                        <asp:Label ID="lblDept" runat="server" Text="Department"></asp:Label>
                        &nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;
                        <asp:Label ID="lblDesig" runat="server" Text="Designation"></asp:Label>
                        &nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtDesig" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;
                        <asp:Label ID="lblBasic" runat="server" Text="Basic"></asp:Label>
                        &nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
