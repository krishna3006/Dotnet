<%@ Page Title="" Language="C#" MasterPageFile="~/BMS.Master" AutoEventWireup="true" CodeBehind="SearchBook.aspx.cs" Inherits="AspWcfLayeredDemo.SearchBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table align="left" cellpadding="5" cellspacing="5" style="width: 101%; height: 213px; border: 1px solid #800080; margin-bottom: 0px">
		<tr>
			<td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Label ID="lblSearchBookDetails" runat="server" Font-Bold="True" ForeColor="#FF3399" Text="Search Book Details"></asp:Label>
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label ID="lblBookID" runat="server" Text="Book ID"></asp:Label>
			</td>
			<td style="width: 241px">
				<asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
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
				<asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
			</td>
			<td>
				<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
			</td>
			<td>
				<asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td colspan="2">
				<asp:Button ID="btnSearchBook" runat="server" OnClick="btnSearchBook_Click" Text="Search Book" />
			</td>
		</tr>
	</table>
</asp:Content>
