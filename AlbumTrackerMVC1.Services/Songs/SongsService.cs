using AlbumTrackerMVC1.Models.Songs;

namespace AlbumTrackerMVC1.Services.Songs
{
    public class SongsService : ISongsService
    {
        public Task<bool> AddSongAsync(AddSong model)
        {
            throw new NotImplementedException();
        }


        public Task<bool> DeleteSongAsync(string song)
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

        Task<IEnumerable<ListSongs>> ISongsService.GetSongsAsync()
        {
            throw new NotImplementedException();
        }
    }

    public class SongList
    {
    }

    public class SongCreate
    {
    }
}