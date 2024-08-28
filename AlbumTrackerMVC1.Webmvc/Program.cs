using AlbumTrackerMVC1.Data;
using Microsoft.EntityFrameworkCore;
using AlbumTrackerMVC1.Services.Artists;
using AlbumTrackerMVC1.Services.Albums;
using AlbumTrackerMVC1.Services.Songs;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//Builder services go here...


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMvc();


builder.Services.AddScoped<IArtistsService, ArtistsService>();

builder.Services.AddScoped<IAlbumsService, AlbumsService>();

builder.Services.AddScoped<ISongsService, SongService>();


WebApplication app = builder.Build();


if (!app.Environment.IsDevelopment())
{

}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


// "In here, program. You are a prisoner of the MCP. This way to the Dead Zone! End of line." (Tron reference.)

