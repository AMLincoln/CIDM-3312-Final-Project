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
            // Not needed for current implementation, but will be necessary for features planned for future development beyond this course
            modelBuilder.Entity<Region>()
                .HasData(new List<Region>()
                {
                    new() {RegionId = 1, Name = "Randall County, TX", MacroRegionId = 30},
                    new() {RegionId = 2, Name = "Canyon, TX", MacroRegionId = 1},
                    new() {RegionId = 3, Name = "Palo Duro Canyon State Park, TX", MacroRegionId = 1},
                    new() {RegionId = 4, Name = "Zita, TX", MacroRegionId = 1},
                    new() {RegionId = 5, Name = "Lake Tanglewood, TX", MacroRegionId = 1},
                    new() {RegionId = 6, Name = "Umbarger, TX", MacroRegionId = 1},
                    new() {RegionId = 7, Name = "Potter County, TX", MacroRegionId = 30},
                    new() {RegionId = 8, Name = "Amarillo, TX", MacroRegionId = 7},
                    new() {RegionId = 9, Name = "Gentry, TX", MacroRegionId = 7},
                    new() {RegionId = 10, Name = "Gluck, TX", MacroRegionId = 7},
                    new() {RegionId = 11, Name = "Ady, TX", MacroRegionId = 7},
                    new() {RegionId = 12, Name = "Bishop Hills, TX", MacroRegionId = 7},
                    new() {RegionId = 13, Name = "Carson County, TX", MacroRegionId = 30},
                    new() {RegionId = 14, Name = "Skellytown, TX", MacroRegionId = 13},
                    new() {RegionId = 15, Name = "Wilhelm, TX", MacroRegionId = 13},
                    new() {RegionId = 16, Name = "Abell, TX", MacroRegionId = 13},
                    new() {RegionId = 17, Name = "Panhandle, TX", MacroRegionId = 13},
                    new() {RegionId = 18, Name = "White Deer, TX", MacroRegionId = 13},
                    new() {RegionId = 19, Name = "Armstrong County, TX", MacroRegionId = 30},
                    new() {RegionId = 20, Name = "Washburn, TX", MacroRegionId = 19},
                    new() {RegionId = 21, Name = "Claude, TX", MacroRegionId = 19},
                    new() {RegionId = 22, Name = "Wayside, TX", MacroRegionId = 19},
                    new() {RegionId = 23, Name = "Goodnight, TX", MacroRegionId = 19},
                    new() {RegionId = 24, Name = "Moore County, TX", MacroRegionId = 30},
                    new() {RegionId = 25, Name = "Dumas, TX", MacroRegionId = 24},
                    new() {RegionId = 26, Name = "Masterson, TX", MacroRegionId = 24},
                    new() {RegionId = 27, Name = "Bryden, TX", MacroRegionId = 24},
                    new() {RegionId = 28, Name = "Sunray, TX", MacroRegionId = 24},
                    new() {RegionId = 29, Name = "Cactus, TX", MacroRegionId = 24},
                    new() {RegionId = 30, Name = "Texas Panhandle"},

                });   
        }


        public DbSet<WildfireAdvisory> WildfireAdvisories {get; set;} = default!;
        public DbSet<Region> Regions {get; set;} = default!;
        public DbSet<Report> Reports {get; set;} = default!;
        public DbSet<ReportImage> ReportImages {get; set;} = default!;
        public DbSet<RegionWildfireAdvisory> RegionWildfireAdvisories {get; set;} = default!;
    }
}