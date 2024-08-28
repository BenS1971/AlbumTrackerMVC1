using AlbumTrackerMVC1.Models.Albums;


namespace AlbumTrackerMVC1.Services.Albums
{
    public class AlbumsService : IAlbumsService
    {
        public Task<bool> AddAlbumAsync(AlbumCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAlbumAsync(string AlbumId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlbumList>> GetAllAlbumsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAlbumSync(UpdateAlbum model)
        {
            throw new NotImplementedException();
        }
    }
}