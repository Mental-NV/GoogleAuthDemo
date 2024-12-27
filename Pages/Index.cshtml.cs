using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleAuthDemo.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGetLogin()
    {
        return Challenge(new AuthenticationProperties { RedirectUri = "/" }, "Google");
    }

    public IActionResult OnPostLogout()
    {
        return SignOut(new AuthenticationProperties { RedirectUri = "/" }, "Cookies");
    }
}
