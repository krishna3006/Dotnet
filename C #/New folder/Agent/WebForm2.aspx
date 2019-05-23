<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Agent.WebForm2" %>

<%@ Register src="Calc.ascx" tagname="Calc" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Calc ID="Calc1" runat="server" Label1Firstnumber="fno" />
        </div>
    </form>
</body>
</html>
