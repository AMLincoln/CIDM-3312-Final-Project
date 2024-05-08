using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312___Final_Project.Models
{
    public class WildfireAdvisory
    {
        public int WildfireAdvisoryId {get; set;}
        public string? Title {get; set;}
        public DateTime IssueDateAndTime {get; set;}
        public string? Description {get; set;}
        public string? WildfireAdvisoryStatus {get; set;}
        public string? IssuingAuthority {get; set;}
        public string? ContactPhoneNumber {get; set;}
        public List<RegionWildfireAdvisory> RegionWildfireAdvisories {get; set;} = null!;
    }

    public class RegionWildfireAdvisory
    {
        public int WildfireAdvisoryId {get; set;}
        public int RegionId {get; set;}
        public WildfireAdvisory WildfireAdvisory {get; set;} = null!;
        public Region Region {get; set;} = null!;
    }
}