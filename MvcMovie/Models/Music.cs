using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Music
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Author { get; set; }
    }
    public class MusicDBContext : DbContext
    {
        public DbSet<Music> Music { get; set; }
    }
}