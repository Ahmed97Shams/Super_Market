using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Super_Market.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    [BindProperty]
    public int N1 { get; set; }
    public string Mes { get; set; }
    public void OnGet()
    {
        Mes ="welcome Ahmed Hassan Shams";
        N1 = 0;

    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (N1==5)
        {
            return RedirectToPage("/Items/ShowItems");    
        } 
        else
        {
            return RedirectToPage("/Groups/ShowGroups");    
        }

        
    }
}
