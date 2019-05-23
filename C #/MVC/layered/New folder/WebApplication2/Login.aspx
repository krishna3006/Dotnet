<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>
<%@OutputCache Duration="60" VaryByParam="none" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
