
using AlbumTrackerMVC1.Services.Artists;
using Microsoft.AspNetCore.Mvc;

namespace AlbumTrackerMVC1.Webmvc.Controllers
{
    public class ArtistController : Controller
    {

        private readonly IArtistsService _service = service;
        private static IArtistsService service;

        public IActionResult Index()
        {
            return View();
        }


        // Create an album...
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        private interface IAlbumsService
        {
        }





        // Read an album...




        // Update an album...


        //Delete an album...
    }
}
