<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayerInfo.aspx.cs" Inherits="WebAppAssign11aug.PlayerInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="b" OnCheckedChanged="RadioButton1_CheckedChanged" Text="CricketPlayers" />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="b" Text="TennisPlayers" OnCheckedChanged="RadioButton2_CheckedChanged" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CricketPlayers.html">Virat Kohli</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/TennisPlayer.html">Sachin Tendulkar</asp:HyperLink>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Roger Federer.html">Roger Federer</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Rafal Nadal.html">Rafal Nadal</asp:HyperLink>
        </asp:Panel>
    </form>
    
</body>
</html>
