<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fan Login Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="auto-style2">Welcome Fans</h1>
    <div>
        <p class="auto-style1">Please Login or Register to start following your favorite artists</p>
        <table class="login">
            <tr>
                <td class="login">Fan User Name</td>
                <td >
                    <asp:TextBox id="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="login">Fan Password</td>
                <td><asp:TextBox id="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
            <tr>
                <td class="login">
                    &nbsp;</td>
                <td>
                    <asp:Button id="btnLogin" runat="server" Text="Log in" OnClick="btnLogin_Click" />
                </td>
            </tr>
            <tr>
                <td class="login">
                    &nbsp;</td>
                <td>
                    <asp:Label id="lblError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
            <p class="marg560">
                <asp:LinkButton id="LinkButton1" runat="server" PostBackUrl="~/Register.aspx" class="error">Register</asp:LinkButton>
            </p>
    </div>
    </form>
</body>
</html>
