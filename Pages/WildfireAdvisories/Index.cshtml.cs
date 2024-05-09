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
    public class IndexModel : PageModel
    {
        private readonly CIDM_3312___Final_Project.Models.AppDbContext _context;

        public IndexModel(CIDM_3312___Final_Project.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<WildfireAdvisory> WildfireAdvisory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.WildfireAdvisories != null)
            {
                WildfireAdvisory = await _context.WildfireAdvisories.Include(w => w.RegionWildfireAdvisories!).ThenInclude(rw => rw.Region).ToListAsync();
            }
        }
    }
}
