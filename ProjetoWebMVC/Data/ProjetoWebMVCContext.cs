using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoWebMVC.Models;

namespace ProjetoWebMVC.Data
{
    public class ProjetoWebMVCContext : DbContext
    {
        public ProjetoWebMVCContext (DbContextOptions<ProjetoWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; } = default!;
        public DbSet<Vendedor> Vendedor { get; set; } = default!;   
        public DbSet<RegistroVenda> RegistroVenda { get; set; } = default!; 
    }
}
