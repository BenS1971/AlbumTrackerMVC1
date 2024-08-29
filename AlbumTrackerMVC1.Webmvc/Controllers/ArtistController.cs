
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


        // Create an artist...
        [HttpPost]
        public IActionResult AddArtist()
        {
            return View();

        }

        // Read an artist...
        [HttpGet]
        public IActionResult ReadArtist()
        {
            return View();
        }

        // Update an artist...

        [HttpPut]
        public IActionResult UpdateArtist()
        {
            return View();
        }



        //Delete an artist...

        [HttpDelete]
        public IActionResult DeleteArtist()
        {
            return View();
        }

    }
}
