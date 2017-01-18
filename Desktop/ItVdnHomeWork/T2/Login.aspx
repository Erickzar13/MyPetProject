<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="T2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Логин <asp:TextBox ID="LoginTextBox" runat="server" />
        <br />
        Пароль <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server" />
        <br />
        <asp:Button ID="LoginButton" Text="Вход" runat="server" OnClick="LoginButton_Click" />
        <br />
        <asp:Label ID="ErrorLabel" runat="server" Text="Логин или пароль введены не правильно!" ForeColor="Red" Visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>

