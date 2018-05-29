﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyClasses : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!AppControl.IsUserLoggedIn())
        {
            String URL = "~/LoginRequest.aspx";
            Response.Redirect(URL, false);
        }
    }
}