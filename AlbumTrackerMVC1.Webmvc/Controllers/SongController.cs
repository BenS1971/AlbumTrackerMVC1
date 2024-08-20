using Microsoft.AspNetCore.Mvc;


namespace AlbumTrackerMVC1.Webmvc.Controllers;

public class SongController : Controller
{
    public SongController(IHttpClientFactory httpClientFactory)
    {
        
    }
    public IActionResult Index()
    {
        return View();
    }
}