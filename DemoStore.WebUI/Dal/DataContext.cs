using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace DemoStore.WebUI
{
    public partial class DataContext : DbContext
    {
        public DbSet<TblCategory> Categories { get; set; }
        public DbSet<TblProduct> Products { get; set; }
        public DbSet<TblEmployee> Employees { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
#endif
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
