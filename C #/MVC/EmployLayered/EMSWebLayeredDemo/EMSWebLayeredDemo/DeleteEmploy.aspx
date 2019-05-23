<%@ Page Title="" Language="C#" MasterPageFile="~/EMS.Master" AutoEventWireup="true" CodeBehind="DeleteEmploy.aspx.cs" Inherits="EMSWebLayeredDemo.DeleteEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellpadding="5" cellspacing="5" style="width: 80%; border: 4px solid #008000">
	<tr>
		<td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="lblDeleteEmployDetails" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#660033" Text="Delete Employ Details"></asp:Label>
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblEmpno" runat="server" Text="Empno"></asp:Label>
		</td>
		<td>
			<asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Button ID="btnDeleteEmploy" runat="server" OnClick="btnDeleteEmploy_Click" Text="Delete Employ" />
		</td>
	</tr>
</table>
</asp:Content>
