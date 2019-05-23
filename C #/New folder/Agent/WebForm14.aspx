<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm14.aspx.cs" Inherits="Agent.WebForm14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 112px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblFirstname" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblSecondname" runat="server" Text="SecondName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSecondname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnRedirect" runat="server" OnClick="btnRedirect_Click" Text="Redirect" />
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
