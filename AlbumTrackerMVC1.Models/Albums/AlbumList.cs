using System.ComponentModel.DataAnnotations;

namespace AlbumTrackerMVC1.Models.Albums;

// We're going to list an album with THIS model.
public class AlbumList
{
     public int AlbumId {get; set; }
     public required string AlbumName {get; set;}

     public string? ArtistName { get; set; }
     public string? Format { get; set; }
     public string? Genre { get; set; }
     public DateTime ReleaseYear { get; set;}
}


    
