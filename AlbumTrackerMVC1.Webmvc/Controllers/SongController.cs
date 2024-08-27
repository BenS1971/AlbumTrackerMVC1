using Microsoft.AspNetCore.Mvc;


namespace AlbumTrackerMVC1.Webmvc.Controllers
{
    public class SongController : Controller
    {



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





    // Read a song...


    // Update a song...


    //Delete a song...

}
