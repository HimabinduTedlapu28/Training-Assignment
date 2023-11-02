<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validations.aspx.cs" Inherits="validations.validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> Form</h1>   
        
        
         Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server">             
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                 ControlToValidate="txtname" ErrorMessage="Name Cannot be Blank" 
                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
        family Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server">             
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                 ControlToValidate="txtname" ErrorMessage="Name Cannot be Blank" 
                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
        
         Address : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server">             
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                 ControlToValidate="txtfamilyname" ErrorMessage="Address Cannot be Blank" 
                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
        
         city : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server">             
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                 ControlToValidate="txtcity" ErrorMessage="city Cannot be Blank" 
                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
        
         zipcode : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server">             
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                 ControlToValidate="txtzipcode" ErrorMessage="Zipcode Cannot be Blank" 
                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
        phone : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server">             
            </asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                 ControlToValidate="txtphone" ErrorMessage="phone Cannot be Blank" 
                 Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
        Email  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtmail" ErrorMessage="Email is required" Font-Bold="True" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <br />
        <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />

         
        
        
        
    </form>
</body>
</html>
