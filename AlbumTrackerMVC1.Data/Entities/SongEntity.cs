using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace AlbumTrackerMVC1.Data.Entities;

public class SongEntity
{
   [Required]
   public int AlbumId { get; set;}

   [MaxLength(200)]
   public string? AlbumName { get; set; }

  
   public string? ArtistName { get; set;}

   [MaxLength(200)]
   public required string SongName { get; set; }

   public decimal? SongDuration { get; set;}

}