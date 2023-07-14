using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCPostgres.Models;
using Microsoft.Extensions.Configuration;

//namespace MVCPostgres.Data
//{
//    public class MVCPostgresContext : DbContext
//    {
//        public MVCPostgresContext (DbContextOptions<MVCPostgresContext> options)
//            : base(options)
//        {
//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            base.OnConfiguring(optionsBuilder);
//            // connect to postgres with connection string from app settings
//            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("MVCPostgresContext"));
//        }

//        public DbSet<Department> Department { get; set; } = default!;
//    }
//}


//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MVCPostgres.Data
{
    public class MVCPostgresContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MVCPostgresContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("MVCPostgresContext"));
        }

        public DbSet<Department> Department { get; set; }
    }
}