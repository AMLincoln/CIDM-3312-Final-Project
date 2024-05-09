using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using CIDM_3312___Final_Project.Models;

namespace CIDM_3312___Final_Project.Pages.WildfireAdvisories
{
    public class IndexModel : PageModel
    {
        private readonly CIDM_3312___Final_Project.Models.AppDbContext _context;
        private readonly IConfiguration Configuration;

        public IndexModel(CIDM_3312___Final_Project.Models.AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public IList<WildfireAdvisory> WildfireAdvisory { get;set; } = default!;
        
        
        public string? DateSort { get; set; }
        public string CurrentFilter {get; set;} = string.Empty;
        public string CurrentSort {get; set;} = string.Empty;

        public PaginatedList<WildfireAdvisory> WildfireAdvisories {get; set;} = default!;

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            DateSort = sortOrder == "first_asc" ? "first_desc" : "first_asc";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
               searchString = currentFilter;
            }
            CurrentFilter = searchString;
            var query = _context.WildfireAdvisories.Include(w => w.RegionWildfireAdvisories!).ThenInclude(rw => rw.Region).Select(p => p);

            if (!String.IsNullOrEmpty(CurrentFilter))
            {
               query = query.Where(w => w.Title.ToUpper().Contains(searchString.ToUpper()));
            }
                
            switch (sortOrder)
            {
                case "first_asc":
                    query = query.OrderBy(wa => wa.IssueDateAndTime);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(wa => wa.IssueDateAndTime);
                    break;    
            }

            var pageSize = Configuration.GetValue("PageSize", 10);
            WildfireAdvisories = await PaginatedList<WildfireAdvisory>.CreateAsync(query.AsNoTracking(), pageIndex ?? 1, pageSize);
                
                /*WildfireAdvisory = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
                RecordsCount = _context.WildfireAdvisories.Include(w => w.RegionWildfireAdvisories!).ThenInclude(rw => rw.Region).Count();
                if (RecordsCount % PageSize == 0)
                {
                    PageMax = RecordsCount / PageSize;
                }
                else
                {
                    int sub = RecordsCount % PageSize;
                    PageMax = ((RecordsCount - sub)/PageSize)+1;
                }*/
        }
    }
}
