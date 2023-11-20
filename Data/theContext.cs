using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class theContext : DbContext
    {
        public theContext() : base("PostGres")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
    }
}