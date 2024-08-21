using System.ComponentModel.DataAnnotations;

namespace AlbumTrackerMVC1.Models.Artists;

public class ArtistList
{
     
     public required string AlbumName {get; set;}

     public string? Format { get; set; }

     public string? Genre { get; set; }
 }