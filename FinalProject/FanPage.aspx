<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanPage.aspx.cs" Inherits="FanPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fan Prefernces</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    </head>
<body>
    <div id="form">
    <form id="form1" runat="server">
    <h1>Welcome to Preference Selection!&nbsp;&nbsp;&nbsp; </h1>
        <p style="text-align:center">
            Check out the list of Artists and Genres in our Database.<br />Submit your preferences in the form below.</p>
          <div id="preferenceForm">
                <p class="marg360">Select your Favorite Artist.
                    <asp:DropDownList id="DropDownListArtist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListArtist_SelectedIndexChanged"></asp:DropDownList>
                </p>
                <p class="marg360">Select your Favorite Genre
                    <asp:DropDownList id="DropDownListGenre" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListGenre_SelectedIndexChanged"></asp:DropDownList>
                </p>
                <p class="marg480"><asp:LinkButton id="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
                </p>
          </div>
        <div id="yourPreferences" hidden="true">
            <!--couldn't get service for returning preferences to work. They would display here if working-->
            <p class="marg40"><asp:Label id="prefs" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div id="artistPreference">
        <asp:DataList id="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" DataKeyField="ArtistName" style="margin-left: 186px" Width="225px">
            <ItemTemplate>
                <table>
                <tr>
                    <td><h2><asp:Label ID="followCheck" runat="server" Text='<%# Eval("ArtistName") %>' /></h2></td>
                </tr>
                <tr>
                    <td><strong>Email: <asp:Label id="Label1" runat="server" Text='<%#Eval("ArtistEmail") %>'></asp:Label></strong></td> 
                </tr>
                <tr>
                    <td>Webpage: <asp:Label id="Label2" runat="server" Text='<%#Eval("ArtistWebPage") %>'>'</asp:Label></td>
                </tr>
                    </table>
            </ItemTemplate>
        </asp:DataList>
            <p>&nbsp;</p>
        </div><!--end artistPrefer-->
        <div id="genrePreference">
            <asp:DataList id="DataList2" runat="server" OnSelectedIndexChanged="DataList2_SelectedIndexChanged">
            <ItemTemplate>
                <table>
                     <tr><td><h2><asp:Label id="followCheck2" runat="server" Text='<%# Eval("GenreName") %>' /></h2></td></tr>
                    <tr>
                        <td>Genre Description: <asp:Label id="Label1" runat="server" Text='<%#Eval("GenreDescription") %>'></asp:Label></td> 
                    </tr>
                </table>
             </ItemTemplate>
            </asp:DataList>
        </div>
   </form>
    </div>
</body>
</html>
