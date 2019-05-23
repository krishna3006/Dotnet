<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginBook1.aspx.cs" Inherits="BMSWebApp.LoginBook1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="left" cellpadding="5" cellspacing="6" style="width: 70%; border-style: solid; border-width: 4px">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblUserNAme" runat="server" Text="UserName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="PassWord"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassWord" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
