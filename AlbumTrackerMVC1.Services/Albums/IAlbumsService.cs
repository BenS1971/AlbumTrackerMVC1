using AlbumTrackerMVC1.Models.Albums;

public interface IAlbumsService
{
    Task<IEnumerable<AlbumList>> GetAllAlbumsAsync();
    Task<bool> AddAlbumAsync(AlbumCreate model);
    Task<bool> UpdateAlbumSync(UpdateAlbum model);
    Task<bool> DeleteAlbumAsync(string AlbumId);

}

public class UpdateAlbum
{
}