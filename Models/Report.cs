using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIDM_3312___Final_Project.Models
{
    public class Report
    {
        public int ReportId {get; set;}
        [Required]
        [Display(Name = "Type:")]
        public string? Type {get; set;}
        [Required]
        [StringLength(500, MinimumLength = 50)]
        [Display(Name = "Description:")]
        public string? Description {get; set;}
        [Required]
        [StringLength(500, MinimumLength = 50)]
        [Display(Name = "Location:")]
        public string? Location {get; set;}
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Discovery date and time:")]
        public DateTime DiscoveryDateandTime {get; set;}
        [Required]
        [StringLength(30, MinimumLength = 5)]
        [Display(Name = "Status:")]
        public string? RiskStatus {get; set;}
        [Display(Name = "Enter your name: (optional)")]
        public string? ReporterName {get; set;}
        [Phone]
        [Display(Name = "Enter your phone number: (optional)")]
        public string? ReporterPhoneNumber {get; set;}
        [EmailAddress]
        [Display(Name = "Enter your email: (optional)")]
        public string? ReporterEmail {get; set;}
        public int RegionId {get; set;}
        public Region Region {get; set;} = null!;
        public List <ReportImage> ReportImages {get; set;} = new List<ReportImage>();
    }
}