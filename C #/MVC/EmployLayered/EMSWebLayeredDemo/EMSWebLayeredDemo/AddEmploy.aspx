<%@ Page Title="" Language="C#" MasterPageFile="~/EMS.Master" AutoEventWireup="true" CodeBehind="AddEmploy.aspx.cs" Inherits="EMSWebLayeredDemo.AddEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellpadding="5" cellspacing="6" style="width: 80%; border: 5px solid #FF0000">
	<tr>
		<td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#000066" Text="Add Book Details"></asp:Label>
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
		<td>
			<asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
		</td>
		<td>
			<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblDept" runat="server" Text="Dept"></asp:Label>
		</td>
		<td>
			<asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblDesig" runat="server" Text="Desig"></asp:Label>
		</td>
		<td>
			<asp:TextBox ID="txtDesig" runat="server"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblBasic" runat="server" Text="Basic"></asp:Label>
		</td>
		<td>
			<asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Button ID="btnAddEmploy" runat="server" OnClick="btnAddEmploy_Click" Text="Add Employ" />
			<br />
			<br />
			<asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
		</td>
	</tr>
</table>
</asp:Content>
