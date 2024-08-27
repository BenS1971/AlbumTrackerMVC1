using AlbumTrackerMVC1.Models.Artists;
using AlbumTrackerMVC1.Services.Artists;
using Microsoft.AspNetCore.Mvc;

namespace AlbumTrackerMVC1.Webmvc.Controllers;


public class ArtistController : Controller
{
    private IArtistsService _service;
        public ArtistController(IArtistsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    

    // Create an artist...
    [HttpPost]
    public IActionResult Create()
    {
        return View();

    }


    [HttpGet]
    public IActionResult Create(ArtistAdd artist)
    {
        return RedirectToAction(nameof(Index));
    } 
    

    
    // Read an artist...

    
    // Update an artist...
        

    //Delete an atist...
    
}

