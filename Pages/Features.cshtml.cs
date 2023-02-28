using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KingsCorner.Pages;

public class FeaturesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public FeaturesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}
