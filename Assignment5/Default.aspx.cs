using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VenueRegistrationLoginService;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //instantiate the service
        VenueRegistrationLoginService.VenueRegistrationServiceClient rc = new VenueRegistrationLoginService.VenueRegistrationServiceClient();
        //call the method
        int id = rc.VenueLogin(txtUserName.Text, txtPassword.Text);
        //check the results
        if (id != 0)
        {
            Session["venuekey"] = id;
            Response.Redirect("AddShow.aspx");
        }
        else
        {
            lblError.Text = "Invalid Login";
        }

    }
}