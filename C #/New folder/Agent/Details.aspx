<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Agent.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString %>" SelectCommand="SELECT * FROM [EMp]"></asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="Empno" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="Empno" HeaderText="Empno" ReadOnly="True" SortExpression="Empno" />
                <asp:BoundField DataField="nam" HeaderText="nam" SortExpression="nam" />
                <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                <asp:BoundField DataField="desig" HeaderText="desig" SortExpression="desig" />
                <asp:BoundField DataField="basic" HeaderText="basic" SortExpression="basic" />
            </Fields>
        </asp:DetailsView>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Empno" DataSourceID="SqlDataSource1" PageSize="5">
            <Columns>
                <asp:BoundField DataField="Empno" HeaderText="Empno" ReadOnly="True" SortExpression="Empno" />
                <asp:BoundField DataField="nam" HeaderText="nam" SortExpression="nam" />
                <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                <asp:BoundField DataField="desig" HeaderText="desig" SortExpression="desig" />
                <asp:BoundField DataField="basic" HeaderText="basic" SortExpression="basic" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
