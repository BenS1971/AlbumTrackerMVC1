using AlbumTrackerMVC1.Data;
using AlbumTrackerMVC1.Models.Albums;
using Microsoft.EntityFrameworkCore;

namespace AlbumTrackerMVC1.Services.Albums;

public interface IAlbumService
{
    Task AlbumCreateAsync(AlbumTrackerMVC1.Webmvc.Controllers.AlbumCreate request);
    Task AlbumCreateAsync(AlbumTrackerMVC1.Webmvc.Controllers.AlbumCreate request);
    Task AlbumCreateAsync(AlbumTrackerMVC1.Webmvc.Controllers.AlbumCreate request);
    Task AlbumCreateAsync();
    Task<IEnumerable<AlbumList>> ListAlbumsAsync();
}

