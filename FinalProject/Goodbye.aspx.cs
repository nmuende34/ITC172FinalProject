using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Goodbye : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lblLogin3_Click(object sender, EventArgs e)
    {
        Session["FanKey"] = 0;
        Response.Redirect("Login.aspx");
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
          
    }
    protected void job_Click(object sender, EventArgs e)
    {
        string rating = RadioButtonList1.SelectedItem.ToString();
        if (rating == "Job Well Done!")
        {
            Label1.Text = "You Selected Correctly. I worked long hours to get this working!";
        }
        else if(rating == "Job Done...well...Okay!") {
            Label1.Text = "Hmm. Well, that's not the worst rating";
        }
        else if (rating == "Job doesn't seem done!")
        {
            Label1.Text = "There are a few things that don't work completely, but geez...I put a lot of work into this without any help.";
        }
        else if (rating == "Job? What job?")
        {
            Label1.Text = "That's just cruel.";
        }
        else
        {
            Label1.Text = "equaling not working";
        }
    }
}