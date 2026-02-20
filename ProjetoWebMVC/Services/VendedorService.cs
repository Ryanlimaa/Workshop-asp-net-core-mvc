using ProjetoWebMVC.Data;
using ProjetoWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoWebMVC.Services
{
    public class VendedorService
    {
        private readonly ProjetoWebMVCContext _context;

        public VendedorService(ProjetoWebMVCContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}
