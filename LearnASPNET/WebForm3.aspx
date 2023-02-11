<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="LearnASPNET.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="FilesListBox" runat="server" CssClass="listedFiles" /> <br/>
            <asp:Button ID="DeleteFile" runat="server" Text="Delete File" OnClick="DeleteFile_Click" />
        </div>
        <hr />
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple ="true" />
            <asp:Button ID="UploadButton" runat="server" Text="Upload" OnClick ="UploadButton_Click" />
            
        </div>
    </form>
</body>
</html>
