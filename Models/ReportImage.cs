using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312___Final_Project.Models
{
    public class ReportImage
    {
        public int ReportImageId {get; set;}
        public byte[]? Bytes {get; set;}
        public string? Description {get; set;}
        public decimal Size {get; set;}
        public int ReportId {get; set;}
        public Report Report {get; set;} = null!;
    }
}