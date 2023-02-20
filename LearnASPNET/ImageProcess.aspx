<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageProcess.aspx.cs" Inherits="LearnASPNET.ImageProcess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="ImageUpload" runat="server" />
            <asp:Button ID="UploadButton" runat="server" Text="Upload" OnClick="UploadButton_Click"/>
        </div>
    </form>
</body>
</html>
