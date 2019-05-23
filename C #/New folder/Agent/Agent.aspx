<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agent.aspx.cs" Inherits="Agent.Agent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString %>" SelectCommand="SELECT * FROM [Agent]"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AgentID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Address2" HeaderText="Address2" SortExpression="Address2" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                    <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" SortExpression="ZipCode" />
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                    <asp:BoundField DataField="InsertedOn" HeaderText="InsertedOn" SortExpression="InsertedOn" />
                    <asp:BoundField DataField="InsertedBy" HeaderText="InsertedBy" SortExpression="InsertedBy" />
                    <asp:BoundField DataField="UpdatedOn" HeaderText="UpdatedOn" SortExpression="UpdatedOn" />
                    <asp:BoundField DataField="UpdatedBy" HeaderText="UpdatedBy" SortExpression="UpdatedBy" />
                    <asp:BoundField DataField="DeletedOn" HeaderText="DeletedOn" SortExpression="DeletedOn" />
                    <asp:BoundField DataField="DeletedBy" HeaderText="DeletedBy" SortExpression="DeletedBy" />
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
