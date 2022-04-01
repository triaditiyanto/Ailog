using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ailog.Pages.Homepage
{
    public class WelcomeModel : PageModel
    {
        public string Username { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnGetLogout()
        {
            return RedirectToPage("Index");
        }
    }
}
