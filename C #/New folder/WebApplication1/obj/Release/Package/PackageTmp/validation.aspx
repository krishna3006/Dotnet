<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="WebApplication1.validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="txtPassword_TextChanged" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRetypepassword" ErrorMessage="Both are equal"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblRetypePassword" runat="server" Text="Re-type Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtRetypepassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
