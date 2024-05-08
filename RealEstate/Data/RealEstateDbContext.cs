using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RealEstate.Models;
using Microsoft.Identity.Client;

namespace RealEstate.Data
{
    public class RealEstateDbContext : IdentityDbContext
    {
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options) : base(options) { }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Appointement> Appointements { get; set; }

    }
}
