<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:UpdatePanel ID="updatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lblTime" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger
                        ControlID="Timer1"
                        EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>            
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <br />
            <br />
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
            </asp:Timer>          
            <br />
            <br />
        </div>
    </form>
</body>
</html>
