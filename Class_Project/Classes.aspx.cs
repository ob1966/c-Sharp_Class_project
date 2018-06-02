using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Classes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable classData = AppControl.GetListOfClasses();
        foreach (DataRow classRow in classData.Rows)
        {
            LbClassList.Text += "<p>" + classRow.Field<string>(0) + classRow.Field<string>(1) + classRow.Field<string>(2) + classRow.Field<string>(3) + "</p>";
        }
    }
}