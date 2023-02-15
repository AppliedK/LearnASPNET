<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm21.aspx.cs" Inherits="LearnASPNET.WebForm21" %>
<%@ Register TagPrefix ="ajeet" Namespace="LearnASPNET" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" TextMode ="MultiLine" Height ="55" Width="300"></asp:TextBox>
            <br />
            <%--<ajeet:LengthValidator ID="CustomLengthValidator" runat="server" 
                ErrorMessage="Length Validator"></ajeet:LengthValidator>--%>
        </div>
    </form>
</body>
</html>
