<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="LearnASPNET.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function Welcome() {
            alert("Hello friend. have a good day!");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>USER REGISTRATION FORM</h1>
            <asp:Label ID="FirstNameLabel" runat="server" Text="First Name" AssociatedControlID="FirstNameTB" />
            <asp:TextBox ID="FirstNameTB" runat="server" />
            <br />
            <asp:Label ID="LastNameLabel" runat="server" Text="Last Name" AssociatedControlID="LastNameTB" />
            <asp:TextBox ID="LastNameTB" runat="server" />
            <br />
            <asp:Label ID="GenderLabel" runat="server" Text="Select Gender" />
            <asp:RadioButton ID="MaleRdo" runat="server" Text="Male" GroupName="Gender"/>
            <asp:RadioButton ID="FemaleRdo" runat="server" Text="female" GroupName="Gender"/>
            <br />
            <asp:Label ID="CityLabel" runat="server" Text="Select City" />
            <asp:DropDownList ID="CityDDL" runat="server" />
        </div>
        <br />
        <hr />
        <div>
            <h1> LEARN ABOUT THREE TYPES OF ASP.NET BUTTONS</h1>
            <ul>
                <li>Button: This is push button used to submit form to the server.</li>
                <li>ImageButton</li>
                <li>LinkButton</li>
            </ul>
            <br />
            <p>By default, Button clicks reloads the page but by using PostBackUrl, we can redirect to another page.</p>
            <asp:Button ID="Button1" runat="server" Text="Button: Go to default page" PostBackUrl="~/Default.aspx" />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="Welcome()" Height="100" Width="75" ImageUrl="~/Test/happy.jpg" BorderColor="BlueViolet"/>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="alert('This is client side scripting code.')">LinkButton</asp:LinkButton>



        </div>
    </form>
</body>
</html>
