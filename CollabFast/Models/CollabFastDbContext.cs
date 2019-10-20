using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CollabFast.Models
{
    public class CollabFastDbContext : DbContext
    {
        // Just grabbing all the tables here. It's nasty, but it'll work.
        public DbSet<Project> Projects { get; set; }
    }
}