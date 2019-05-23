<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regularexp.aspx.cs" Inherits="WebApplication2.Regularexp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblRegularexpressionValidator" runat="server" Text="Regular Expression Validator"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPincode" runat="server" Text="Pincode"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtPincode" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPincode" ErrorMessage="Invalid Pincode Format" ValidationExpression="^\d{6}$"></asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address"></asp:Label>
&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtEmailaddress" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmailaddress" ErrorMessage="Invali Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblWebsiteAddress" runat="server" Text="Website Address"></asp:Label>
&nbsp;&nbsp;
                        <asp:TextBox ID="txtWebsiteAddress" runat="server"></asp:TextBox>
&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtWebsiteAddress" ErrorMessage="Invalid URL" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Height="30px" Text="Submit" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
