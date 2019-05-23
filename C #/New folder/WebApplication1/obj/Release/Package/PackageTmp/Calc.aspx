<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="WebApplication1.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 57%;
			height: 146px;
		}
	    .auto-style2 {
            width: 263px;
        }
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<table align="center" class="auto-style1">
			<tr>
				<td>
					<asp:Label ID="lblFirstno" runat="server" Text="Firstno"></asp:Label>
				</td>
				<td class="auto-style2">
					<asp:TextBox ID="txtFirstno" runat="server"></asp:TextBox>
				&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstno" ErrorMessage="Please enter First number"></asp:RequiredFieldValidator>
&nbsp;
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFirstno" ErrorMessage="Between 1 and 100" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
&nbsp;</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="lblSecondno" runat="server" Text="Secondno"></asp:Label>
				</td>
				<td class="auto-style2">
					<asp:TextBox ID="txtSecondno" runat="server"></asp:TextBox>
				&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSecondno" ErrorMessage="Please enter second number"></asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtSecondno" ErrorMessage="between 1 and 100" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
				</td>
				<td class="auto-style2">
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
&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:LinkButton ID="lnkNames" runat="server" OnClick="lbNames_Click" CausesValidation="False">Names</asp:LinkButton>
				</td>
			</tr>
		</table>
    </form>
</body>
</html>
