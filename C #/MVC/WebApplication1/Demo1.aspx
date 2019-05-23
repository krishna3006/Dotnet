<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo1.aspx.cs" Inherits="WebApplication1.Demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 59px">
    <form id="form1" runat="server">
        <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
        <div>
            <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
        </div>
    </form>
</body>
</html>
