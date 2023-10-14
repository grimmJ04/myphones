using Microsoft.EntityFrameworkCore;
using Mobiles.Models;

namespace Mobiles.Core.Data
{
    public class PhonesDbContext : DbContext
    {
        public DbSet<Smartphone> Smartphones { get; set; }
        public DbSet<SmartphoneCpu> SmartphoneCpus { get; set; }

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
            base.OnConfiguring(optionsBuilder);
        }
    }
}
