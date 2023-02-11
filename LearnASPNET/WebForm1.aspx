<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LearnASPNET.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is WebForm1. Learn About Send Email.
            <asp:Button ID="EmailButton" runat="server" Text="Send Email" OnClick="EmailButton_Click" />
        </div>
    </form>
</body>
</html>
