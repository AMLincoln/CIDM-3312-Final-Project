using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIDM_3312___Final_Project.Models;

namespace CIDM_3312___Final_Project.Pages.WildfireAdvisories
{
    public class EditModel : PageModel
    {
        private readonly CIDM_3312___Final_Project.Models.AppDbContext _context;

        public EditModel(CIDM_3312___Final_Project.Models.AppDbContext context)
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

            var wildfireadvisory =  await _context.WildfireAdvisories.FirstOrDefaultAsync(m => m.WildfireAdvisoryId == id);
            if (wildfireadvisory == null)
            {
                return NotFound();
            }
            WildfireAdvisory = wildfireadvisory;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(WildfireAdvisory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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

            return RedirectToPage("./Index");
        }

        private bool WildfireAdvisoryExists(int id)
        {
            return _context.WildfireAdvisories.Any(e => e.WildfireAdvisoryId == id);
        }
    }
}
