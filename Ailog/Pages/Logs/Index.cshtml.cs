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

namespace Ailog.Pages.Logs
{
    public class IndexModel : PageModel
    {
        private readonly Ailog.Data.AilogContext _context;

        public IndexModel(Ailog.Data.AilogContext context)
        {
            _context = context;
        }

        public IList<Log> Log { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Nama_Barang { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Jenis_Barang { get; set; }
        public async Task OnGetAsync()
        {
            var logs = from l in _context.Log
                       select l;
            if (!string.IsNullOrEmpty(SearchString))
            {
                logs = logs.Where(s => s.Nama_Barang.Contains(SearchString));
            }

            Log = await logs.ToListAsync();
        }
    }
}
