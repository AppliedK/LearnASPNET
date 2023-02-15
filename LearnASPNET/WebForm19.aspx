<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm19.aspx.cs" Inherits="LearnASPNET.WebForm19" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>CUSTOM VALIDATOR - CHECK LENGTH OF THE COMMENT</h1>
            <asp:TextBox ID="CommentTB" runat="server" TextMode="MultiLine" Height="30" Width="200" />
            <asp:CustomValidator ID="CommentLengthValidator" runat="server" ErrorMessage="Comment length must be 1 or more characters but less than 20 characters." ControlToValidate="CommentTB" ValidateEmptyText="true" OnServerValidate="CommentLengthValidator_ServerValidate"></asp:CustomValidator>
            <br />
            <asp:Button ID="ButtonC" runat="server"  Text="Click"/>
        </div>
    </form>
</body>
</html>
