﻿using System;
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
}