
using Microsoft.AspNetCore.Mvc;

namespace AlbumTrackerMVC1.Webmvc.Controllers
{

    public class AlbumController : Controller
    {

        private readonly IAlbumsService _service = service;
        private static IAlbumsService service;




        // Create an album...
        [HttpGet]
        public IActionResult AlbumAdd()
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
