<%@ Page Title="" Language="C#" MasterPageFile="~/EMS.Master" AutoEventWireup="true" CodeBehind="SearchEmploy.aspx.cs" Inherits="EMSWebLayeredDemo.SearchEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellpadding="5" cellspacing="5" style="width: 80%; border: 3px solid #008080">
		<tr>
			<td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Label ID="lblSearchEmployDetails" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#CC00CC" Text="Search Employ Details"></asp:Label>
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
				<asp:Button ID="btnSearchEmploy" runat="server" OnClick="btnSearchEmploy_Click" Text="Search Employ" />
			</td>
		</tr>
	</table>
</asp:Content>
