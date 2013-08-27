using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD.Models
{
    public class FilmsContext : DbContext
    {
        public DbSet<Films> Filmses { get; set; }
    }
}