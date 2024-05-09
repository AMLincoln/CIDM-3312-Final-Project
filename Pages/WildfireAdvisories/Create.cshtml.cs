using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM_3312___Final_Project.Models;

namespace CIDM_3312___Final_Project.Pages.WildfireAdvisories
{
    public class CreateModel : PageModel
    {
        private readonly CIDM_3312___Final_Project.Models.AppDbContext _context;

        public CreateModel(CIDM_3312___Final_Project.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WildfireAdvisory WildfireAdvisory { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WildfireAdvisories.Add(WildfireAdvisory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
