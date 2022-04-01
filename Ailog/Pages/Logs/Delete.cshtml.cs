#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ailog.Data;
using Ailog.Models;

namespace Ailog.Pages.Logs
{
    public class DeleteModel : PageModel
    {
        private readonly Ailog.Data.AilogContext _context;

        public DeleteModel(Ailog.Data.AilogContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Log Log { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Log = await _context.Log.FirstOrDefaultAsync(m => m.ID == id);

            if (Log == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Log = await _context.Log.FindAsync(id);

            if (Log != null)
            {
                _context.Log.Remove(Log);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
