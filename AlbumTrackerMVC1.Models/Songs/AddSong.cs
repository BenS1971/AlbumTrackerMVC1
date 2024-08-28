using System.ComponentModel.DataAnnotations;


namespace AlbumTrackerMVC1.Models.Songs
{
    // Here is the model for adding a song to the song page.
    public class AddSong
    {
        [Required]
        [StringLength(200)]
        public string SongName { get; set; } = string.Empty;

        [StringLength(200)]
        public string? AlbumName { get; set; } = string.Empty;

        public string? ArtistName { get; set; } = string.Empty;

        public double? SongDuration { get; set; } = double.MaxValue;


    }
}