using ProjetoWebMVC.Data;
using ProjetoWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoWebMVC.Services
{
    public class DepartamentoService
    {
        private readonly ProjetoWebMVCContext _context;

        public DepartamentoService(ProjetoWebMVCContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Name).ToList();  
        }
    }
}
