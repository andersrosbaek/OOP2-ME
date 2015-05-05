<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCars.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Choose from the cars<br />
        <asp:DropDownList ID="ViewCarsDropdown" runat="server" OnSelectedIndexChanged="ViewCarsDropdown_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Model: <br />
        <asp:Label ID="ModelLabel" runat="server" Text="---"></asp:Label>
        <br />
        <br />
        Color:
        <br />
        <asp:Label ID="ColorLabel" runat="server" Text="---"></asp:Label>
        <br />
        <br />
        Price:
        <br />
        <asp:Label ID="PriceLabel" runat="server" Text="---"></asp:Label>
    
    </div>
    </form>
</body>
</html>
