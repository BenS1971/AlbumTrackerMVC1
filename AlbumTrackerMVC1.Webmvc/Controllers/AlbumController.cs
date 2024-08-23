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
    
    
    // Create an album...
        [HttpPost]
        public async Task<IActionResult> 
    
    // Read an album...
        [HttpGet]
       


    // Update an album...
        [HttpPut]

    //Delete an album...
        [HttpDelete]
}

