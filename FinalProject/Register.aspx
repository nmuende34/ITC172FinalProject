<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Fan Registration</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Fan Tracking Registration</h1>
        <table style="margin-left: 440px" >
            <tr>
                <td class="marg40" >Fan Name</td>
                <td><asp:TextBox id="txtFanName" runat="server"></asp:TextBox></td>
                <td class="marg40"><asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Your name is required" ControlToValidate="txtFanName" class="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="marg40" >Email</td>
                <td><asp:TextBox id="txtEmail" runat="server"></asp:TextBox></td>
                <td class="marg40"><asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server" ErrorMessage="Email is required" ControlToValidate="txtEmail" class="error"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ErrorMessage="Not a valid email" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" class="error"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="marg40" >Fan User Name</td>
                <td><asp:TextBox id="txtUserName" runat="server"></asp:TextBox></td>
                <td class="marg40"><asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server" ErrorMessage="User name is required" ControlToValidate="txtUserName" class="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="marg40" >Fan Password</td>
                <td><asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                <td class="marg40"><asp:RequiredFieldValidator id="RequiredFieldValidator9" runat="server" ErrorMessage="Please enter a password" ControlToValidate="txtPassword" class="error"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="marg40" >Confirm Password</td>
                <td><asp:TextBox id="txtConfirm" runat="server" TextMode="Password"></asp:TextBox></td>
                <td class="marg40"><asp:RequiredFieldValidator id="RequiredFieldValidator10" runat="server" ErrorMessage="You must confirm the password" ControlToValidate="txtConfirm" class="error"></asp:RequiredFieldValidator>
                    <asp:CompareValidator id="CompareValidator1" runat="server" ErrorMessage="Does not match" ControlToCompare="txtPassword" ControlToValidate="txtConfirm" class="error"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="marg40"><asp:Button id="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" Width="126px" /></td>
                <td class="error"><asp:Label id="lblResult" runat="server" Text="" class="error"></asp:Label></td>
            </tr>
        </table>
        <br />
    </div>
        <p style="margin-left: 600px; margin-top: 5px">
        <asp:LinkButton id="lbLogin" runat="server" PostBackUrl="~/Login.aspx" CausesValidation="false">Log in</asp:LinkButton>
        </p>
    </form>
</body>
</html>