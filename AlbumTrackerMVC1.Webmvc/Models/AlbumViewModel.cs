namespace AlbumTrackerMVC1.Webmvc.Models;

public class AlbumViewModel
{
    public string? AlbumName { get; set; }
    public string? AlbumArtist { get; set; }
    public string? ArtistName { get; set; }
    public string? Format {get; set; }
    public string? Genre { get; set; }
    public DateTime ReleaseYear {get; set;}
}
