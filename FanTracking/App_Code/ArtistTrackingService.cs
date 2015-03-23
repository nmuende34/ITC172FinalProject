using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ArtistTrackingService" in code, svc and config file together.
public class ArtistTrackingService : IArtistTrackingService
{
    FanTrackingEntities fte = new FanTrackingEntities();

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

    public List<Genre> GetGenres()
    {
        List<Genre> genres = new List<Genre>();

        var gen = from g in fte.Genres
                  select new { g.GenreKey, g.GenreName, g.GenreDescription };

        foreach (var gn in gen)
        {
            Genre g = new Genre();
            g.GenreKey = gn.GenreKey;
            g.GenreName = gn.GenreName;
            g.GenreDescription = gn.GenreDescription;
            genres.Add(g);
        }
        return genres;
    }

    public void FollowArtist(int a, int FanKey)
    {
        int fan = FanKey;
        int artist = a;

        Artist art = (from a2 in fte.Artists where a2.ArtistKey == artist select a2).First();

        Fan f2 = (from f in fte.Fans where f.FanKey == FanKey select f).First();

        f2.Artists.Add(art);
        fte.SaveChanges();
    }

    public void FollowGenre(int g, int fanKey)
    {
        int fan = fanKey;
        int genre = g;

        Genre gen = (from g2 in fte.Genres where g2.GenreKey == genre select g2).FirstOrDefault();

        Fan f2 = (from f in fte.Fans where f.FanKey == fanKey select f).FirstOrDefault();

        f2.Genres.Add(gen);
        fte.SaveChanges();
    }
    //was trying to workout a way to pull the preferences from the database, but couldn't figure it out...not familiar with database design yet
    /*
    public string GetPrefs(int fankey)
    {
        int fan = fankey;
        
        Fan f2 = (from f in fte.Fans where f.FanKey == fankey select f).FirstOrDefault();
        Genre gen = (from g2 in fte.Genres where g2.GenreKey != null select g2).FirstOrDefault();
        Artist art = (from a2 in fte.Artists where a2.ArtistKey != null select a2).FirstOrDefault();

        f2.Genres.Add(gen);

        if ((art != null) && (gen !=null)) 
        {
            string ap = "Your Artist Preference is " + art;
            string pref = " and your genre preference is " + gen;
            string result = ap + pref;
            return result;
        }
        else
        {
            string result = "You have to pick a preference";
            return result;
        }
    }*/

    //played around with outputting artists in a gridview
    /*public List<Artist> GetGridArtists(int key)
    {
        int akey = key;
        List<Artist> artists = new List<Artist>();

        var art = from a in fte.Artists
                  where a.ArtistKey == akey
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
    }*/
}
