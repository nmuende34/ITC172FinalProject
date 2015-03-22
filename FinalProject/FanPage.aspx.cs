using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using FanTrackingService;

public partial class FanPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["FanKey"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        FillArtists();
    }
    private void FillArtists()
    {
       // FanTrackingServiceClient fsc = new FanTrackingShowServiceClient();
        int key = (int)Session["FanKey"];
       // List<Artist> artists = fsc.GetArtists(key).ToList();
       // DataList1.DataSource = artists;
       // DataList1.DataBind();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["FanKey"] = 0;
        Response.Redirect("Goodbye.aspx");
    }
}