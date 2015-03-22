using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVenueAddShowService" in both code and config file together.
[ServiceContract]
public interface IVenueAddShowService
{
	[OperationContract]
    bool AddArtist(Artist a);

	[OperationContract]
    bool AddShow(Show s, ShowDetail d);

	[OperationContract]
    List<Artist> GetArtist();

	[OperationContract]
    List<Show> GetShow(int vkey);
    
    //this is one piece of code that was missing that has gotten the service to work
    [OperationContract]
    List<Detail> GetDetails(int dkey);

}
//this too was missing that has gotten the service to work
[DataContract]
public class Detail
{
    [DataMember]
    public string ArtistName { set; get;}
    [DataMember]
    public string ArtistStartTime { set; get;}
    [DataMember]
    public string Additional { set; get; }
}