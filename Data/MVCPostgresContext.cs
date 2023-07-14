using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCPostgres.Models;

namespace MVCPostgres.Data
{
    public class MVCPostgresContext : DbContext
    {
        public MVCPostgresContext (DbContextOptions<MVCPostgresContext> options)
            : base(options)
        {
        }

        public DbSet<MVCPostgres.Models.Department> Department { get; set; } = default!;
    }
}
