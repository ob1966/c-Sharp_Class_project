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
            foreach (DataRow classRow in myClasses.Rows)
            {
                LbMyClasses.Text += "<p>" + classRow.Field<string>(0) + classRow.Field<string>(1) + classRow.Field<string>(2) + classRow.Field<string>(3) + "</p>";
            }
        }


    }
}