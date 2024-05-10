using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM_3312___Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace CIDM_3312___Final_Project.Pages.Reports;
public class ReportModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<ReportModel> _logger;

    [BindProperty]
    public Report Report {get; set;} = default!;
    public SelectList TypeDropDown {get; set;} = default!;
    public ReportModel(AppDbContext context, ILogger<ReportModel> logger)
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

    public IActionResult OnGet()
    {
        Regions = _context.Regions.ToList();
        RegionsDropDown = new SelectList(Regions, "RegionId", "Name");
        TypeDropDown = new SelectList("", "Description");
        return Page();
    }
    public IActionResult OnPost()
    {
        Regions = _context.Regions.ToList();
        RegionsDropDown = new SelectList(Regions, "RegionId", "Name");
        Report.RegionId = RegionIdToAdd;
        _context.Reports.Add(Report);
        _context.SaveChanges();

        return RedirectToPage("/Reports/SuccessfulReport");
    }
}