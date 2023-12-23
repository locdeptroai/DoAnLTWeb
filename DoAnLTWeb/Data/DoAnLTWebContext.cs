using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoAnLTWeb.Models;

namespace DoAnLTWeb.Data
{
    public class DoAnLTWebContext : DbContext
    {
        public DoAnLTWebContext (DbContextOptions<DoAnLTWebContext> options)
            : base(options)
        {
        }

        public DbSet<DoAnLTWeb.Models.Category> Category { get; set; } = default!;

        public DbSet<DoAnLTWeb.Models.Product>? Product { get; set; }

        public DbSet<DoAnLTWeb.Models.User>? User { get; set; }
    }
}
