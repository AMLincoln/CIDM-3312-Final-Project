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
                    new() {RegionId = 1, Name = "Randall County, TX", RiskLevel = "Low", MacroRegionId = 30},
                    new() {RegionId = 2, Name = "Canyon, TX", RiskLevel = "Low", MacroRegionId = 1},
                    new() {RegionId = 3, Name = "Palo Duro Canyon State Park, TX", RiskLevel = "Low", MacroRegionId = 1},
                    new() {RegionId = 4, Name = "Zita, TX", RiskLevel = "Low", MacroRegionId = 1},
                    new() {RegionId = 5, Name = "Lake Tanglewood, TX", RiskLevel = "Low", MacroRegionId = 1},
                    new() {RegionId = 6, Name = "Umbarger, TX", RiskLevel = "Low", MacroRegionId = 1},
                    new() {RegionId = 7, Name = "Potter County, TX", RiskLevel = "Low", MacroRegionId = 30},
                    new() {RegionId = 8, Name = "Amarillo, TX", RiskLevel = "Low", MacroRegionId = 7},
                    new() {RegionId = 9, Name = "Gentry, TX", RiskLevel = "Low", MacroRegionId = 7},
                    new() {RegionId = 10, Name = "Gluck, TX", RiskLevel = "Low", MacroRegionId = 7},
                    new() {RegionId = 11, Name = "Ady, TX", RiskLevel = "Low", MacroRegionId = 7},
                    new() {RegionId = 12, Name = "Bishop Hills, TX", RiskLevel = "Low", MacroRegionId = 7},
                    new() {RegionId = 13, Name = "Carson County, TX", RiskLevel = "Medium", MacroRegionId = 30},
                    new() {RegionId = 14, Name = "Skellytown, TX", RiskLevel = "Medium", MacroRegionId = 13},
                    new() {RegionId = 15, Name = "Wilhelm, TX", RiskLevel = "Low", MacroRegionId = 13},
                    new() {RegionId = 16, Name = "Abell, TX", RiskLevel = "Low", MacroRegionId = 13},
                    new() {RegionId = 17, Name = "Panhandle, TX", RiskLevel = "Medium", MacroRegionId = 13},
                    new() {RegionId = 18, Name = "White Deer, TX", RiskLevel = "Medium", MacroRegionId = 13},
                    new() {RegionId = 19, Name = "Armstrong County, TX", RiskLevel = "Medium", MacroRegionId = 30},
                    new() {RegionId = 20, Name = "Washburn, TX", RiskLevel = "Medium", MacroRegionId = 19},
                    new() {RegionId = 21, Name = "Claude, TX", RiskLevel = "Medium", MacroRegionId = 19},
                    new() {RegionId = 22, Name = "Wayside, TX", RiskLevel = "Medium", MacroRegionId = 19},
                    new() {RegionId = 23, Name = "Goodnight, TX", RiskLevel = "High", MacroRegionId = 19},
                    new() {RegionId = 24, Name = "Moore County, TX", RiskLevel = "High", MacroRegionId = 30},
                    new() {RegionId = 25, Name = "Dumas, TX", RiskLevel = "High", MacroRegionId = 24},
                    new() {RegionId = 26, Name = "Masterson, TX", RiskLevel = "High", MacroRegionId = 24},
                    new() {RegionId = 27, Name = "Bryden, TX", RiskLevel = "High", MacroRegionId = 24},
                    new() {RegionId = 28, Name = "Sunray, TX", RiskLevel = "High", MacroRegionId = 24},
                    new() {RegionId = 29, Name = "Cactus, TX", RiskLevel = "High", MacroRegionId = 24},
                    new() {RegionId = 30, Name = "Texas Panhandle", RiskLevel = "Medium"},

                });   
        }


        public DbSet<WildfireAdvisory> WildfireAdvisories {get; set;} = null!;
        public DbSet<Region> Regions {get; set;} = null!;
        public DbSet<Report> Reports {get; set;} = null!;
        public DbSet<ReportImage> ReportImages {get; set;} = null!;
        public DbSet<RegionWildfireAdvisory> RegionWildfireAdvisories {get; set;} = null!;
    }
}