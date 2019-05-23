<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpCrud.aspx.cs" Inherits="Agent.EmpCrud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString %>" DeleteCommand="DELETE FROM [EMp] WHERE [Empno] = @Empno" InsertCommand="INSERT INTO [EMp] ([Empno], [nam], [dept], [desig], [basic]) VALUES (@Empno, @nam, @dept, @desig, @basic)" SelectCommand="SELECT * FROM [EMp]" UpdateCommand="UPDATE [EMp] SET [nam] = @nam, [dept] = @dept, [desig] = @desig, [basic] = @basic WHERE [Empno] = @Empno">
            <DeleteParameters>
                <asp:Parameter Name="Empno" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Empno" Type="Int32" />
                <asp:Parameter Name="nam" Type="String" />
                <asp:Parameter Name="dept" Type="String" />
                <asp:Parameter Name="desig" Type="String" />
                <asp:Parameter Name="basic" Type="Double" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="nam" Type="String" />
                <asp:Parameter Name="dept" Type="String" />
                <asp:Parameter Name="desig" Type="String" />
                <asp:Parameter Name="basic" Type="Double" />
                <asp:Parameter Name="Empno" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <div>
            <asp:FormView ID="FormView1" runat="server" DataKeyNames="Empno" DataSourceID="SqlDataSource1">
                <EditItemTemplate>
                    Empno:
                    <asp:Label ID="EmpnoLabel1" runat="server" Text='<%# Eval("Empno") %>' />
                    <br />
                    nam:
                    <asp:TextBox ID="namTextBox" runat="server" Text='<%# Bind("nam") %>' />
                    <br />
                    dept:
                    <asp:TextBox ID="deptTextBox" runat="server" Text='<%# Bind("dept") %>' />
                    <br />
                    desig:
                    <asp:TextBox ID="desigTextBox" runat="server" Text='<%# Bind("desig") %>' />
                    <br />
                    basic:
                    <asp:TextBox ID="basicTextBox" runat="server" Text='<%# Bind("basic") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    Empno:
                    <asp:TextBox ID="EmpnoTextBox" runat="server" Text='<%# Bind("Empno") %>' />
                    <br />
                    nam:
                    <asp:TextBox ID="namTextBox" runat="server" Text='<%# Bind("nam") %>' />
                    <br />
                    dept:
                    <asp:TextBox ID="deptTextBox" runat="server" Text='<%# Bind("dept") %>' />
                    <br />
                    desig:
                    <asp:TextBox ID="desigTextBox" runat="server" Text='<%# Bind("desig") %>' />
                    <br />
                    basic:
                    <asp:TextBox ID="basicTextBox" runat="server" Text='<%# Bind("basic") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    Empno:
                    <asp:Label ID="EmpnoLabel" runat="server" Text='<%# Eval("Empno") %>' />
                    <br />
                    nam:
                    <asp:Label ID="namLabel" runat="server" Text='<%# Bind("nam") %>' />
                    <br />
                    dept:
                    <asp:Label ID="deptLabel" runat="server" Text='<%# Bind("dept") %>' />
                    <br />
                    desig:
                    <asp:Label ID="desigLabel" runat="server" Text='<%# Bind("desig") %>' />
                    <br />
                    basic:
                    <asp:Label ID="basicLabel" runat="server" Text='<%# Bind("basic") %>' />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                </ItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>
