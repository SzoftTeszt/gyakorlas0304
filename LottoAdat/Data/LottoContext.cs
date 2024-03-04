using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoAdat.Data
{
    public class LottoContext : DbContext
    {
        public LottoContext(DbContextOptions<LottoContext> options)
            : base(options)
        {
        }

        public LottoContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LottpAPI.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<LottoAdat.Models.Employee> Employee { get; set; } = default!;

        public DbSet<LottoAdat.Models.Tipp>? Tipp { get; set; }
    }
}
