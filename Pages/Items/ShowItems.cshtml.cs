using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Super_Market.Pages.Items;

public class ShowItems : PageModel
{
    private readonly ILogger<ShowItems> _logger;

    public ShowItems(ILogger<ShowItems> logger)
    {
        _logger = logger;
    }

    public int Item_Id { get; set; }
    public void OnGet(int Id)
    {
        Item_Id = Id;
    }
}