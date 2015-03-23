using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IArtistTrackingService" in both code and config file together.
[ServiceContract]
public interface IArtistTrackingService
{
    [OperationContract]
    List<Artist> GetArtists();
   
    [OperationContract]
    void FollowArtist(int a, int FanKey);
   
    [OperationContract]
    List<Genre> GetGenres();

    [OperationContract]
    void FollowGenre(int g, int FanKey);
    
    /*Operation for pulling preferences...couldn't get to work
    [OperationContract]
    string GetPrefs(int fankey);*/
}
