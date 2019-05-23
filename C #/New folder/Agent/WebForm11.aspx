<%@ Page Theme="Skin1" Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="Agent.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 117px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" BackColor="#009999" BorderColor="#009900" Font-Names="Arial" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="Red" BorderColor="#000066" Font-Names="Tahoma"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Label" BackColor="#FF33CC" BorderColor="#6666FF" Font-Names="Arial" SkinID="S1"></asp:Label>
                    </td>
                    <td>&nbsp;
                        <asp:TextBox ID="TextBox3" runat="server" BackColor="#993366" BorderColor="#3399FF" Font-Names="Arial Rounded MT Bold" SkinID="b1"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Label" SkinID="S1"></asp:Label>
                    </td>
                    <td>&nbsp;
                        <asp:TextBox ID="TextBox5" runat="server" SkinID="b1"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Button" BackColor="#660066" BorderColor="Lime" Font-Names="Arial Black" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Button" BackColor="#CC9900" BorderColor="#990000" SkinID="t1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" Text="Button" SkinID="t1" />
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
