<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm20.aspx.cs" Inherits="LearnASPNET.WebForm20" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Label ID ="dateLbl" runat="server"/>
            <br />
            Question1: What is sum of 2 and 3?<br/>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
            Question2: What is color of water?<br/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
            <br />
            <asp:CustomValidator ID="TimeValidator" runat="server" ErrorMessage="You failed to solve within 10 seconds." OnServerValidate="TimeValidator_ServerValidate"></asp:CustomValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Time Test" />
        </div>
    </form>
</body>
</html>
