using AlbumTrackerMVC1.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace AlbumTrackerMVC1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<AlbumEntity> Albums { get; set; }
    }
}
