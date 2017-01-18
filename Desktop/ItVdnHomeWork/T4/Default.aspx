<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="T4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txbFirstName" runat="server"></asp:TextBox>
        
        <br />
        <asp:Button ID="btnGoNext" runat="server" OnClick="btnGoNext_Click" Text="Go Next" />
    
        

    </div>
    </form>
</body>
</html>
