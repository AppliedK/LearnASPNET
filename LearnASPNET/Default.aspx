<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LearnASPNET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server"  AllowMultiple="true" BackColor="Green" />
            <asp:Button ID="UploadButton" runat="server" Text="Upload Files" OnClick="UploadButton_Click" />
            <h1>This is a default webpage.</h1>
        </div>
    </form>
</body>
</html>
