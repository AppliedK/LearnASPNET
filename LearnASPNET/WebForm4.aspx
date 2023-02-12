<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="LearnASPNET.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <h1>Click on the image.</h1>
    </div>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="FirstButton" runat="server" Text="Click Me" OnClick="FirstButton_Click" />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Test/happy.jpg" Height="450" Width="325" OnClick="ImageButton1_Click" />
        </div>
    </form>
</body>
</html>
