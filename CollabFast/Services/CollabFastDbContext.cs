using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CollabFast.Models
{
    public class CollabFastDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
    }
}