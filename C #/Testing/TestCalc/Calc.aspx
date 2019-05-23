<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="TestCalc.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 63%;
        }
        .auto-style2 {
            width: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblFirstNo" runat="server" Text="First Number"></asp:Label>
                    </td>
                    <td>&nbsp;&nbsp;
                        <asp:TextBox ID="txtFirstNo" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstNo" ErrorMessage="Please Enter First No"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblSeondNo" runat="server" Text="Second Number"></asp:Label>
                    </td>
                    <td>&nbsp;&nbsp;
                        <asp:TextBox ID="txtSecondNo" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSecondNo" ErrorMessage="Please Enter Second No"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
                    </td>
                    <td>&nbsp;&nbsp;
                        <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;
                        <asp:Button ID="btnSum" runat="server" OnClick="btnSum_Click" Text="Sum" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
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
