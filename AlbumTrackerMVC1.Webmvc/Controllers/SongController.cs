using Microsoft.AspNetCore.Mvc;


namespace AlbumTrackerMVC1.Webmvc.Controllers
{
    public class SongController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }


        // Add A Song...
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        // Read a Song...

        [HttpGet]
        public IActionResult ListSong()
        {
            return View();
        }


        // Update a Song (Not used)


        // Delete an album...

        [HttpDelete]
        public IActionResult DeleteSong()
        {
            return View();
        }
    }

}
