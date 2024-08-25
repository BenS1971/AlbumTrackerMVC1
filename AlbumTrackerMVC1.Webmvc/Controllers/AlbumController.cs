using System.Net.Http;
using AlbumTrackerMVC1.Services.Albums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.WebEncoders.Testing;
using AlbumTrackerMVC1.Models;

namespace AlbumTrackerMVC1.Webmvc.Controllers;


    public class AlbumController : Controller
    {
       
        private IAlbumService _service;
        public AlbumController(IAlbumService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    
    
    // Create an album...
    
    
    
      
    
    // Read an album...
       
       


    // Update an album...
        

    //Delete an album...
     
    }
