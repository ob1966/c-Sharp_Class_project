using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TbtSubmitRequest_Click(object sender, EventArgs e)
    {
        SQLLoginRequest request = new SQLLoginRequest(TbUserName.Text, TbEmail.Text, TbLoginName.Text, "new", TbMessage.Text, TbDatePicker.Text);
        request.ExecuteSproc();
    }
}