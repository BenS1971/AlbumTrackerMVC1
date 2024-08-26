using System.Net.Http;
using AlbumTrackerMVC1.Services.Albums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.WebEncoders.Testing;
using AlbumTrackerMVC1.Models;
using AlbumTrackerMVC1.Models.Albums;

namespace AlbumTrackerMVC1.Webmvc.Controllers;


    public class AlbumController : Controller
    {
       
        private IAlbumsService _service;
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
    public IActionResult Create()
    {
        return View();

    }
    [HttpPost]
    public IActionResult Create(AlbumCreate album)
    {
        return RedirectToAction(nameof(Index));
    } 
    
    
      
    
    // Read an album...
       
       


    // Update an album...
        

    //Delete an album...
     
    }
