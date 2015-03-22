<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Show Tracking Registration</h1>
        <table class="login2">
            <tr>
                <td class="login">Venue Name</td>
                <td><asp:TextBox ID="txtVenueName" runat="server"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="The Venue name is required" ControlToValidate="txtVenueName" CssClass="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="login">Venue Address</td>
                <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Address is Required" ControlToValidate="txtAddress" CssClass="error"></asp:RequiredFieldValidator></td>
            </tr>
                        <tr>
                <td class="login">Venue City</td>
                <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="City is required" ControlToValidate="txtCity" CssClass="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="login">Venue State</td>
                <td><asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="State is Required" ControlToValidate="txtState" CssClass="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="login">Venue Zip Code</td>
                <td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="the zip code is required" ControlToValidate="txtZip" CssClass="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="login">Venue Phone</td>
                <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Phone is required" ControlToValidate="txtPhone" CssClass="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="login">Age Restriction</td>
                <td><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
                <td class="error"></td>
            </tr>
            <tr>
                <td class="login">Email</td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Email is required" ControlToValidate="txtEmail" CssClass="error"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Not a valid email" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="error"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="login">Venue Website</td>
                <td><asp:TextBox ID="txtWebsite" runat="server"></asp:TextBox></td>
                <td class="error"></td>
            </tr>
            <tr>
                <td class="login">Venue User Name</td>
                <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="User name is required" ControlToValidate="txtUserName" CssClass="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="login">Password</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please enter a password" ControlToValidate="txtPassword" CssClass="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="login">Confirm Password</td>
                <td><asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox></td>
                <td class="error"><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="You must confirm the password" ControlToValidate="txtConfirm" CssClass="error"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Does not match" ControlToCompare="txtPassword" ControlToValidate="txtConfirm" CssClass="error"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" Width="121px" /></td>
                <td class="error"><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
                <td class="error"></td>
            </tr>
        </table>
        <br />
        <asp:LinkButton ID="lbLogin" runat="server" PostBackUrl="~/Default.aspx" CausesValidation="false">Log in</asp:LinkButton>
    </div>
    </form>
</body>
</html>