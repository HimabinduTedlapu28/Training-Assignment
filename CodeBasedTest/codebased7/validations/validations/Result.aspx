<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="YourNamespace.Result" %>

<!DOCTYPE html>
<html>
<head>
    <title>Result</title>
</head>
<body>
    <h1>Result Page</h1>
    <p>User Information:</p>
    <ul>
        <li>
            <strong>Name:</strong>
            <asp:Label ID="lblName" runat="server" />
        </li>
        <li>
            <strong>Family name:</strong>
            <asp:Label ID="lblfamilyname" runat="server" />
        </li>
        <li>
            <strong>Address:</strong>
            <asp:Label ID="lbladdress" runat="server" />
        </li>
        <li>
            <strong>city:</strong>
            <asp:Label ID="lblcity" runat="server" />
        </li>
        <li>
            <strong>Zipcode:</strong>
            <asp:Label ID="lblzipcode" runat="server" />
        </li>
        <li>
            <strong>email:</strong>
            <asp:Label ID="lblemail" runat="server" />
        </li>
        <li>
            <strong>Name:</strong>
            <asp:Label ID="Label6" runat="server" />
        </li>
        
    </ul>
</body>
</html>
