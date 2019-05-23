<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm13.aspx.cs" Inherits="Agent.WebForm13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" OnActiveViewChanged="MultiView1_ActiveViewChanged">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:View ID="View1" runat="server">
                    welcome to job details
                </asp:View>
                <asp:View ID="View2" runat="server">
                    welcome to academic details
                </asp:View>
                <asp:View ID="View3" runat="server">
                    welcome to personal details...Thank you
                </asp:View>
                &nbsp;
            </asp:MultiView>
        </div>
        <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick">
        </asp:Menu>
    </form>
</body>
</html>
