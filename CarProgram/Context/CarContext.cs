using CarProgram.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CarProgram.Context
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions options)
    : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        public DbSet<Brand> Brands { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasMany(a => a.Equipment)
                .WithOne(b => b.Car)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Car>()
                .HasOne(s => s.Brand)
                .WithOne(ad => ad.Car)
                .HasForeignKey<Brand>(ad => ad.CarId);

        }
    }


}
