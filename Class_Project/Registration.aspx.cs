﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!AppControl.IsUserLoggedIn())
        {
            String URL = "~/SignIn.aspx";
            Response.Redirect(URL, false);
        }
    }

    protected void BtFindClass_Click(object sender, EventArgs e)
    {
        HiddenFieldClassID.Value = TbClassID.Text;
        DataTable classData = AppControl.GetListOfClasses();
        LbClass.Text = "";
        foreach (DataRow classRow in classData.Rows)
        {
            if (TbClassID.Text == classRow.Field<string>(0))
            {
                LbClass.Text += "<p>" + classRow.Field<string>(0) + " | " + classRow.Field<string>(1) + " | " + classRow.Field<string>(2) + " | " + classRow.Field<string>(3) + "</p>";
            }
        }
    }

    protected void BtRegister_Click(object sender, EventArgs e)
    {
        if (LbClass.Text != "")
            AppControl.RegsiterForClass(Int32.Parse(HiddenFieldClassID.Value), ((User)Session["AuthenticatedUser"]).UserId);
    }

}