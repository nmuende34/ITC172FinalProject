using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArtistTrackingService;

public partial class FanPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["FanKey"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        ArtistTrackingServiceClient asc = new ArtistTrackingServiceClient();
        int key = (int)Session["FanKey"];
        List<Artist> arts = asc.GetArtists().ToList();
        //did not get method working to display if preferences already chosen
        /*string aprf = asc.GetPrefs(key).ToString();*/
        
        FillArtists();
        FillGenres();
        FillDropDownListArtist();
        FillDropDownListGenre();
        /*FillPreferences(aprf); 
         *did not get method working to display if preferences already chosen
         */
    }

    private void FillArtists()
    {
        ArtistTrackingServiceClient atsc = new ArtistTrackingServiceClient();
        int key = (int)Session["FanKey"];
        List<Artist> artists = atsc.GetArtists().ToList();
        DataList1.DataSource = artists;
        DataList1.DataBind();

    }
    private void FillGenres()
    {
        ArtistTrackingServiceClient atsc = new ArtistTrackingServiceClient();
        int key = (int)Session["FanKey"];
        List<Genre> genres = atsc.GetGenres().ToList();
        DataList2.DataSource = genres;
        DataList2.DataBind();

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["FanKey"] = 0;
        Response.Redirect("Goodbye.aspx");
    }
    private void FillDropDownListArtist()
    {
        ArtistTrackingServiceClient asc = new ArtistTrackingServiceClient();
        int key = (int)Session["FanKey"];
        List<Artist> artists = asc.GetArtists().ToList();
        DropDownListArtist.DataSource = artists;
        DropDownListArtist.DataTextField = "ArtistName";
        DropDownListArtist.DataValueField = "ArtistKey";
        DropDownListArtist.DataBind();
    }

    protected void DropDownListArtist_SelectedIndexChanged(object sender, EventArgs e)
    {
        prefs.Text = DropDownListArtist.SelectedItem.ToString();

        ArtistTrackingServiceClient ast = new ArtistTrackingServiceClient();
        int fan = (int)Session["FanKey"];
        int artist = int.Parse(DropDownListArtist.SelectedValue.ToString());
        ast.FollowArtist(artist, fan);

    }

    private void FillDropDownListGenre()
    {
        ArtistTrackingServiceClient asc = new ArtistTrackingServiceClient();
        int key = (int)Session["FanKey"];
        List<Genre> genres = asc.GetGenres().ToList();
        DropDownListGenre.DataSource = genres;
        DropDownListGenre.DataTextField = "GenreName";
        DropDownListGenre.DataValueField = "GenreKey";
        DropDownListGenre.DataBind();
    }
    protected void DropDownListGenre_SelectedIndexChanged(object sender, EventArgs e)
    {
        ArtistTrackingServiceClient ast = new ArtistTrackingServiceClient();
        int fan = (int)Session["FanKey"];
        int genre = int.Parse(DropDownListArtist.SelectedValue.ToString());
        ast.FollowGenre(genre, fan);
    }
    /* method for fillingin the preferences pulled, but could not get the service figured out
    private void FillPreferences(string aprf)
    {
        prefs.Text = aprf;
    }*/
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

}