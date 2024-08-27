
using Microsoft.AspNetCore.Mvc;
using AlbumTrackerMVC1.Models.Albums;

namespace AlbumTrackerMVC1.Webmvc.Controllers
{

    public class AlbumController(IAlbumsService service) : Controller
    {

        private readonly IAlbumsService _service = service;

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
        [HttpPost]
        public IActionResult Create(AlbumCreate)
        {
            return RedirectToAction(nameof(Index));
        }




        // Read an album...




        // Update an album...


        //Delete an album...

    }
}
