using AlbumTrackerMVC1.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace AlbumTrackerMVC1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<AlbumEntity> Albums { get; set; }
    }
}
