using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ArtistTrackingService" in code, svc and config file together.
public class ArtistTrackingService : IArtistTrackingService
{
    FanTrackerEntities fte = new FanTrackerEntities();

    public List<Artist> GetArtists()
    {
        List<Artist> artists = new List<Artist>();

        var art = from a in fte.Artists
                  select new { a.ArtistKey, a.ArtistName, a.ArtistEmail, a.ArtistWebPage };

        foreach (var ar in art)
        {
            Artist a = new Artist();
            a.ArtistKey = ar.ArtistKey;
            a.ArtistName = ar.ArtistName;
            a.ArtistEmail = ar.ArtistEmail;
            a.ArtistWebPage = ar.ArtistWebPage;
            artists.Add(a);

        }

        return artists;

    }
}
