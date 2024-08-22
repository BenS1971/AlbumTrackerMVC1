using AlbumTrackerMVC1.Models.Albums;

namespace AlbumTrackerMVC1.Services.Albums;

public interface IAlbumService
{
    Task<IEnumerable<AlbumList>> ListAlbumsAsync();
}