using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CollabFast.Models
{
    public class Context : DbContext
    {

            public DbSet<Project> Projects { get; set; }



        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
          //      optionsBuilder.UseSqlServer(@"Data Source = goldfinger.cluster-cntdcjk44nt1.us-east-2.rds.amazonaws.com,4848; Initial Catalog = goldfinger; User ID = admin; Password = bond007&)); Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; MultiSubnetFailover = False");
           // }

        }
    }