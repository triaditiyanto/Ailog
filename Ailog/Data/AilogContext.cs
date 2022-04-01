#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ailog.Models;

namespace Ailog.Data
{
    public class AilogContext : DbContext
    {
        public AilogContext (DbContextOptions<AilogContext> options)
            : base(options)
        {
        }

        public DbSet<Ailog.Models.Log> Log { get; set; }

        public DbSet<Ailog.Models.Use> Use { get; set; }

    }
}
