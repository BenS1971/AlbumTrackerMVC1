using System.ComponentModel.DataAnnotations;

namespace AlbumTrackerMVC1.Models.Songs;

// This will let the user SEE the songs that was entered.

public class ListSongs
{
   public required string SongName { get; set;}
   public string? ArtistName { get; set;}
   public DateTime SongDuration { get; set;}
}
