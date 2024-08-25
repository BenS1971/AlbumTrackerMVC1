using AlbumTrackerMVC1.Services.Artists;
using Microsoft.AspNetCore.Mvc;


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

    
    // Read a song...

    
    // Update a song...
        

    //Delete a song...
    
}