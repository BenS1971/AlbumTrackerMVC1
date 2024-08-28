namespace AlbumTrackerMVC1.Webmvc.Models
{
    public class SongViewModel
    {
        required public string SongName { get; set; }
        public string? ArtistName { get; set; }
        public string? AlbumName { get; set; }
        public DateTime SongDuration { get; set; }
    }
}