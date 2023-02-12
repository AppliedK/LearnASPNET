<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="LearnASPNET.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style1.css" rel="stylesheet" />
</head>
<body>
    <form id="formDDL" runat="server">
        <div class="cityCombobox">
            <asp:DropDownList ID="ddlCities" runat="server" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged" Width="120px" AutoPostBack="True" />
        </div>
    </form>
</body>
</html>
