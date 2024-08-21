using System.Net.Http;
using AlbumTrackerMVC1.Services.Albums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace AlbumTrackerMVC1.Webmvc.Controllers;


    public class AlbumController : Controller
    {
       
        private IAlbumService _service;
        public AlbumController(IAlbumService service)
        {
            _service = service;
        }
    

    // Create an album...

    
    // Read an album...

    
    // Update an album...
        

    //Delete an album...
    
    }


