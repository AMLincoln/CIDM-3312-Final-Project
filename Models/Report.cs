using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312___Final_Project.Models
{
    public class Report
    {
        public int ReportId {get; set;}
        public string? Type {get; set;}
        public string? Description {get; set;}
        public string? String {get; set;}
        public DateOnly DiscoveryDate {get; set;}
        public TimeOnly DiscoveryTime {get; set;}
        public string? ReportStatus {get; set;}
        public string? ReporterName {get; set;}
        public string? ReporterEmail {get; set;}
        public int RegionId {get; set;}
        public Region Region {get; set;} = null!;
        public List <ReportImage> ReportImages {get; set;} = new List<ReportImage>();
    }
}