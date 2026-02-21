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
        // Enviando a lista para o banco de dados   
        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
        // Inserindo um novo vendedor no banco de dados    
        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
