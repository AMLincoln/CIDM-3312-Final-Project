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
    public class EditModel : PageModel
    {
        private readonly ILogger<EditModel> _logger;
        private readonly CIDM_3312___Final_Project.Models.AppDbContext _context;

        public EditModel(CIDM_3312___Final_Project.Models.AppDbContext context, ILogger<EditModel> logger)
        {
            _context = context;
            _logger = logger;
        }
        public List<Region> Regions {get; set;} = default!;
        public SelectList RegionsDropDown {get; set;} = default!;
        [BindProperty]
        [Required]
        [Display(Name = "Region")]
        public int RegionIdToAdd {get; set;}
        [BindProperty]
        public WildfireAdvisory WildfireAdvisory { get; set; } = default!;
        [BindProperty]
        public int RegionIdToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wildfireadvisory = await _context.WildfireAdvisories.Include(w => w.RegionWildfireAdvisories!).ThenInclude(rw => rw.Region).FirstOrDefaultAsync(m => m.WildfireAdvisoryId == id);
            if (wildfireadvisory == null)
            {
                return NotFound();
            }
            WildfireAdvisory = wildfireadvisory;
            Regions = _context.Regions.ToList();
            RegionsDropDown = new SelectList(Regions, "RegionId", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var wildfireAdvisory = await _context.WildfireAdvisories.Where(wa => wa.WildfireAdvisoryId == WildfireAdvisory.WildfireAdvisoryId).FirstOrDefaultAsync(); 
            Regions = _context.Regions.ToList();
            RegionsDropDown = new SelectList(Regions, "RegionId", "Name");
           
            // _context.Attach(WildfireAdvisory).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            try
            { 
                RegionWildfireAdvisory regionToAdd = new RegionWildfireAdvisory {WildfireAdvisoryId = wildfireAdvisory.WildfireAdvisoryId, RegionId = RegionIdToAdd};
                _context.Add(regionToAdd);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WildfireAdvisoryExists(WildfireAdvisory.WildfireAdvisoryId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<IActionResult> OnPostRemoveRegionAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wildfireadvisory = await _context.WildfireAdvisories.Include(w => w.RegionWildfireAdvisories!).ThenInclude(rw => rw.Region).FirstOrDefaultAsync(m => m.WildfireAdvisoryId == id);

            RegionWildfireAdvisory regionToDrop = _context.RegionWildfireAdvisories.Find(id.Value, RegionIdToDelete)!;

            if (regionToDrop != null)
            {
                _context.Remove(regionToDrop);
                _context.SaveChanges();
            }
            else
            {
                _logger.LogWarning("This region is not associated with this wildfire advisory.");
            }

            return RedirectToPage("./Index");
        }
        private bool WildfireAdvisoryExists(int id)
        {
            return _context.WildfireAdvisories.Any(e => e.WildfireAdvisoryId == id);
        }
    }
}
