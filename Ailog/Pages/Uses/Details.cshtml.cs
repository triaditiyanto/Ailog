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

namespace Ailog.Pages.Uses
{
    public class DetailsModel : PageModel
    {
        private readonly Ailog.Data.AilogContext _context;

        public DetailsModel(Ailog.Data.AilogContext context)
        {
            _context = context;
        }

        public Use Use { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Use = await _context.Use.FirstOrDefaultAsync(m => m.ID == id);

            if (Use == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
