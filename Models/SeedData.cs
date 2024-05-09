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
                    // Wildfire advisories assigned simply to meet minimum requirements for paging support and demonstration, and does not reflect how advisories and alerts would be realistically assigned
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for Skellytown, TX",
                        IssueDateAndTime = DateTime.Now,
                        // Sample text for wildfire watch, voluntary and mandatory evacuation, and road closure advisories taken from chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://www.onsolve.com/wp-content/uploads/2021/05/KIT_-_OnSolve_-_Wildfire_Kit_-_Sample_Messaging_Templates.pdf
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for Panhandle, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for White Deer, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for Armstrong County, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for the Texas Panhandle",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for Carson County, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Smoke Advisory for Randall County, TX",
                        IssueDateAndTime = DateTime.Now,
                        // Basis for smoke advisory text taken from https://www.ourair.org/todays-air-quality/
                        Description = "The Randall County Fire Department has issued a smoke advisory for Randall County, TX due to nearby wildfires. For sensitive groups, reduce prolonged or heavy exertion. Watch for symptoms that may indicate respiratory distress, such as coughing or shortness of breath. People with asthma should follow their asthma action plans and keep quick relief medicine handy. If you have heart disease, contact your provider if you notice the following symptoms: palpitations, shortness of breath, or unusual fatigue.",
                        IssuingAuthority = "Randall County Fire Department",
                        ContactPhoneNumber = "(234) 567-8901"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Smoke Advisory for Potter County, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The Potter County Fire Department has issued a smoke advisory for Randall County, TX due to nearby wildfires. For sensitive groups, reduce prolonged or heavy exertion. Watch for symptoms that may indicate respiratory distress, such as coughing or shortness of breath. People with asthma should follow their asthma action plans and keep quick relief medicine handy. If you have heart disease, contact your provider if you notice the following symptoms: palpitations, shortness of breath, or unusual fatigue.",
                        IssuingAuthority = "Potter County Fire Department",
                        ContactPhoneNumber = "(345) 678-9012"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Smoke Advisory for Abell, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The Carson County Fire Department has issued a smoke advisory for Randall County, TX due to nearby wildfires. For sensitive groups, reduce prolonged or heavy exertion. Watch for symptoms that may indicate respiratory distress, such as coughing or shortness of breath. People with asthma should follow their asthma action plans and keep quick relief medicine handy. If you have heart disease, contact your provider if you notice the following symptoms: palpitations, shortness of breath, or unusual fatigue.",
                        IssuingAuthority = "Carson County Fire Department",
                        ContactPhoneNumber = "(456) 789-0123"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Smoke Advisory for Wilhelm, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The Carson County Fire Department has issued a smoke advisory for Randall County, TX due to nearby wildfires. For sensitive groups, reduce prolonged or heavy exertion. Watch for symptoms that may indicate respiratory distress, such as coughing or shortness of breath. People with asthma should follow their asthma action plans and keep quick relief medicine handy. If you have heart disease, contact your provider if you notice the following symptoms: palpitations, shortness of breath, or unusual fatigue.",
                        IssuingAuthority = "Carson County Fire Department",
                        ContactPhoneNumber = "(456) 789-0123"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Smoke Advisory for Goodnight, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The Armstrong County Fire Department has issued a smoke advisory for Randall County, TX due to nearby wildfires. For sensitive groups, reduce prolonged or heavy exertion. Watch for symptoms that may indicate respiratory distress, such as coughing or shortness of breath. People with asthma should follow their asthma action plans and keep quick relief medicine handy. If you have heart disease, contact your provider if you notice the following symptoms: palpitations, shortness of breath, or unusual fatigue.",
                        IssuingAuthority = "Armstrong County Fire Department",
                        ContactPhoneNumber = "(567) 890-1234"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Voluntary Evacuation for Goodnight, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "Residents, businesses and others in and around Goodnight, TX. Please BE READY to EVACUATE. People in these areas may be asked to evacuate quickly if the wildfire near Ashtola, TX worsens.",
                        IssuingAuthority = "Armstrong County Fire Department",
                        ContactPhoneNumber = "(567) 890-1234"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Voluntary Evacuation for Moore County, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "Residents, businesses and others in and around the areas of Dumas, Masterson, and Cactus. Please BE READY to EVACUATE. People in these areas may be asked to evacuate quickly if the wildfire at Bryden, TX worsens.",
                        IssuingAuthority = "Moore County Fire Department",
                        ContactPhoneNumber = "(678) 901-2345"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Mandatory Evacuation for Bryden, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "An evacuation order is in affect for residents, businesses and others in Bryden, TX: NO ENTRANCE IS ALLOWED TO EVACUATED AREAS. PLEASE COOPERATE WITH FIRST RESPONDERS.",
                        IssuingAuthority = "Moore County Fire Department",
                        ContactPhoneNumber = "(678) 901-2345"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Mandatory Evacuation for Sunray, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "An evacuation order is in affect for residents, businesses and others in Sunray, TX: NO ENTRANCE IS ALLOWED TO EVACUATED AREAS. PLEASE COOPERATE WITH FIRST RESPONDERS.",
                        IssuingAuthority = "Moore County Fire Department",
                        ContactPhoneNumber = "(678) 901-2345"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Mandatory Evacuation for Moore County, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "An evacuation order is in affect for residents, businesses and others in the areas of Bryden and Sunray: NO ENTRANCE IS ALLOWED TO EVACUATED AREAS. PLEASE COOPERATE WITH FIRST RESPONDERS.",
                        IssuingAuthority = "Moore County Fire Department",
                        ContactPhoneNumber = "(678) 901-2345"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Road Closures in Moore County, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "FM 281 from Bryden, TX to Sunray, TX is blocked due to a brush fire. Detour is in place at Light Plant Road and Fisher Road.",
                        IssuingAuthority = "Moore County Fire Department",
                        ContactPhoneNumber = "(678) 901-2345"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Road Closures in Sunray, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "FM 281 from Bryden, TX to Sunray, TX is blocked due to a brush fire. Detour is in place at Light Plant Road and Fisher Road.",
                        IssuingAuthority = "Moore County Fire Department",
                        ContactPhoneNumber = "(678) 901-2345"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Road Closures in Bryden, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "FM 281 from Bryden, TX to Sunray, TX is blocked due to a brush fire. Detour is in place at Light Plant Road and Fisher Road.",
                        IssuingAuthority = "Moore County Fire Department",
                        ContactPhoneNumber = "(678) 901-2345"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Road Closures in Goodnight, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "Hwy 287 from Goodnight, TX to Ashtola, TX is blocked due to a brush fire.",
                        IssuingAuthority = "Armstrong County Fire Department",
                        ContactPhoneNumber = "(567) 890-1234"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Road Closures in Armstrong County, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "Hwy 287 from Goodnight, TX to Ashtola, TX is blocked due to a brush fire.",
                        IssuingAuthority = "Armstrong County Fire Department",
                        ContactPhoneNumber = "(567) 890-1234"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Utilities Disruptions in Moore County, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "Xcel Energy has cut electrical power to the towns of Bryden, TX and Sunray, TX to aid in wildfire suppression efforts. Power will be restored once the all clear has been given by wildfire responders.",
                        IssuingAuthority = "Moore County Clerk's Office",
                        ContactPhoneNumber = "(901) 234-5678"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Utilities Disruptions in Bryden, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "Xcel Energy has cut electrical power to the town of Bryden, TX to aid in wildfire suppression efforts. Power will be restored once the all clear has been given by wildfire responders.",
                        IssuingAuthority = "Moore County Clerk's Office",
                        ContactPhoneNumber = "(901) 234-5678"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Utilities Disruptions in Sunray, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "Xcel Energy has cut electrical power to the town of Sunray, TX to aid in wildfire suppression efforts. Power will be restored once the all clear has been given by wildfire responders.",
                        IssuingAuthority = "Moore County Clerk's Office",
                        ContactPhoneNumber = "(901) 234-5678"
                    },
                    new WildfireAdvisory
                    {
                        Title = "Utilities Disruptions in Goodnight, TX",
                        IssueDateAndTime = DateTime.Now,
                        Description = "Atmos Energy has cut gas to the town of Goodnight, TX to aid in wildfire suppression efforts in Ashtola, TX. Service will be restored once the all clear has been given by wildfire responders.",
                        IssuingAuthority = "Armstrong County Clerk's Office",
                        ContactPhoneNumber = "(152) 258-9874"
                    },
                    // Added to show many to many relationship was implemented correctly throughout program.
                    new WildfireAdvisory
                    {
                        Title = "Fire Weather Watch for Randall and Potter Counties",
                        IssueDateAndTime = DateTime.Now,
                        Description = "The National Weather Service issued a fire weather watch for our area. A fire weather watch means upcoming weather conditions could result in a high potential for development of a wildfire. Please use extreme cause with any outdoor ignition sources.",
                        IssuingAuthority = "National Weather Service",
                        ContactPhoneNumber = "(123) 456-7890"
                    }
                );
                context.SaveChanges();
            }

            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.RegionWildfireAdvisories.Any())
                {
                    return;
                }
                context.RegionWildfireAdvisories.AddRange(
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 1, RegionId = 14},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 2, RegionId = 17},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 3, RegionId = 18},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 4, RegionId = 19},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 5, RegionId = 30},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 6, RegionId = 13},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 7, RegionId = 1},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 8, RegionId = 7},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 9, RegionId = 16},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 10, RegionId = 15},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 11, RegionId = 23},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 12, RegionId = 23},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 13, RegionId = 24},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 14, RegionId = 27},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 15, RegionId = 28},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 16, RegionId = 24},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 17, RegionId = 24},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 18, RegionId = 28},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 19, RegionId = 27},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 20, RegionId = 23},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 21, RegionId = 19},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 22, RegionId = 24},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 23, RegionId = 27},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 24, RegionId = 28},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 25, RegionId = 23},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 26, RegionId = 1},
                    new RegionWildfireAdvisory {WildfireAdvisoryId = 26, RegionId = 7}
                );
                context.SaveChanges();
            }
        }

        
    }
}        