<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomeValidator.aspx.cs" Inherits="Custom_Validator.CustomeValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function ValidateName(arc, val) {
            var name;
            name = val.Value;
            if (name.length >= 3 && name.length <= 6)
                val.IsValid = true;
            else
                val.IsValid = false;
        }
        </script>    
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 138px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblCustomValidator" runat="server" Text="CustomValidator"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    &nbsp;
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Type between 3 to 6 chars"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
