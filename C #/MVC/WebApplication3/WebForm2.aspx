<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 372px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnShow" runat="server" Text="Show" />
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            </asp:UpdatePanel>
            <asp:Button ID="Button1" runat="server" Text="Ajax " />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            </asp:UpdatePanel>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnDate" runat="server" Text="Button" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
