using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourGuideWebSite.Models;

namespace TourGuideWebSite.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        private readonly ILogger<AdminController> _logger;

        private ApplicationDbContext _db;

        public AdminController(ILogger<AdminController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
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
            _db.SaveChanges();
            status = true;

            return new JsonResult(new { status = status });
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;

            var v = _db.Events.Where(a => a.Id == eventID).FirstOrDefault();
            if (v != null)
            {
                status = true;
                _db.Events.Remove(v);
                _db.SaveChanges();
            }
            return new JsonResult(new { status = status });
        }
    }
}
