<%@ Page Title="" Language="C#" MasterPageFile="~/Masterdb.Master" AutoEventWireup="true" CodeBehind="AgentPage.aspx.cs" Inherits="WebApplication1.AgentPage" %>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <table align="center" class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:LinkButton ID="lnkAgent" runat="server" OnClick="lnkAgent_Click">Agent</asp:LinkButton>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:LinkButton ID="lnkPolicy" runat="server" OnClick="lnkPolicy_Click">Policy</asp:LinkButton>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:LinkButton ID="lnkEmp" runat="server" OnClick="lnkEmp_Click">Emp</asp:LinkButton>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

