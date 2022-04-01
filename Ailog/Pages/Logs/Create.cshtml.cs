﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ailog.Data;
using Ailog.Models;

namespace Ailog.Pages.Logs
{
    public class CreateModel : PageModel
    {
        private readonly Ailog.Data.AilogContext _context;

        public CreateModel(Ailog.Data.AilogContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Log Log { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Log.Add(Log);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
