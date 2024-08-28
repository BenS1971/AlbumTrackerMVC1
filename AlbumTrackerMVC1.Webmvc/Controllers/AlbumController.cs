
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
        [HttpGet]
        public IActionResult AlbumAdd()
        {
            return View();

        }

        // Read an album...


        // Update an album...


        //Delete an album...
    }
}
