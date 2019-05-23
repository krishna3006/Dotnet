<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>
<%@ OutputCache Duration="60" VaryByParam="none" %>
<%@ Register src="Date.ascx" tagname="Date" tagprefix="uc2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnDate" runat="server" OnClick="btnDate_Click" Text="Date" />
            <br />
            <br />
            <br />
            <uc2:Date ID="Date1" runat="server" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
