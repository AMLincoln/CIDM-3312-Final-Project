using Microsoft.EntityFrameworkCore;

namespace CIDM_3312___Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.WildfireAdvisories.Any())
                {
                    return;
                }

                context.WildfireAdvisories.AddRange(
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for Canyon, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        WildfireAdvisoryStatus = "Active",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for Zita, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        WildfireAdvisoryStatus = "Inactive",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}        