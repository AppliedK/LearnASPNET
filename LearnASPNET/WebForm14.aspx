<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm14.aspx.cs" Inherits="LearnASPNET.WebForm14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl ="~/Test/rectangle.png" HotSpotMode="PostBack" OnClick ="ImageMap1_Click">
                <asp:RectangleHotSpot PostBackValue ="A" Left="0" Top="0" Right="50" Bottom="50" />
                <asp:RectangleHotSpot PostBackValue ="B" Left="25" Top="0" Right="100" Bottom="50" />
                <asp:RectangleHotSpot PostBackValue ="C" Left="50" Top="0" Right="150" Bottom="50" />
                 <asp:RectangleHotSpot PostBackValue ="D" Left="75" Top="0" Right="200" Bottom="50" />
            </asp:ImageMap>

        </div>
    </form>
</body>
</html>
