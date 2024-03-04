using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LottoAdat.Models;

namespace LottpAPI.Data
{
    public class LottpAPIContext : DbContext
    {
        public LottpAPIContext (DbContextOptions<LottpAPIContext> options)
            : base(options)
        {
        }

        public DbSet<LottoAdat.Models.Employee> Employee { get; set; } = default!;

        public DbSet<LottoAdat.Models.Tipp>? Tipp { get; set; }
    }
}
