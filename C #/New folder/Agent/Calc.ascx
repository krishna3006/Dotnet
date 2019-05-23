<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calc.ascx.cs" Inherits="Agent.Calc" %>
<style type="text/css">
    .auto-style1 {
        width: 50%;
        float: left;
        height: 102px;
    }
    .auto-style2 {
        width: 77px;
    }
</style>

<table align="left" class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblFirstno" runat="server" Text="Firstno"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFirstno" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblSecondno" runat="server" Text="Secondno"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSecondno" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnSum" runat="server" OnClick="btnSum_Click" Text="Sum" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSub" runat="server" OnClick="btnSub_Click" Text="Sub" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnMult" runat="server" OnClick="btnMult_Click" Text="Mult" />
        </td>
    </tr>
</table>

