

public interface IAlbumsService
{
    Task AlbumCreateAsync();
    Task<IEnumerable<AlbumList>> ListAlbumsAsync();
}



