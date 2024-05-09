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

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int RecordsCount {get; set;}
        [BindProperty(SupportsGet = true)]
        public int PageMax {get; set;}
        [BindProperty(SupportsGet = true)]
        public string SortOrder {get; set;} = string.Empty;
        [BindProperty]
        public string CurrentFilter {get; set;} = string.Empty;
        

        public async Task OnGetAsync(string SortOrder, string CurrentFilter, string SearchString, int PageNum)
        {
            if (_context.WildfireAdvisories != null)
            {
                
                CurrentFilter = SearchString;
                var query = _context.WildfireAdvisories.Include(w => w.RegionWildfireAdvisories!).ThenInclude(rw => rw.Region).Select(p => p);

                if (!String.IsNullOrEmpty(CurrentFilter))
                {
                    query = query.Where(w => w.Title.ToUpper().Contains(SearchString.ToUpper()));
                }
                
                switch (SortOrder)
                {
                    case "first_asc":
                        query = query.OrderBy(wa => wa.IssueDateAndTime);
                        break;
                    case "first_desc":
                        query = query.OrderByDescending(wa => wa.IssueDateAndTime);
                        break;    
                }
                
                WildfireAdvisory = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
                RecordsCount = _context.WildfireAdvisories.Include(w => w.RegionWildfireAdvisories!).ThenInclude(rw => rw.Region).Count();
                if (RecordsCount % PageSize == 0)
                {
                    PageMax = RecordsCount / PageSize;
                }
                else
                {
                    int sub = RecordsCount % PageSize;
                    PageMax = ((RecordsCount - sub)/PageSize)+1;
                }
            }
        }
    }
}
