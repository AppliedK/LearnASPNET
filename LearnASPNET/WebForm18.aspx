<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm18.aspx.cs" Inherits="LearnASPNET.WebForm18" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Required Name</h3>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="nameRequiredValidator" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is required." Display="Dynamic"></asp:RequiredFieldValidator>
            <h3>Valid Email</h3>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="emailValidator" runat="server" ControlToValidate="TextBox2" ErrorMessage="Email is not valid" Display="Dynamic"></asp:RegularExpressionValidator>
            <h3>Password Length</h3>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RangeValidator ID="passwordRangeValidator" runat="server" ErrorMessage="Password Length be at least 8 characters" ControlToValidate="TextBox3" Display="Dynamic"></asp:RangeValidator>
            <h3>Compare Password</h3>
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="passwordCompareValidator" runat="server" ErrorMessage="Password mismatch" ControlToValidate="TextBox4" Display="Dynamic"></asp:CompareValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
