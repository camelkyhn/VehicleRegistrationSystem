using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;
            
            var connectionString = "User ID=camelkyhn;Password=kemal123;Server=localhost;Port=5432;Database=vehicle-db;Pooling=true;";
            
            new ConfigurationBuilder().Build();
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}