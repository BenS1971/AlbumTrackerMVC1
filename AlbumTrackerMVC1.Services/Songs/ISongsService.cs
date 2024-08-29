using AlbumTrackerMVC1.Models.Songs;

namespace AlbumTrackerMVC1.Services.Songs
{
    public interface ISongsService
    {
        Task<IEnumerable<ListSongs>> GetSongsAsync();
        Task<bool> AddSongAsync(AddSong model);

        Task<bool> DeleteSongAsync(string song);

    }

}
