using System;
using System.Data;
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
            String URL = "~/SignIn.aspx";
            Response.Redirect(URL, false);
        }
        else
        {
            int userId = ((User)Session["AuthenticatedUser"]).UserId;
            DataTable myClasses = AppControl.RetrieveMyClasses(userId);
            if (myClasses.Rows.Count < 1) LbNoClasses.Text = "(No Registered Classes)";
        }
    }
}