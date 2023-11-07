using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Models;

namespace Mobiles.Core.Data
{
    public class PhonesDbContext : DbContext
    {
        public DbSet<Smartphone> Smartphones { get; set; } = null!;
        public DbSet<SmartphoneCpu> SmartphoneCpus { get; set; } = null!;

        public PhonesDbContext() : base() { }

        public PhonesDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Smartphone>()
                .HasOne(el => el.Cpu)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
