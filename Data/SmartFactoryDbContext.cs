using Microsoft.EntityFrameworkCore;
using SmartFactory.API.Models;

namespace SmartFactory.API.Data
{
    public class SmartFactoryDbContext : DbContext
    {
        public SmartFactoryDbContext(DbContextOptions<SmartFactoryDbContext> options) : base(options) { }

        public DbSet<Machine> Machines { get; set; }
        // public DbSet<ProductionOrder> ProductionOrders { get; set; } // Bunu da ekleyin

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Machine>().HasData(
                new Machine { Id = 1, Name = "CNC Makine A", Status = "Idle" },
                new Machine { Id = 2, Name = "Montaj Robotu", Status = "Idle" }
            );
        }
    }
}