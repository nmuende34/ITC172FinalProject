<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fan Login Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome Fans</h1>
        <p>Please Login or Register to start following your favorite artists</p>
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
                    <asp:Button id="btnLogin" runat="server" Text="Log in" OnClick="btnLogin_Click" />
                </td>
                <td>
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
