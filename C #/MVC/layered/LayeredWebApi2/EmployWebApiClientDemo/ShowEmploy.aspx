<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEmploy.aspx.cs" Inherits="EmployWebApiClientDemo.ShowEmploy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function GetEMps()
        {
            $.getJSON("http://localhost:62391/api/EMps",
                function (data) {
                    $('#EMps').empty();
                    $.each(data, function (key, val) {
                        var row = '<tr><td>' + val.Empno + '</td><td>' + val.nam + '</td><td>' + val.dept+ '</td><td>' + val.desig + '</td><td>' + val.basic + '</td></tr>';
                        // $('<tr/>', { text: row }).appendTo($('#EMps'));
                        $('#EMps').append(row);
                    });
                });                
        }
        $(document).ready(GetEMps);
    </script>
    <title></title>
</head>
<body>
   
        <div>
        <table class="table">
        <thead>
            <tr>
                <th>Empno</th>
                <th>nam</th>
                <th>dept</th>
                <th>desig</th>
                <th>basic</th>
            </tr>
        </thead>
        <tbody id="EMps">
                
        </tbody>
    </table>
        </div>
 
</body>
</html>