using System;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312___Final_Project.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegionWildfireAdvisory>()
                .HasKey(r => new {r.WildfireAdvisoryId, r.RegionId});

            // Recursive relationship data seeding solution from https://khalidabuhakmeh.com/recursive-data-with-entity-framework-core-and-sql-server
            modelBuilder.Entity<Region>()
                .HasData(new List<Region>()
                {
                    new() {RegionId = 1, Name = "Randall County", RiskLevel = "Medium"},
                    new() {RegionId = 2, Name = "Canyon, TX", RiskLevel = "High", MacroRegionId = 1},
                    new() {RegionId = 3, Name = "Palo Duro Canyon State Park", RiskLevel = "Low", MacroRegionId = 1},
                    new() {RegionId = 4, Name = "Zita, TX", RiskLevel = "Medium", MacroRegionId = 1},
                    new() {RegionId = 5, Name = "Lake Tanglewood", RiskLevel = "Medium", MacroRegionId = 1},
                    new() {RegionId = 6, Name = "Umbarger, TX", RiskLevel = "Low", MacroRegionId = 1},
                    new() {RegionId = 7, Name = "Potter County", RiskLevel = "Low"},
                    new() {RegionId = 8, Name = "Amarillo, TX", RiskLevel = "Low", MacroRegionId = 7},
                    new() {RegionId = 9, Name = "Alibates Flint Quarries National Monument", RiskLevel = "Low", MacroRegionId = 7}

                });   
        }


        public DbSet<WildfireAdvisory> WildfireAdvisories {get; set;} = null!;
        public DbSet<Region> Regions {get; set;} = null!;
        public DbSet<Report> Reports {get; set;} = null!;
        public DbSet<ReportImage> ReportImages {get; set;} = null!;
        public DbSet<RegionWildfireAdvisory> RegionWildfireAdvisories {get; set;} = null!;
    }
}