using System.ComponentModel.DataAnnotations;

namespace AlbumTrackerMVC1.Models.Songs;

public class ListSongs
{
   public required string SongName { get; set;}
   public string? ArtistName { get; set;}
   public DateTime SongDuration { get; set;}
}
