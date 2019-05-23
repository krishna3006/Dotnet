<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchBook.aspx.cs" Inherits="BookWebApiClient.SearchBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function searchBook()
        {
            $.getJSON("http://localhost:49249/api/Books/" 
                + $("#<%=txtBookID.ClientID%>").val(),
                function (data) {
                    
                    $("#<%=txtName.ClientID%>").val(data.Name);
                    $("#<%=txtPrice.ClientID%>").val(data.Price);
                    $("#<%=txtDescription.ClientID%>").val(data.Description)
                });

            //return false;
        }
        $(document).ready(function () {
            $("#btnSearch").click(searchBook);
        })
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="lblBookID" runat="server" Text="Book ID"></asp:Label>
			<br />
			<asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
			<input id="btnSearch" class="auto-style1" type="button" value="Search" /><br />
			<asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
			<br />
			<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
			<br />
			<asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
			<br />
			<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
			<br />
			<asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
			<br />
			<asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
