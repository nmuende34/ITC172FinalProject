using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FanRegistrationLoginService;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //instantiate service
        FanRegistrationLoginService.FanRegistrationLoginServiceClient frc = new FanRegistrationLoginService.FanRegistrationLoginServiceClient();

        //create an instance of Fanlite class from our data Contract
        FanRegistrationLoginService.FanLite fanlite = new FanRegistrationLoginService.FanLite();

        //assign text box content to the reviewerlite properties
        fanlite.FanName = txtFanName.Text;
        fanlite.FanEmail = txtEmail.Text;

        FanRegistrationLoginService.FanLogin flog = new FanRegistrationLoginService.FanLogin();
        flog.FanLoginUserName = txtUserName.Text;
        flog.FanLoginPasswordPlain = txtConfirm.Text;
        flog.FanLoginDateAdded = DateTime.Now;

        //call the register method in the service
        bool result = frc.RegisterFan(fanlite, flog);

        //check the results
        if (result)
        {
            lblResult.Text = "You have succesfully Registered";
        }
        else
        {
            lblResult.Text = "Registration Failed";
        }
    }
}