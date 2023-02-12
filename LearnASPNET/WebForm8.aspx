<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="LearnASPNET.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LEARN ABOUT PREVIOUS AND CURRENT PAGE</h1>
            <p>PrevoiusPage class can be obtained</p>
            <p>We move from WebForm8 to WebForm9 and then WebForm8 is previous page for WebForm9.</p>
        </div>
        <div>
            <asp:TextBox ID="prevTB" runat="server" />
            <asp:Button ID="ButtonPrev" runat="server" Text="Fill textbox and Click to Go to Next Page" PostBackUrl="~/WebForm9.aspx" />
        </div>
    </form>
</body>
</html>
