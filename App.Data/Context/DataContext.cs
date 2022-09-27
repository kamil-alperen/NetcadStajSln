using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasPostgresExtension("postgis");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql("Host=localhost;Database=mydatabase;Username=postgres;Password=alperen123",
                o => o.UseNetTopologySuite());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Place> Places { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Business> Businesses { get; set; }

        public DbSet<License> Licenses { get; set; }
    }

}
