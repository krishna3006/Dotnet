<%@ Page Title="" Language="C#" MasterPageFile="~/BMS.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="AspWcfLayeredDemo.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table align="center" style="width: 72%; height: 138px; border: 1px solid #800000">
		<tr>
			<td colspan="2">
				<asp:Label ID="lblAddBookdetails" runat="server" Text="Add Book Details"></asp:Label>
			</td>
		</tr>
		<tr>
			<td style="width: 192px">
				<asp:Label ID="lblBookID" runat="server" Text="Book ID"></asp:Label>
			</td>
			<td style="width: 194px">
				<asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 192px">
				<asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
			</td>
			<td style="width: 194px">
				<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 192px">
				<asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
			</td>
			<td style="width: 194px">
				<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td style="width: 192px">
				<asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
			</td>
			<td style="width: 194px">
				<asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td colspan="2">
				<asp:Button ID="btnAddBook" runat="server" OnClick="btnAddBook_Click" Text="Add Book" />
				<br />
				<br />
				<asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
			</td>
		</tr>
	</table>
</asp:Content>
