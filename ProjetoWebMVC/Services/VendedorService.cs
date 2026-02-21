using ProjetoWebMVC.Data;
using ProjetoWebMVC.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        // Encontrando um vendedor por id no banco de dados 
        public Vendedor FindById(int id)
        {
            return _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(obj => obj.Id == id);
        }
        // Removendo um vendedor do banco de dados por id   
        public void Remove(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }
    }
}
