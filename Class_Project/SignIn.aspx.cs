using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LbtRequestLogin_Click(object sender, EventArgs e)
    {
        String URL = "~/LoginRequest.aspx";
        Response.Redirect(URL, false);
    }

    protected void BtSignIn_Click(object sender, EventArgs e)
    {

    }
}