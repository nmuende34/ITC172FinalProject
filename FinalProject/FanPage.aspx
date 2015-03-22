<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanPage.aspx.cs" Inherits="FanPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome Fan</h1>
                <h2>
                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("ArtistNsme") %>'></asp:Label></h2>
                <p>
                    <strong>Email: <asp:Label ID="Label1" runat="server" Text='<%#Eval("ArtistEmail") %>'></asp:Label></strong> <br />
                    Webpage: <asp:Label ID="Label2" runat="server" Text='<%#Eval("ArtistWebPage") %>'>'</asp:Label> <br />
                </p>
         <p><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton></p>
    </div>
    </form>
</body>
</html>
