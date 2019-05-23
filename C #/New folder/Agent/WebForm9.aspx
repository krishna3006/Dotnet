<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="Agent.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString %>" DeleteCommand="DELETE FROM [Guest] WHERE [GuestID] = @GuestID" InsertCommand="INSERT INTO [Guest] ([GuestID], [GuestName], [GuestContactNumber]) VALUES (@GuestID, @GuestName, @GuestContactNumber)" SelectCommand="SELECT * FROM [Guest]" UpdateCommand="UPDATE [Guest] SET [GuestName] = @GuestName, [GuestContactNumber] = @GuestContactNumber WHERE [GuestID] = @GuestID">
            <DeleteParameters>
                <asp:Parameter Name="GuestID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="GuestID" Type="Int32" />
                <asp:Parameter Name="GuestName" Type="String" />
                <asp:Parameter Name="GuestContactNumber" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="GuestName" Type="String" />
                <asp:Parameter Name="GuestContactNumber" Type="String" />
                <asp:Parameter Name="GuestID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="GuestID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="GuestID" HeaderText="GuestID" ReadOnly="True" SortExpression="GuestID" />
                    <asp:BoundField DataField="GuestName" HeaderText="GuestName" SortExpression="GuestName" />
                    <asp:BoundField DataField="GuestContactNumber" HeaderText="GuestContactNumber" SortExpression="GuestContactNumber" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
