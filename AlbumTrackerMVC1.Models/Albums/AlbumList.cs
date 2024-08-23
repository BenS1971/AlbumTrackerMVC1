using System.ComponentModel.DataAnnotations;

namespace AlbumTrackerMVC1.Models.Albums;

// We're going to list an album with THIS model.
public class AlbumList
{
     public int AlbumId {get; set; }
     public required string AlbumName {get; set;}
}


    
