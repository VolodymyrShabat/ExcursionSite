using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TourGuideWebSite.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Href { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public string Color { get; set; }

    }
}
