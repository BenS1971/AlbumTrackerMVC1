using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace AlbumTrackerMVC1.Webmvc.Controllers;
{

    public class AlbumController : Controller
    {
        public AlbumController(IHttpClientFactory httpClientFactory)
        {   
            private readonly AlbumTrackerMVC1 albumTrackerMVC1 = new AlbumTrackerMVC1();

            public AlbumController(AlbumTrackerMVC1Context context)
            {
            _context = context;
            }
        
            public IActionResult Index()
            {
            return View();
            }
        }
    
    }

    // Create an album...

    
    // Read an album...

    
    // Update an album...
        

    //Delete an album...
    
   
}

