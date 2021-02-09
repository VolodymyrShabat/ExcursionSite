using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TourGuideWebSite.Models;

namespace TourGuideWebSite.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult GetEvents()
        {
            var events = _db.Events.ToList(); 
            return new JsonResult(events);
        }

       
        public IActionResult Excursion1()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveEvent(Event e)
        {
            var status = false;

                if (e.Id > 0)
                {
                    //Update the event
                    var v = _db.Events.Where(a => a.Id == e.Id).FirstOrDefault();
                    if (v != null)
                    {
                        v.Title = e.Title;
                        v.StartDate = e.StartDate;
                        v.EndDate = e.EndDate;
                        v.Href = e.Href;
                        v.Color = e.Color;
                    }
                }
                else
                {
                    _db.Events.Add(e);
                }
                _db.SaveChangesAsync();
                status = true;
            
            return new JsonResult (status);
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;

            var v = _db.Events.Where(a => a.Id == eventID).FirstOrDefault();
            if (v != null)
            {
                _db.Events.Remove(v);
                _db.SaveChangesAsync();
                status = true;
            }
            return new JsonResult(status);
        }



        public IActionResult Index()
        {

            return View();
        }



        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
