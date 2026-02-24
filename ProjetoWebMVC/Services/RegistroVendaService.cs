using ProjetoWebMVC.Data;
using ProjetoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;  
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;   

namespace ProjetoWebMVC.Services
{
    public class RegistroVendaService
    {
        private readonly ProjetoWebMVCContext _context;

        public RegistroVendaService(ProjetoWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<RegistroVenda>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RegistroVenda select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Departamento,RegistroVenda>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RegistroVenda select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Vendedor.Departamento)
                .ToListAsync();
        }
    }
}
