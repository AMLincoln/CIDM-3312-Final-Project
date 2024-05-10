namespace CIDM_3312___Final_Project.Models
{
    public class Region
    {
        public int RegionId {get; set;}
        public string? Name {get; set;}
        public Region MacroRegion {get; set;} = null!;
        public int? MacroRegionId {get; set;}
        public List <Region> Subregions {get; set;} = new List<Region>();
        public List<RegionWildfireAdvisory> RegionWildfireAdvisories {get; set;} = null!;
    }
}



