using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LbtHome_Click(object sender, EventArgs e)
    {
        String URL = "~/Home.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }

    protected void LbtSignIn_Click(object sender, EventArgs e)
    {
        String URL = "~/SignIn.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }

    protected void LbtClasses_Click(object sender, EventArgs e)
    {
        String URL = "~/Classes.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }

    protected void LbtRegistration_Click(object sender, EventArgs e)
    {
        String URL = "~/Registration.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }

    protected void LbtMyClasses_Click(object sender, EventArgs e)
    {
        String URL = "~/MyClasses.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }
}
