using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Super_Market.Models;

namespace Super_Market.Pages.Groups;

public class ShowGroups : PageModel
{
    private readonly ILogger<ShowGroups> _logger;

    public ShowGroups(ILogger<ShowGroups> logger)
    {
        _logger = logger;
    }
    public List<Groups_Class> AllGroups {get; set;}

    private readonly Group_Method g_Method;

    public ShowGroups(Group_Method G_Method)
    {
        g_Method = G_Method; 
    }
    public void OnGet()
    {
        AllGroups = g_Method.GetAllGroups();
    }
}
