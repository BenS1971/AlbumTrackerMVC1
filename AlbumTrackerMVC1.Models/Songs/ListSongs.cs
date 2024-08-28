using System.ComponentModel.DataAnnotations;

namespace AlbumTrackerMVC1.Models.Songs
{
    // This will let the user SEE the songs that was entered.

    public class ListSongs
    {
        [Display(Name = "Song Name")]
        public required string SongName { get; set; }
        [Display(Name = "Artist Name")]
        public string? ArtistName { get; set; }
        [Display(Name = "Song Duration")]
        public DateTime SongDuration { get; set; }
    }

}
