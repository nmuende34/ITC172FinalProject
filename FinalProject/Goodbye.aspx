<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Goodbye.aspx.cs" Inherits="Goodbye" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Goodbye!</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="goodbye" runat="server">
    <div style="margin-left: 120px">
    <h2 class="auto-style2">Thanks for checking in on your favorite Artists and Genres!</h2>
        <asp:LinkButton id="lblLogin3" runat="server" PostBackUrl="~/Login.aspx" CausesValidation="false" OnClick="lblLogin3_Click" class="marg480">Log in Again</asp:LinkButton>
        <br />
        <br />
    </div>
            <strong>
        <br />
        <div style="margin-left: 520px">
            <p>
                Rate the work put into this page<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Job Well Done!</asp:ListItem>
                <asp:ListItem>Job Done...well...Okay!</asp:ListItem>
                <asp:ListItem>Job doesn't seem done!</asp:ListItem>
                <asp:ListItem>Job? What job?</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        </strong>
        <div id="list" style="margin-left: 520px">
        </div><!--end of list-->
            <div style="margin-left: 560px">
                <br />
                <asp:Button ID="job" runat="server" Text="Submit Job Rating" OnClick="job_Click" Width="123px" />
        </div>
            <strong>
        <br />
        <asp:Label ID="Label1" runat="server" Text="" class="error"></asp:Label>
        </strong>
    </form>
</body>
</html>
