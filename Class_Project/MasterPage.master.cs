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

    protected void lbtHome_Click(object sender, EventArgs e)
    {
        String URL = "~/Home.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }

    protected void lbtSignIn_Click(object sender, EventArgs e)
    {
        String URL = "~/SignIn.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }

    protected void lbtClasses_Click(object sender, EventArgs e)
    {
        String URL = "~/Classes.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }

    protected void lbtRegistration_Click(object sender, EventArgs e)
    {
        String URL = "~/Registration.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }

    protected void lbtMyClasses_Click(object sender, EventArgs e)
    {
        String URL = "~/MyClasses.aspx"; // Name the content file to load
        Response.Redirect(URL, false);
    }
}
