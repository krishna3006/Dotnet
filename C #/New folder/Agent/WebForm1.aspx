﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Agent.WebForm1" %>

<%@ Register src="Demo.ascx" tagname="Demo" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Demo ID="Demo1" runat="server" />
        </div>
    </form>
</body>
</html>
