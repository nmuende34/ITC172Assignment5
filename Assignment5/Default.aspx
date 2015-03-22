<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style3 {
            color: white;
            width: 130px;
            border: 1px solid black;
            margin-left: 30%;
            background-color: gray;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Show Service</h1>
        <p>To add a show to the schedule you must log in or register</p>
        <table class="login">
            <tr>
                <td class="login">Venue User Name</td>
                <td class="auto-style3">
                    <asp:TextBox id="txtUserName" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="login">Venue Password</td>
                <td class="auto-style3"><asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
            <tr>
                <td class="login">
                    <asp:Button id="btnLogin" runat="server" Text="Log in" OnClick="btnLogin_Click" Width="121px" />
                </td>
                <td class="auto-style3">
                    <asp:Label id="lblError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            <p>
                <asp:LinkButton id="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">Register</asp:LinkButton>
            </p>
    </div>
    </form>
</body>
</html>