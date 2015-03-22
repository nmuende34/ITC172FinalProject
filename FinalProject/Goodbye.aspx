﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Goodbye.aspx.cs" Inherits="Goodbye" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Goodbye!</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="goodbye" runat="server">
    <div>
    <h2>Thanks for checking in on your favorite Artists!</h2>
        <asp:LinkButton id="lblLogin3" runat="server" PostBackUrl="~/Login.aspx" CausesValidation="false" OnClick="lblLogin3_Click">Log in Again</asp:LinkButton>
    </div>
    </form>
</body>
</html>
