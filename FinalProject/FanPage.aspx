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
        <asp:DataList id="DataList1" runat="server">
            <ItemTemplate>
                <h2>
                    <asp:Label id="lblName" runat="server" Text='<%# Eval("ArtistName") %>'></asp:Label></h2>
                <p>
                    <strong>Email: <asp:Label id="Label1" runat="server" Text='<%#Eval("ArtistEmail") %>'></asp:Label></strong> <br />
                    Webpage: <asp:Label id="Label2" runat="server" Text='<%#Eval("ArtistWebPage") %>'>'</asp:Label> <br />
                </p>
            </ItemTemplate>
        </asp:DataList>
         <p><asp:LinkButton id="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton></p>
    </div>
    </form>
</body>
</html>
