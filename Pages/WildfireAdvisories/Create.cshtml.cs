using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIDM_3312___Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace CIDM_3312___Final_Project.Pages.WildfireAdvisories
{
    public class CreateModel : PageModel
    {
        private readonly CIDM_3312___Final_Project.Models.AppDbContext _context;

        public CreateModel(CIDM_3312___Final_Project.Models.AppDbContext context)
        {
            _context = context;
        }
        public List<Region> Regions {get; set;} = default!;
        public SelectList RegionsDropDown {get; set;} = default!;
        public SelectList RegionsDropDown2 {get; set;} = default!;
        public SelectList RegionsDropDown3 {get; set;} = default!;
        public SelectList RegionsDropDown4 {get; set;} = default!;
        public SelectList RegionsDropDown5 {get; set;} = default!;
        [BindProperty]
        [Required]
        [Display(Name = "first Region")]
        public int RegionIdToAdd {get; set;}
        [BindProperty]
        public int? RegionIdToAdd2 {get; set;}
        [BindProperty]
        public int? RegionIdToAdd3 {get; set;}
        [BindProperty]
        public int? RegionIdToAdd4 {get; set;}
        [BindProperty]
        public int? RegionIdToAdd5 {get; set;}
        public IActionResult OnGet()
        {
            Regions = _context.Regions.ToList();
            RegionsDropDown = new SelectList(Regions, "RegionId", "Name");
            RegionsDropDown2 = new SelectList(Regions, "RegionId", "Name");
            RegionsDropDown3 = new SelectList(Regions, "RegionId", "Name");
            RegionsDropDown4 = new SelectList(Regions, "RegionId", "Name");
            RegionsDropDown5 = new SelectList(Regions, "RegionId", "Name");
            return Page();
        }

        [BindProperty]
        public WildfireAdvisory WildfireAdvisory { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            Regions = _context.Regions.ToList();
            RegionsDropDown = new SelectList(Regions, "RegionId", "Name");
            RegionsDropDown2 = new SelectList(Regions, "RegionId", "Name");
            RegionsDropDown3 = new SelectList(Regions, "RegionId", "Name");
            RegionsDropDown4 = new SelectList(Regions, "RegionId", "Name");
            RegionsDropDown5 = new SelectList(Regions, "RegionId", "Name");

            _context.WildfireAdvisories.Add(WildfireAdvisory);
            await _context.SaveChangesAsync();
            try
            {
                var wildfireAdvisory = await _context.WildfireAdvisories.Where(wa => wa.WildfireAdvisoryId == WildfireAdvisory.WildfireAdvisoryId).FirstOrDefaultAsync(); 
                RegionWildfireAdvisory regionToAdd = new RegionWildfireAdvisory {WildfireAdvisoryId = wildfireAdvisory.WildfireAdvisoryId, RegionId = RegionIdToAdd};
                _context.Add(regionToAdd);
                if (RegionIdToAdd2 != null)
                {
                    RegionWildfireAdvisory regionToAdd2 = new RegionWildfireAdvisory {WildfireAdvisoryId = wildfireAdvisory.WildfireAdvisoryId, RegionId = (int)RegionIdToAdd2};
                    _context.Add(regionToAdd2);
                }
                if (RegionIdToAdd3 != null)
                {
                    RegionWildfireAdvisory regionToAdd3 = new RegionWildfireAdvisory {WildfireAdvisoryId = wildfireAdvisory.WildfireAdvisoryId, RegionId = (int)RegionIdToAdd3};
                    _context.Add(regionToAdd3);
                }
                if (RegionIdToAdd4 != null)
                {
                    RegionWildfireAdvisory regionToAdd4 = new RegionWildfireAdvisory {WildfireAdvisoryId = wildfireAdvisory.WildfireAdvisoryId, RegionId = (int)RegionIdToAdd4};
                    _context.Add(regionToAdd4);
                }
                if (RegionIdToAdd5 != null)
                {
                    RegionWildfireAdvisory regionToAdd5 = new RegionWildfireAdvisory {WildfireAdvisoryId = wildfireAdvisory.WildfireAdvisoryId, RegionId = (int)RegionIdToAdd5};
                    _context.Add(regionToAdd5);
                }         
                _context.SaveChanges();
            
                return RedirectToPage("./Index");
            }
            catch
            {
                return Page();
            }
            
            
            
            
        }
    }
}
