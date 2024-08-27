using System.ComponentModel.DataAnnotations;

namespace AlbumTrackerMVC1.Models.Albums
{
    // We're going to list an album with THIS model.
    public class AlbumList
    {

        public int AlbumId { get; set; }
        [Display(Name = "Album Name")]
        public required string AlbumName { get; set; }
        [Display(Name = "Artist Name")]

        public string? ArtistName { get; set; }
        [Display(Name = "Format")]
        public string? Format { get; set; }
        [Display(Name = "Genre")]
        public string? Genre { get; set; }
        [Display(Name = "Release Year")]
        public DateTime ReleaseYear { get; set; }
    }



}
