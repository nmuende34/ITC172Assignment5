using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VenueAddShowService" in code, svc and config file together.
public class VenueAddShowService : IVenueAddShowService
{
    ShowTrackerEntities db = new ShowTrackerEntities();

    public bool AddArtist(Artist a)
    {
        bool result = true;
        try
        {
            Artist ar = new Artist();
            ar.ArtistName = a.ArtistName;
            ar.ArtistEmail = a.ArtistEmail;
            ar.ArtistWebPage = a.ArtistWebPage;
            ar.ArtistDateEntered = DateTime.Now;
            db.Artists.Add(ar);

            db.SaveChanges();
        }
        catch
        {
            result = false;
        }
        
        return result;
    }
    public bool AddShow(Show s, ShowDetail d)
    {
        bool result = true;
        try
        {
            //I was missing some of the show details here
            Show sh = new Show();
            sh.ShowName = s.ShowName;
            sh.ShowDate = s.ShowDate;
            sh.ShowDateEntered = s.ShowDateEntered;
            sh.ShowTime = s.ShowTime;
            sh.VenueKey = s.VenueKey;
            sh.ShowTicketInfo = s.ShowTicketInfo;

            db.Shows.Add(sh);

            ShowDetail sd = new ShowDetail();
            sd.ArtistKey = d.ArtistKey;
            sd.ShowDetailArtistStartTime = d.ShowDetailArtistStartTime;
            sd.Show = sh;
            sd.ShowDetailAdditional = d.ShowDetailAdditional;

            db.ShowDetails.Add(sd);

            db.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }


    public List<Artist> GetArtist()
    {
        List<Artist> artists = new List<Artist>();
        
        var arts = from c in db.Artists
                   select new { c.ArtistKey, c.ArtistName };

        
        foreach (var a in arts)
        {
            Artist r = new Artist();
            r.ArtistKey = a.ArtistKey;
            r.ArtistName = a.ArtistName;
            artists.Add(r);
        }
        return artists;
    }

    public List<Show> GetShow(int vkey)
    {
        List<Show> shows = new List<Show>();

        var shws = from s in db.Shows
                   where s.VenueKey == vkey
                   select new { s.ShowName, s.ShowDate, s.ShowTicketInfo, s.ShowTime, s.ShowKey };

        foreach(var s in shws)
        {

            Show h = new Show();
            h.ShowName = s.ShowName;
            h.ShowDate = s.ShowDate;
            h.ShowTicketInfo = s.ShowTicketInfo;
            h.ShowTime = s.ShowTime;
            h.ShowKey = s.ShowKey;
            shows.Add(h);
        }
        return shows;
    }
    //here is the code that was missing that has gotten the service to work
    public List<Detail> GetDetails(int dKey)
    {
        List<Detail> details = new List<Detail>();

        var det = from d in db.ShowDetails
                  where d.ShowKey == dKey
                  select new { d.ShowDetailArtistStartTime, d.ShowDetailAdditional, d.Artist.ArtistName };

        foreach (var t in det)
        {
            Detail sd = new Detail();
            sd.ArtistStartTime = t.ShowDetailArtistStartTime.ToString();
            sd.Additional = t.ShowDetailAdditional;
            sd.ArtistName = t.ArtistName;
            details.Add(sd);
        }

        return details;
    }

}
