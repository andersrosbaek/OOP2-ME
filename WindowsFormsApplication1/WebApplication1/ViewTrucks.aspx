<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTrucks.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
    
        Here you can see each of our available Trucks:<br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
       If you wish to delete one of the trucks, select its ID in the field below and press delete:<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back to Main" />
    
    </div>
    </form>
</body>
</html>
