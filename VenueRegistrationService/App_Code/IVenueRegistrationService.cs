using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVenueRegistrationService" in both code and config file together.
[ServiceContract]
public interface IVenueRegistrationService
{
    [OperationContract]
    bool RegisterVenue(VenueLite v, VenueLogin vl);

    [OperationContract]
    int VenueLogin(string userName, string Password);
    }

[DataContract]

public class VenueLite
{
    [DataMember]
    public string venueName { set; get; }

    [DataMember]
    public string VenueAddress { set; get; }

    [DataMember]
    public string VenueCity { set; get; }

    [DataMember]
    public string VenueState { set; get; }

    [DataMember]
    public string VenueZip { set; get; }

    [DataMember]
    public string VenuePhone { set; get; }

    [DataMember]
    public int VenueAgeRestriction { set; get; }

    [DataMember]
    public string Email { set; get; }

    [DataMember]
    public string VenueWebsite { set; get; }

    [DataMember]
    public string UserName { set; get; }

    [DataMember]
    public string Password { set; get; }

    [DataMember]
    public int VenueDateAdded { set; get; }
}
