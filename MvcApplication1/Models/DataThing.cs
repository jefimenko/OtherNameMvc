using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class DataThing
    {
        public int ID { get; set; }
        public string text { get; set; }
        public decimal number { get; set; }
        public DateTime when { get; set; }
    }

    public class ThingDbContext : DbContext
    {
        public DbSet<DataThing> Things { get; set; }
    }
}