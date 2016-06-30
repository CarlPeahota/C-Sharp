<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MyFirstWebApp.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <p>Registration Page</p>
    <a href ="Default.aspx">Home</a> | <a href ="#">Registration</a>
    <form id="form1" runat="server">
    <div>
    
        <p>Enter First Name</p>
        <asp:TextBox ID="firstnameTextBox" Text="" runat="server" />
        <p>Enter Last Name</p>
        <asp:TextBox ID="lastnameTextBox" Text="" runat="server" />

        <asp:Button ID="registerButton" Text="REGISTER" runat="server" OnClick="registerEventMethod" />

    </div>
    </form>
</body>
</html>
