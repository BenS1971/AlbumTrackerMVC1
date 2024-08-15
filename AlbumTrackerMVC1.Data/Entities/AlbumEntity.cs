using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace AlbumTrackerMVC1.Data.Entities;

public class AlbumEntity 
{
    [Key]
    public int AlbumId { get; set; }

    [Required]
    [MaxLength(150)]
    public string? AlbumName { get; set;}

    [MaxLength(150)]
    public string? AlbumArtist { get; set;}

    [MaxLength(150)]
    public string? SongTitle { get; set;}

}

