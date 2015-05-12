<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 193px">
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View available cars" Width="200px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View available trucks" Width="200px" />
    
    </div>
    </form>
</body>
</html>
