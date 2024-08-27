using AlbumTrackerMVC1.Models.Songs;
using AlbumTrackerMVC1.Services.Artists;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace AlbumTrackerMVC1.Webmvc.Controllers;

public class SongController : Controller
{
    private ISongsService _service;
        public SongController(ISongsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    
    // Create a song...
    [HttpPost]
    public IActionResult Create()
    {
        return View();

    }

    [HttpGet]

    public IActionResult AddSong(CreateSong song )
    {
        return RedirectToAction(nameof(Index));
    }

    public class CreateSong
    {
    }



    // Read a song...


    // Update a song...


    //Delete a song...

}