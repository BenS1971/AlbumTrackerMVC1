using Microsoft.AspNetCore.Mvc;

namespace AlbumTrackerMVC1.Webmvc.Controllers;


public class ArtistController : Controller
{
    public ArtistController(IHttpClientFactory httpClientFactory)
    {
        
    }
    public IActionResult Index()
    {
        return View();
    }

    // Create an artist...

    
    // Read an artist...

    
    // Update an artist...
        

    //Delete an atist...
    
}