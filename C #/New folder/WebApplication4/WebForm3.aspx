<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 127px;
        }
        .auto-style3 {
            width: 127px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="dept" DataValueField="dept">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="nam">
                        </asp:DropDownList>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Empno" DataValueField="Empno">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblBasic" runat="server" Text="Basic"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Empno" DataValueField="Empno">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString %>" SelectCommand="SELECT * FROM [EMp]"></asp:SqlDataSource>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
