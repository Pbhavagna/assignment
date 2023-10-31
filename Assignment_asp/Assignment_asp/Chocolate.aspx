<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chocolate.aspx.cs" Inherits="Assignment_asp.Chocolate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <h1> Chocolate:</h1>
            <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
                <asp:ListItem Text="Choose a chocolate" Value="0" />
                <asp:ListItem Text="Dairy Milk" Value="1"  />
                <asp:ListItem Text="5 Star" Value="2"  />
                <asp:ListItem Text="Kit Kat" Value="3"  />
                <asp:ListItem Text="Snickers" Value="4"  />

            </asp:DropDownList>
            <br /><br />

            <asp:Image ID="imgItem"  runat="server"  />

            <br /><br />

            <asp:Button ID="btnShowCost" runat="server" Text="Show Cost" OnClick="btnShowCost_Click" />
            <br /><br />

            <asp:Label ID="lblCost" runat="server" Text="" />
        </div>
    </form>
</body>
</html>