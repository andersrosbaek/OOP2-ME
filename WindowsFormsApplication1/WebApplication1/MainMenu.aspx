<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 193px">
    
        <asp:Label ID="Label1" runat="server" Font-Size="24pt" Text="Welcome to the WebApplication of CarDealer"></asp:Label>
        <br />
        <br />
        Here you can view our catalogue of cars!
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View and edit cars" Width="200px" />
        <br />
    
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View and edit trucks" Width="200px" />
    
        <br />
    
    </div>
    </form>
</body>
</html>
