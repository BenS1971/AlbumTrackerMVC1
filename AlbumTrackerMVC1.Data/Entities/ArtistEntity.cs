using System.ComponentModel.DataAnnotations;


namespace AlbumTrackerMVC1.Data.Entities
{
    public class ArtistEntity
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        [MaxLength(200)]
        public required string ArtistName { get; set; }

        public string? Format { get; set; }

        public string? Genre { get; set; }
    }
}