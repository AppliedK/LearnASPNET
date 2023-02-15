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
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="nameRequiredValidator" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is required." Display="Dynamic" EnableClientScript="False" SetFocusOnError="True"></asp:RequiredFieldValidator>
            <h3>Valid Email</h3>
            <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
            <asp:RegularExpressionValidator ID="emailValidator" runat="server" ControlToValidate="TextBox2" EnableViewState="true" ErrorMessage="Email is not valid" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" EnableClientScript="False" SetFocusOnError="True"></asp:RegularExpressionValidator>
            <h3>Password Length</h3>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" MaxLength="12" CausesValidation="True"></asp:TextBox>
            <asp:CustomValidator ID="CustomPasswdValidator" runat="server" ErrorMessage="Password Length be between 8 to 12 chars." Display="Dynamic" SetFocusOnError="True" ControlToValidate="TextBox3" OnServerValidate="PasswordLengthValidate" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator>
            <h3>Compare Password</h3>
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" CausesValidation="True" ></asp:TextBox>
            <asp:CompareValidator ID="passwordCompareValidator" runat="server" ErrorMessage="Password mismatch" ControlToValidate="TextBox4" Display="Dynamic" ControlToCompare="TextBox3" SetFocusOnError="True" EnableClientScript="False"></asp:CompareValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
