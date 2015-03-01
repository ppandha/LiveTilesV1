using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LiveTiles.Models
{
    public class Calender
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Contents { get; set; }

        public string Location { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

    }

    public class CalenderDBContext :  DbContext
    {
        public DbSet<Calender> Calenders { get; set; }

        public System.Data.Entity.DbSet<LiveTiles.Models.Twitter> Twitters { get; set; }
    }
}