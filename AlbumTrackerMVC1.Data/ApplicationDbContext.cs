using AlbumTrackerMVC1.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace AlbumTrackerMVC1.Data;

public class ApplicationDbContext : IdentityDbContext<AlbumEntity, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
        : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        ModelBuilder.Entity<AlbumEntity>().ToTable("Albums");
    }
}