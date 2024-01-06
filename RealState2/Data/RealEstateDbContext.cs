using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate2.Models;

namespace RealState2.Data
{
    public class RealEstateDbContext : IdentityDbContext
    {
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
            : base(options)
        {
        }

        public DbSet<facility> Facilities { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
      

            modelBuilder.Entity<Vendor>()
                .HasMany(v => v.Facilities)
                .WithOne(f => f.Owner)
                .HasForeignKey(f => f.VendorId);
                

          
            base.OnModelCreating(modelBuilder);
        }
    }
}


