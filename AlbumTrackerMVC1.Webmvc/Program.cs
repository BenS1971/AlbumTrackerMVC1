using AlbumTrackerMVC1.Data;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using AlbumTrackerMVC1.Services.Albums;
using AlbumTrackerMVC1.Services.Artists;
using AlbumTrackerMVC1.Services.Songs;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMvc();
// builder.Services.AddScoped<IAlbumService, AlbumService>();

builder.Services.AddScoped<IArtistsService, ArtistsService>();

builder.Services.AddScoped<ISongsService, SongsService>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
