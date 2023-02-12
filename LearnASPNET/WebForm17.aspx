<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm17.aspx.cs" Inherits="LearnASPNET.WebForm17" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label AssociatedControlID ="TextBox1" ID="lblx" Text="Enter a number" runat="server" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field Validator" ControlToValidate="TextBox1" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Range Validator" ControlToValidate="TextBox1" MinimumValue="2" MaximumValue="9" Display="Dynamic">></asp:RangeValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Click" />
        </div>
    </form>
</body>
</html>
