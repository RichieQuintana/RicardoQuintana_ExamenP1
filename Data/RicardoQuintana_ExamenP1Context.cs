using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RicardoQuintana_ExamenP1.Models;

namespace RicardoQuintana_ExamenP1.Data
{
    public class RicardoQuintana_ExamenP1Context : DbContext
    {
        public RicardoQuintana_ExamenP1Context (DbContextOptions<RicardoQuintana_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<RicardoQuintana_ExamenP1.Models.RicardoQuintana_Tabla> RicardoQuintana_Tabla { get; set; } = default!;
    }
}
