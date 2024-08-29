namespace AlbumTrackerMVC1.Services.Songs
{
    public class AlbumsService : ISongsService
    {
        public Task<bool> AddAlbumAsync(SongCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSongAsync(string AlbumId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SongList>> GetAllAlbumsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAlbumSync(UpdateAlbum model)
        {
            throw new NotImplementedException();
        }
    }
}