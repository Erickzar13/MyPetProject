<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FatherName.aspx.cs" Inherits="T4.FatherName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txbFatherName" runat="server"></asp:TextBox>
    
        <br />
        <asp:Button ID="btnResult" runat="server" OnClick="btnResult_Click" Text="Get Result" />
    
    </div>
    </form>
</body>
</html>
