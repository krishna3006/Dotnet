<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Empno" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Empno" HeaderText="Empno" ReadOnly="True" SortExpression="Empno" />
                <asp:BoundField DataField="nam" HeaderText="nam" SortExpression="nam" />
                <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                <asp:BoundField DataField="desig" HeaderText="desig" SortExpression="desig" />
                <asp:BoundField DataField="basic" HeaderText="basic" SortExpression="basic" />
            </Columns>
        </asp:GridView>
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString %>" SelectCommand="SELECT * FROM [EMp]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
