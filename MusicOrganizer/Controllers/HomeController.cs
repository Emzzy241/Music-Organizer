using Microsoft.AspNetCore.Mvc;
using System;

namespace MusicOrganizerControllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ActionResult Index()
        {
            return View();
        }        
    }
}
