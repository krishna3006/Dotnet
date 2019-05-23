<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Names.aspx.cs" Inherits="WebApplication1.Names1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 70%;
		}
		.auto-style2 {
			width: 4px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<table align="center" class="auto-style1">
				<tr>
					<td class="auto-style2">&nbsp;</td>
					<td>
						<asp:Label ID="lblSelectname" runat="server" Text="Select Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:DropDownList ID="ddlNames" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlNames_SelectedIndexChanged">
						</asp:DropDownList>
					</td>
				</tr>
				<tr>
					<td class="auto-style2">&nbsp;</td>
					<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
