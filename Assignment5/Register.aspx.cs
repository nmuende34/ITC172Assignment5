    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using VenueRegistrationLoginService;

    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //instantiate service
            VenueRegistrationLoginService.VenueRegistrationServiceClient rc = new VenueRegistrationLoginService.VenueRegistrationServiceClient();

            //create an instance of venuelite class from our data Contract
            VenueRegistrationLoginService.VenueLite venlite = new VenueRegistrationLoginService.VenueLite();

            //assign text box content to the reviewerlite properties
            venlite.venueName = txtVenueName.Text;
            venlite.Email = txtEmail.Text;
            venlite.VenueAddress = txtAddress.Text;
            venlite.VenueCity = txtCity.Text;
            venlite.VenueState = txtState.Text;
            venlite.VenueZip = txtZip.Text;
            venlite.VenuePhone = txtPhone.Text;
            venlite.VenueWebsite = txtWebsite.Text;
            venlite.VenueAgeRestriction = int.Parse(txtAge.Text);

            VenueRegistrationLoginService.VenueLogin vlog = new VenueRegistrationLoginService.VenueLogin();
            vlog.VenueLoginUserName = txtUserName.Text;
            vlog.VenueLoginPasswordPlain = txtConfirm.Text;
            vlog.VenueLoginDateAdded = DateTime.Now;

            //call the register method in the service
            bool result = rc.RegisterVenue(venlite, vlog);

            //check the results
            if (result)
            {
                lblResult.Text = "You have succesfully Registered";
            }
            else
            {
                lblResult.Text = "Registration Failed";
            }
        }
    }