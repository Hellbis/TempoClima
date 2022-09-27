using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using TempoClima.Models;

namespace TempoClima.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext()
            : base("name=ClimaConnection")
        {
        }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<PrevisaoClima> PrevisoesClima { get; set; }
    }
}