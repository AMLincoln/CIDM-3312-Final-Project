using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIDM_3312___Final_Project.Models
{
    public class WildfireAdvisory
    {
        public int WildfireAdvisoryId {get; set;}
        [Required]
        [Display(Name = "Title:")]
        public string? Title {get; set;}
        [Required]
        [Display(Name = "Effective date and time:")]
        public DateTime IssueDateAndTime {get; set;}
        [Required]
        [Display(Name = "Description:")]
        public string? Description {get; set;}
        [Required]
        [Display(Name = "Issuer:")]
        public string? IssuingAuthority {get; set;}
        [Required]
        [Phone]
        [Display(Name = "Contact:")]
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