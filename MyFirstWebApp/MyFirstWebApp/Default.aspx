<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default</title>
</head>
<body>
    <p>Default Page</p>
    <a href ="#">Home</a> | <a href ="Registration.aspx">Registration</a>
    <form id="form1" runat="server">
    <div>
        <p>Enter User Name</p>
        <asp:TextBox ID="UserNameTextbox" Text ="Enter User Name here" runat ="server" />
        <p>Enter Password</p>
        <asp:TextBox ID="TextBox1" Text ="Enter User Name here" runat ="server" />

        <asp:Button ID="submitButton" Text="Log In" runat="server" OnClick="submitEventMethod" />
    </div>
    </form>
</body>
</html>
