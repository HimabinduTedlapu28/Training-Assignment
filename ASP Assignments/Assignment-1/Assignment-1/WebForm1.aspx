<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Super Cars</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Select a car:<asp:DropDownList ID ="Dplist1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Dplist1_SelectedIndexChanged">
            <asp:ListItem ID ="Audi" Value="Audi" ></asp:ListItem>
            <asp:ListItem ID ="Ferrari" Value="Ferrari"></asp:ListItem>
            <asp:ListItem ID="BUgatti" Value="Bugatti"></asp:ListItem>
            <asp:ListItem ID="Lambo" Value="Lambo"></asp:ListItem>

                     </asp:DropDownList>
         <br />

        <asp:Button ID="Btncost" runat="server" Text="cost" />
        <br />
        <asp:Image ID="Img1" runat="server" Width="200" Height="200" />
        <br />
        <asp:Label ID="btnlbl" runat="server" Text=""></asp:Label>
        <br />

    </form>
</body>
</html>
