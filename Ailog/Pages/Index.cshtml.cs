using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ailog.Pages.Login
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (Username.Equals("user") && Password.Equals("rahasia"))
            {
                return RedirectToPage("Home");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }
    }
}
