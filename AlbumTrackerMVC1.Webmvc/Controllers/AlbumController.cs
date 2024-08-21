using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace AlbumTrackerMVC1.Webmvc.Controllers;

public class AlbumController : Controller
{
    public AlbumController(IHttpClientFactory httpClientFactory)
    {
        
    }
    public IActionResult Index()
    {
        return View();
    }
}
    // Create an album...
    [HttpGet]
    
    // Read an album...
    [HttpPost]
    
    // Update an album...
        

    //Delete an album...
    
   


