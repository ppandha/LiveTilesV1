using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LiveTiles.Models
{
    public class Twitter
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "Search Criteria")]
        public string SearchCriteria { get; set; }

    }

    public class TwitterDBContext : DbContext
    {
        public DbSet<Twitter> Twitters { get; set; }
    }
}