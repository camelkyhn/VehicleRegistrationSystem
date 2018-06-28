using Microsoft.EntityFrameworkCore;
using VehicleRegistrationSystem.Common.Entities;

namespace VehicleRegistrationSystem.DAL.Context
{
    public class DatabaseContext : DbContext, IDbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
        }
    }
}