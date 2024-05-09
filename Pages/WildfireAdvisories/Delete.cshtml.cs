using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM_3312___Final_Project.Models;

namespace CIDM_3312___Final_Project.Pages.WildfireAdvisories
{
    public class DeleteModel : PageModel
    {
        private readonly CIDM_3312___Final_Project.Models.AppDbContext _context;

        public DeleteModel(CIDM_3312___Final_Project.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WildfireAdvisory WildfireAdvisory { get; set; } = default!;

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
            else
            {
                WildfireAdvisory = wildfireadvisory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wildfireadvisory = await _context.WildfireAdvisories.FindAsync(id);
            if (wildfireadvisory != null)
            {
                WildfireAdvisory = wildfireadvisory;
                _context.WildfireAdvisories.Remove(WildfireAdvisory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
