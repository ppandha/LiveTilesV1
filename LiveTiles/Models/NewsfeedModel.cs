using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LiveTiles.Models
{
    public class Newsfeed
    {
        public int ID { get; set; }
   
        [Required]
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "RSS Source URL")]
        public string RssUrl { get; set; }
    }

    public class NewsfeedDBContext : DbContext
    {
        public DbSet<Newsfeed> Newsfeeds { get; set; }
    }
}



