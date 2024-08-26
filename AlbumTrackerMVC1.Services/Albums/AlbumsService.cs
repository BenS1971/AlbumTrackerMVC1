using AlbumTrackerMVC1.Data;
using AlbumTrackerMVC1.Services.Artists;
using AlbumTrackerMVC1.Services.Songs;
using AlbumTrackerMVC1.Services.Albums;
using AlbumTrackerMVC1.Models.Albums;

namespace AlbumTrackerMVC1.Services.Albums;

public class AlbumsService : IAlbumsService
{
    public Task AlbumCreateAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AlbumList>> ListAlbumsAsync()
    {
        throw new NotImplementedException();
    }
}

