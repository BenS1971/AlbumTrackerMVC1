using Microsoft.AspNetCore.Mvc;

namespace AlbumTrackerMVC1.Webmvc.Controllers
{

    public class AlbumController : Controller
    {

        private readonly IAlbumsService _service;

        public AlbumController(IAlbumsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }




        // Create an album...

        [HttpPost]
        public IActionResult AlbumAdd()
        {
            return View(AlbumAdd);

        }

        // Read an album...

        [HttpGet]
        public IActionResult ListAlbum()
        {
            return View();
        }

        // Update an album...

        [HttpPut]
        public IActionResult UpdateAlbum()
        {
            return View();
        }


        //Delete an album...

        [HttpDelete]
        public IActionResult DeleteAlbum()
        {
            return View();
        }
    }
}
