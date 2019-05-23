<%@ Page Title="" Language="C#" MasterPageFile="~/BMS.Master" AutoEventWireup="true" CodeBehind="Delete Book.aspx.cs" Inherits="AspWcfLayeredDemo.Delete_Book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table align="center" cellpadding="5" cellspacing="6" style="width: 80%; border: 1px solid #808000">
		<tr>
			<td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Label ID="lblDeleteBookDetails" runat="server" Font-Bold="True" ForeColor="#FF3300" Text="Delete Book Details"></asp:Label>
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label ID="lblBookID" runat="server" Text="Book ID"></asp:Label>
			</td>
			<td>
				<asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
			</td>
		</tr>
		<tr>
			<td colspan="2">
				<asp:Button ID="btnDeleteBook" runat="server" OnClick="btnDeleteBook_Click" Text="Delete Book" />
			</td>
		</tr>
	</table>
</asp:Content>
