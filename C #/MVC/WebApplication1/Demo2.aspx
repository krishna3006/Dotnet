<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo2.aspx.cs" Inherits="WebApplication1.Demo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div class="auto-style1">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
                    <br />
                    <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
                    <br />
                    <br />

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
