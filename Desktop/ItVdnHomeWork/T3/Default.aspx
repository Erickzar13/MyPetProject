<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="T3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div style="width: 148pt; margin: auto;">        
    &nbsp;
        <asp:TextBox ID="tbxResult" runat="server" Width="90px"></asp:TextBox>
        <br />
        <asp:Button ID="btnOne" runat="server" OnClick="btnOne_Click" Text="1" />
        <asp:Button ID="btnTwo" runat="server" OnClick="btnTwo_Click" Text="2" />
        <asp:Button ID="btnThree" runat="server" OnClick="btnThree_Click" Text="3" />
        <asp:Button ID="btnPlus" runat="server" OnClick="btnPlus_Click" Text="+" />
        <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="/" Width="19px" />
        <br />
        <asp:Button ID="btnFour" runat="server" OnClick="btnFour_Click" Text="4" />
        <asp:Button ID="btnFive" runat="server" OnClick="btnFive_Click" Text="5" />
        <asp:Button ID="btnSix" runat="server" OnClick="btnSix_Click" Text="6" />
        <asp:Button ID="btnMinus" runat="server" OnClick="btnMinus_Click" Text="-" Width="22px" />
        <asp:Button ID="btnMultipl" runat="server" OnClick="btnMultipl_Click" Text="*" />
        <br />
        <asp:Button ID="btnSeven" runat="server" OnClick="btnSeven_Click" Text="7" />
        <asp:Button ID="btnEight" runat="server" OnClick="btnEight_Click" Text="8" />
        <asp:Button ID="btnNine" runat="server" OnClick="btnNine_Click" Text="9" />
        <asp:Button ID="btnEqual" runat="server" OnClick="btnEqual_Click" Text="=" Width="42px" />
        <br />
        <asp:Button ID="BtnZero" runat="server" OnClick="BtnZero_Click" Text="0" Width="63px" />
        <asp:Button ID="btnCencel" runat="server" OnClick="btnCencel_Click" Text="CE" Width="44px" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
