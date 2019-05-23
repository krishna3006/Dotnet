<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="CalculationWebClient.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 51%;
        }
        .auto-style2 {
            width: 238px;
        }
        .auto-style3 {
            width: 183px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblFirstno" runat="server" Text="FirstNo"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtFirstno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblSecondNo" runat="server" Text="Secondno"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSecondNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSum" runat="server" OnClick="btnSum_Click" style="height: 26px" Text="Sum" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSub" runat="server" OnClick="btnSub_Click" Text="Sub" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnMult" runat="server" OnClick="btnMult_Click" Text="Mult" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
