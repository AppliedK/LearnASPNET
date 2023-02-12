<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="LearnASPNET.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Enter numbers in text box controls</p>
            <h1>SEND DATA AS PART OF QUERY STRING</h1>
            <asp:TextBox ID="firstnumTB" runat="server" />
            <br />
            <asp:TextBox ID="secondnumTB" runat="server" />
            <asp:Button ID="SumButton" runat="server" Text="SUM" OnClick="SumButton_Click"/>
            <asp:Button ID="ResultSum" runat="server" Text="Query String" OnClick="Result_Click" />
        </div>
    </form>
</body>
</html>
