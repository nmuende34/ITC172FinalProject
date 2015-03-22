using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FanRegistrationLoginService;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //instantiate the service
        FanRegistrationLoginService.FanRegistrationLoginServiceClient frc = new FanRegistrationLoginService.FanRegistrationLoginServiceClient();
        //call the method
        int id = frc.FanLogin(txtUserName.Text, txtPassword.Text);
        //check the results
        if (id != 0)
        {
            Session["fankey"] = id;
            Response.Redirect("FanPage.aspx");
        }
        else
        {
            lblError.Text = "Invalid Login";
        }

    }
}