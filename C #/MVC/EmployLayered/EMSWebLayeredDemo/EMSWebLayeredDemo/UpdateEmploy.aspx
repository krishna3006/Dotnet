<%@ Page Title="" Language="C#" MasterPageFile="~/EMS.Master" AutoEventWireup="true" CodeBehind="UpdateEmploy.aspx.cs" Inherits="EMSWebLayeredDemo.UpdateEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellpadding="5" cellspacing="6" style="width: 70%; border: 1px solid #800080">
		<tr>
			<td colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Label ID="lblUpdateEmployDetails" runat="server" Font-Bold="True" Font-Italic="True" Text="Update Employ Details"></asp:Label>
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label ID="lblEmpno" runat="server" Text="Empno"></asp:Label>
			</td>
			<td colspan="2">
				<asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
			</td>
			<td>
				<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
			</td>
			<td>
				<asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label ID="lblDept" runat="server" Text="Dept"></asp:Label>
			</td>
			<td colspan="2">
				<asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label ID="lblDesig" runat="server" Text="Desig"></asp:Label>
			</td>
			<td colspan="2">
				<asp:TextBox ID="txtDesig" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label ID="lblBasic" runat="server" Text="Basic"></asp:Label>
			</td>
			<td colspan="2">
				<asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>
				<asp:Button ID="btnUpdateEmploy" runat="server"  Text="Update Employ" OnClick="btnUpdateEmploy_Click1" />
				<br />
				<br />
				<asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
			</td>
			<td colspan="2">&nbsp;</td>
		</tr>
	</table>
</asp:Content>
