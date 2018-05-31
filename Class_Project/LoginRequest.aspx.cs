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
        if (Page.IsValid)
        {
            SQLLoginRequest request = new SQLLoginRequest(TbUserName.Text, TbEmail.Text, TbLoginName.Text, RadioButtonListAccount.SelectedValue, TbMessage.Text, TbDatePicker.Text);
            request.ExecuteSproc();
            if (request.IsSuccessful)
            {
                LbSuccessMessage.Text = "Request has been submitted";
            }
            else
            {
                LbSuccessMessage.Text = "Request was not submitted - something must have gone wrong";
            }

        }

    }

}