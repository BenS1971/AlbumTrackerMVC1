using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

namespace AlbumTrackerMVC1.Models.Albums;

//This is an attempt at a model to create an album.
public class AlbumCreate
{
    [Required]
    [StringLength(200)]
    public string AlbumName {get; set; } = string.Empty;

    
    [StringLength(200)]
    public string ArtistName {get; set;} = string.Empty;

    public string? Format { get; set; } = string.Empty;

    public string? Genre { get; set; } = string.Empty;
    public DateTime? ReleaseDate {get; set; } 
}