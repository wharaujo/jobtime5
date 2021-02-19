using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticketlog.Models;

namespace Ticketlog.Data
{
    public class EstadoContext : DbContext 
    {
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<ParametroCusto> ParametroCustos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TicketLog;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
