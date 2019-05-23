<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTime" runat="server" Text="Label"></asp:Label>
        <br />
        <div>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
            </asp:Timer>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
        </div>
    </form>
</body>
</html>
