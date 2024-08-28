using System.ComponentModel.DataAnnotations;

namespace AlbumTrackerMVC1.Models.Artists
{
    public class ArtistAdd
    {
        [Required]
        [StringLength(200)]
        public string ArtistName { get; set; } = string.Empty;

        public string? Format { get; set; } = string.Empty;

        public string? Genre { get; set; } = string.Empty;
    }
}