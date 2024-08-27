
using AlbumTrackerMVC1.Data;
using AlbumTrackerMVC1.Models.Albums;


namespace AlbumTrackerMVC1.Services.Albums
{
    public class AlbumsService : IAlbumsService
    {
        public Task AlbumCreateAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AlbumList>> ListAlbumsAsync()
        {
            List<AlbumList> albums = await ApplicationDbContext

            {

            }

            return albums;
        }
    }

}
