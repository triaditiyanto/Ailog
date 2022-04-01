#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ailog.Data;
using Ailog.Models;

namespace Ailog.Pages.Uses
{
    public class IndexModel : PageModel
    {
        private readonly Ailog.Data.AilogContext _context;

        public IndexModel(Ailog.Data.AilogContext context)
        {
            _context = context;
        }

        public IList<Use> Use { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Nama { get; set; }

        public async Task OnGetAsync()
        {
            var uses = from u in _context.Use
                         select u;
            if (!string.IsNullOrEmpty(SearchString))
            {
                uses = uses.Where(s => s.Nama.Contains(SearchString));
            }

            Use = await uses.ToListAsync();
        }
    }
}
