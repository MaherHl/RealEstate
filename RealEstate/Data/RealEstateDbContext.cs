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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Facility>()
                .HasOne(f => f.agent)  // Each Facility has one Agent
                .WithMany(a => a.Facilities) // Each Agent can have multiple Facilities
                .HasForeignKey(f => f.AgentId); // Foreign key property in Facility entity
                

            // Optionally, if you want to cascade delete (delete related Facilities when an Agent is deleted)
            modelBuilder.Entity<Agent>()
                .HasMany(a => a.Facilities)
                .WithOne(f => f.agent)
                .HasForeignKey(f => f.AgentId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Facility>()
                .HasMany(F => F.Appointements)
                .WithOne(a=> a.Facility)
                .HasForeignKey(a => a.FacilityId);






        }
    }
}
