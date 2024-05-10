// Simple redirection page when report submitted
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIDM_3312___Final_Project.Pages.Reports;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
  
    }
}