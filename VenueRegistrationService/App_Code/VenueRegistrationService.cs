using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VenueRegistrationService" in code, svc and config file together.
public class VenueRegistrationService : IVenueRegistrationService
{
    ShowTrackerEntities db = new ShowTrackerEntities();

    public bool RegisterVenue(VenueLite v, VenueLogin vl)
    {
        bool result = true;
        try
        {
            PasswordHash ph = new PasswordHash();
            KeyCode kc = new KeyCode();
            int code = kc.GetKeyCode();
            byte[] hashed = ph.HashIt(v.Password, code.ToString());
  
            Venue ven = new Venue();
            ven.VenueName = v.venueName;
            ven.VenueAddress = v.VenueAddress;
            ven.VenueCity = v.VenueCity;
            ven.VenueState = v.VenueState;
            ven.VenueZipCode = v.VenueZip;
            ven.VenueWebPage = v.VenueWebsite;
            ven.VenuePhone = v.VenuePhone;
            ven.VenueEmail = v.Email;
            ven.VenueDateAdded = DateTime.Now;
            ven.VenueAgeRestriction = v.VenueAgeRestriction;

            db.Venues.Add(ven);
            db.SaveChanges();
            
            VenueLogin venl = new VenueLogin();
            venl.Venue = ven;
            venl.VenueLoginUserName = vl.VenueLoginUserName;
            venl.VenueLoginPasswordPlain = vl.VenueLoginPasswordPlain;
            venl.VenueLoginRandom = code;
            venl.VenueLoginHashed = hashed;
            venl.VenueLoginDateAdded = DateTime.Now;

            db.VenueLogins.Add(venl);
            db.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }

    public int VenueLogin(string userName, string Password)
    {
        int id = 0;

        LoginClass lc = new LoginClass(Password, userName);
        id = lc.ValidateLogin();
        /*LoginHistory lh = new LoginHistory();
        lh.LoginHistoryDateTime = DateTime.Now;
        lh.UserName = userName;

        db.LoginHistories.Add(lh);*/

        db.SaveChanges();

        return id;
    }
}
