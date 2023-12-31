using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate2.Models;

namespace RealState2.Data
{
    public class RealEstateDbContext : IdentityDbContext<Vendor>
    {
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
            : base(options)
        {
        }
        public DbSet<facility> Facilities { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
