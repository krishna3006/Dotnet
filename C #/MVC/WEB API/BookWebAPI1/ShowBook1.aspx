﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowBook1.aspx.cs" Inherits="BookWebAPI1.ShowBook1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
     <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function getBooks()
        {
            $.getJSON("http://localhost:57042/api/Books",
                function (data) {
                    $('#books').empty();
                    $.each(data, function (key, val) {
                        var row = '<tr><td>' + val.ID + '</td><td>' + val.Name + '</td><td>' + val.Price + '</td><td>' + val.Description + '</td></tr>';
                        // $('<tr/>', { text: row }).appendTo($('#books'));
                        $('#books').append(row);
                    });
                });                
        }
        $(document).ready(getBooks);
    </script>
    <title></title>
</head>
<body>
   
        <div>
            <table class="table">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Price</th>
                <th>Description</th>
            </tr>
        </thead>
        <tbody id="books">
                
        </tbody>
    </table>
        </div>
    
</body>
</html>
